using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sharp7;
public class DoButton : MonoBehaviour
{
    public Sharp7.S7Client c = new Sharp7.S7Client();
    public byte[] bites = new byte[2];
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public ConveyorBelt belt;
    public Detect disable;
    public void return_normal1()
    {
        int p = c.DBRead(1, 0, 2, bites);
         S7.SetBitAt(ref bites, 1, 0, false);
          int k = c.DBWrite(1, 0, 2, bites);
        GameObject gameObject = GameObject.Find("B1");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.89f,gameObject.transform.position.z);
    }
    public void button1()
    {
       c.ConnectTo(GameObject.Find("Address").GetComponent<TextMesh>().text,0,1);
         int p = c.DBRead(1, 0, 2, bites);
         S7.SetBitAt(ref bites, 1, 0, true);
         int k = c.DBWrite(1, 0, 2, bites);
        GameObject gameObject = GameObject.Find("B1");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.88f,gameObject.transform.position.z);
    }
    public void return_normal2()
    {
        int p = c.DBRead(1, 0, 2, bites);
            S7.SetBitAt(ref bites, 1, 1, false);
            int k = c.DBWrite(1, 0, 2, bites);
        GameObject gameObject = GameObject.Find("B2");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.89f,gameObject.transform.position.z);
    }
    public void button2()
    {
        c.ConnectTo(GameObject.Find("Address").GetComponent<TextMesh>().text,0,1);
        int p = c.DBRead(1, 0, 2, bites);
            S7.SetBitAt(ref bites, 1, 1, true);
            int k = c.DBWrite(1, 0, 2, bites);
        GameObject gameObject = GameObject.Find("B2");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.88f,gameObject.transform.position.z);
    }
    public void return_normal3()
    {
        int p = c.DBRead(1, 0, 2, bites);
            S7.SetBitAt(ref bites, 1, 2, false);
            int k = c.DBWrite(1, 0, 2, bites);
        GameObject gameObject = GameObject.Find("B3");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.89f,gameObject.transform.position.z);
    }
    public void button3()
    {
        c.ConnectTo(GameObject.Find("Address").GetComponent<TextMesh>().text,0,1);
        int p = c.DBRead(1, 0, 2, bites);
            S7.SetBitAt(ref bites, 1, 2, true);
            int k = c.DBWrite(1, 0, 2, bites);
        GameObject gameObject = GameObject.Find("B3");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.88f,gameObject.transform.position.z);
       
    }
    public void return_normal4()
    {
        int p = c.DBRead(1, 0, 2, bites);
            S7.SetBitAt(ref bites, 1, 3, false);
            int k = c.DBWrite(1, 0, 2, bites);
        GameObject gameObject = GameObject.Find("B4");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.89f,gameObject.transform.position.z);
    }
    public void button4()
    {
        c.ConnectTo(GameObject.Find("Address").GetComponent<TextMesh>().text,0,1);
        int p = c.DBRead(1, 0, 2, bites);
            S7.SetBitAt(ref bites, 1, 3, true);
            int k = c.DBWrite(1, 0, 2, bites);
        GameObject gameObject = GameObject.Find("B4");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.88f,gameObject.transform.position.z);
      
    }
    public void return_normal5()
    {
        GameObject gameObject = GameObject.Find("B5");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.89f,gameObject.transform.position.z);
    }
    public void button5()
    {
        GameObject gameObject = GameObject.Find("B5");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.88f,gameObject.transform.position.z);
      
        Invoke("return_normal5",0.5f);
    }
    public void return_normal6()
    {
        GameObject gameObject = GameObject.Find("B6");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.89f,gameObject.transform.position.z);
    }
    public void button6()
    {
        string address = GameObject.Find("Address").GetComponent<TextMesh>().text;
        GameObject gameObject = GameObject.Find("B6");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.88f,gameObject.transform.position.z);
        int result = c.ConnectTo(address, 0, 1);
        if(result == 0)
        {
            GameObject.Find("H5").GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            GameObject.Find("H5").GetComponent<Renderer>().material.color = Color.red;
        }
        Invoke("return_normal6",0.5f);
    }
    public void return_normal7()
    {
        GameObject gameObject = GameObject.Find("B7");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.89f,gameObject.transform.position.z);
    }
    public void button7()
    {
        GameObject gameObject = GameObject.Find("B7");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.88f,gameObject.transform.position.z);
        belt.direction = -belt.direction;
        Invoke("return_normal7",0.5f);
    }
    public void write_1()
    {
        GameObject.Find("Address").GetComponent<TextMesh>().text = GameObject.Find("Address").GetComponent<TextMesh>().text + "1";
    }
    public void write_2()
    {
        GameObject.Find("Address").GetComponent<TextMesh>().text = GameObject.Find("Address").GetComponent<TextMesh>().text + "2";
    }
    public void write_3()
    {
        GameObject.Find("Address").GetComponent<TextMesh>().text = GameObject.Find("Address").GetComponent<TextMesh>().text + "3";
    }
    public void write_4()
    {
        GameObject.Find("Address").GetComponent<TextMesh>().text = GameObject.Find("Address").GetComponent<TextMesh>().text + "4";
    }
    public void write_5()
    {
        GameObject.Find("Address").GetComponent<TextMesh>().text = GameObject.Find("Address").GetComponent<TextMesh>().text + "5";
    }
    public void write_6()
    {
        GameObject.Find("Address").GetComponent<TextMesh>().text = GameObject.Find("Address").GetComponent<TextMesh>().text + "6";
    }
    public void write_7()
    {
        GameObject.Find("Address").GetComponent<TextMesh>().text = GameObject.Find("Address").GetComponent<TextMesh>().text + "7";
    }
    public void write_8()
    {
        GameObject.Find("Address").GetComponent<TextMesh>().text = GameObject.Find("Address").GetComponent<TextMesh>().text + "8";
    }
    public void write_9()
    {
        GameObject.Find("Address").GetComponent<TextMesh>().text = GameObject.Find("Address").GetComponent<TextMesh>().text + "9";
    }
    public void write_dot()
    {
        GameObject.Find("Address").GetComponent<TextMesh>().text = GameObject.Find("Address").GetComponent<TextMesh>().text + ".";
    }
    public void write_delete()
    {
        GameObject.Find("Address").GetComponent<TextMesh>().text = "";
    }
    public void write_0()
    {
        GameObject.Find("Address").GetComponent<TextMesh>().text = GameObject.Find("Address").GetComponent<TextMesh>().text + "0";
    }
    public void Connect()
    {
        belt.c.ConnectTo(GameObject.Find("Address").GetComponent<TextMesh>().text,0,1);
    }
    // Update is called once per frame
    void Update()
    {
    }
}
