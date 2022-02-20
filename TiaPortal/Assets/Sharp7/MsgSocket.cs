﻿using System;
using System.Threading;
using System.Net.Sockets;

namespace Sharp7
{

    class MsgSocket
    {
        private Socket TCPSocket;
        private int _ReadTimeout = 2000;
        private int _WriteTimeout = 2000;
        private int _ConnectTimeout = 1000;
        private int LastError;
        public MsgSocket()
        {
        }

        ~MsgSocket()
        {
            Close();
        }

        public void Close()
        {
            if (TCPSocket != null)
            {
                TCPSocket.Dispose();
                TCPSocket = null;
            }
        }

        private void CreateSocket()
        {
            TCPSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            TCPSocket.NoDelay = true;
        }

        private void TCPPing(string Host, int Port)
        {
            // To Ping the PLC an Asynchronous socket is used rather then an ICMP packet.
            // This allows the use also across Internet and Firewalls (obviously the port must be opened)           
            LastError = 0;
            Socket PingSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {

                IAsyncResult result = PingSocket.BeginConnect(Host, Port, null, null);
                bool success = result.AsyncWaitHandle.WaitOne(_ConnectTimeout, true);

                if (!success)
                {
                    LastError = S7Consts.errTCPConnectionFailed;
                }
            }
            catch
            {
                LastError = S7Consts.errTCPConnectionFailed;
            }

            PingSocket.Close();
        }

        public int Connect(string Host, int Port)
        {
            LastError = 0;
            if (!Connected)
            { 
                TCPPing(Host, Port);
                if (LastError == 0)
                try
                {
                        CreateSocket();
                        TCPSocket.Connect(Host, Port);
                }
                catch
                {
                        LastError = S7Consts.errTCPConnectionFailed;
                }
            }
            return LastError;
        }

        private int WaitForData(int Size, int Timeout)
        {
            bool Expired = false;
            int SizeAvail;
            int Elapsed = Environment.TickCount;
            LastError = 0;
            try
            {
                SizeAvail = TCPSocket.Available;
                while ((SizeAvail < Size) && (!Expired))
                {
                    Thread.Sleep(2);
                    SizeAvail = TCPSocket.Available;
                    Expired = Environment.TickCount - Elapsed > Timeout;
                    // If timeout we clean the buffer
                    if (Expired && (SizeAvail > 0))
                    {
                        try
                        {
                            byte[] Flush = new byte[SizeAvail];
                            TCPSocket.Receive(Flush, 0, SizeAvail, SocketFlags.None);
                        }
                        catch
                        {
                            LastError = S7Consts.errTCPDataReceive;
                        }
                    }
                }
            }
            catch
            {
                LastError = S7Consts.errTCPDataReceive;
            }
            if (Expired)
            {
                LastError = S7Consts.errTCPDataReceive;
            }
            return LastError;
        }

        public int Receive(byte[] Buffer, int Start, int Size)
        {

            int BytesRead = 0;
            LastError = WaitForData(Size, _ReadTimeout);
            if (LastError == 0)
            {
                try
                {
                    BytesRead = TCPSocket.Receive(Buffer, Start, Size, SocketFlags.None);
                }
                catch
                {
                    LastError = S7Consts.errTCPDataReceive;
                }
                if (BytesRead == 0) // Connection Reset by the peer
                {
                    LastError = S7Consts.errTCPDataReceive;
                    Close();
                }
            }
            return LastError;
        }

        public int Send(byte[] Buffer, int Size)
        {
            LastError = 0;
            try
            {
                TCPSocket.Send(Buffer, Size, SocketFlags.None);
            }
            catch
            {
                LastError = S7Consts.errTCPDataSend;
                Close();
            }
            return LastError;
        }

        public bool Connected => (TCPSocket != null) && (TCPSocket.Connected);

        public int ReadTimeout
        {
            get => _ReadTimeout;
            set => _ReadTimeout = value;
        }

        public int WriteTimeout
        {
            get => _WriteTimeout;
            set => _WriteTimeout = value;
        }
        public int ConnectTimeout
        {
            get => _ConnectTimeout;
            set => _ConnectTimeout = value;
        }
    }   
}
