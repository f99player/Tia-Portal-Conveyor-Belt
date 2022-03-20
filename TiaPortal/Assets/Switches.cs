using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sharp7;
public class Switches : MonoBehaviour
{
    public Sharp7.S7Client c = new Sharp7.S7Client();
    public byte[] bites = new byte[3];
    int brojac1 = 1;
    int brojac2 = 1;
    int brojac3 = 1;
    int brojac4 = 1;
    int brojac5 = 1;
    int brojac6 = 1;
    int brojac7 = 1;
    void Start()
    {
        
    }
    public void switch1()
    {
        if(brojac1  ==  1)
        {
        c.ConnectTo(GameObject.Find("Address").GetComponent<TextMesh>().text,0,1);
        GameObject gameObject = GameObject.Find("Switch1");
        gameObject.transform.Rotate(0,180,0);
        c.DBRead(1,0,3,bites);
        S7.SetBitAt(bites,1,6,true);
        c.DBWrite(1,0,3,bites);
        brojac1 = 2;
        }
        else
        {
        GameObject gameObject = GameObject.Find("Switch1");
        gameObject.transform.Rotate(0,180,0);
        c.DBRead(1,0,3,bites);
        S7.SetBitAt(bites,1,6,false);
        c.DBWrite(1,0,3,bites);
        brojac1 = 1;
        }
    }
    public void switch2()
    {
        if(brojac2  ==  1)
        {
        c.ConnectTo(GameObject.Find("Address").GetComponent<TextMesh>().text,0,1);
        GameObject gameObject = GameObject.Find("Switch2");
        gameObject.transform.Rotate(0,180,0);
        c.DBRead(1,0,3,bites);
        S7.SetBitAt(bites,1,7,true);
        c.DBWrite(1,0,3,bites);
        brojac2 = 2;
        }
        else
        {
        GameObject gameObject = GameObject.Find("Switch2");
        gameObject.transform.Rotate(0,180,0);
        c.DBRead(1,0,3,bites);
        S7.SetBitAt(bites,1,7,false);
        c.DBWrite(1,0,3,bites);
        brojac2 = 1;
        }
    }
    public void switch3()
    {
        if(brojac3  ==  1)
        {
        c.ConnectTo(GameObject.Find("Address").GetComponent<TextMesh>().text,0,1);
        GameObject gameObject = GameObject.Find("Switch3");
        gameObject.transform.Rotate(0,180,0);
        c.DBRead(1,0,3,bites);
        S7.SetBitAt(bites,2,0,true);
        c.DBWrite(1,0,3,bites);
        brojac3 = 2;
        }
        else
        {
        GameObject gameObject = GameObject.Find("Switch3");
        gameObject.transform.Rotate(0,180,0);
        c.DBRead(1,0,3,bites);
        S7.SetBitAt(bites,2,0,false);
        c.DBWrite(1,0,3,bites);
        brojac3 = 1;
        }
    }
    public void switch4()
    {
        if(brojac4  ==  1)
        {
        c.ConnectTo(GameObject.Find("Address").GetComponent<TextMesh>().text,0,1);
        GameObject gameObject = GameObject.Find("Switch4");
        gameObject.transform.Rotate(0,180,0);
        c.DBRead(1,0,3,bites);
        S7.SetBitAt(bites,2,1,true);
        c.DBWrite(1,0,3,bites);
        brojac4 = 2;
        }
        else
        {
           GameObject gameObject = GameObject.Find("Switch4");
        gameObject.transform.Rotate(0,180,0);
        c.DBRead(1,0,3,bites);
        S7.SetBitAt(bites,2,1,false);
        c.DBWrite(1,0,3,bites);
        brojac4 = 1;
        }
    }
    public void switch5()
    {
        if(brojac5  ==  1)
        {
        c.ConnectTo(GameObject.Find("Address").GetComponent<TextMesh>().text,0,1);
        GameObject gameObject = GameObject.Find("Switch5");
        gameObject.transform.Rotate(0,180,0);
        c.DBRead(1,0,3,bites);
        S7.SetBitAt(bites,2,2,true);
        c.DBWrite(1,0,3,bites);
        brojac5 = 2;
        }
        else
        {
        GameObject gameObject = GameObject.Find("Switch5");
        gameObject.transform.Rotate(0,180,0);
        c.DBRead(1,0,3,bites);
        S7.SetBitAt(bites,2,2,false);
        c.DBWrite(1,0,3,bites);
        brojac5 = 1;
        }
    }
    public void switch6()
    {
        if(brojac6  ==  1)
        {
        c.ConnectTo(GameObject.Find("Address").GetComponent<TextMesh>().text,0,1);
        GameObject gameObject = GameObject.Find("Switch6");
        gameObject.transform.Rotate(0,180,0);
        c.DBRead(1,0,3,bites);
        S7.SetBitAt(bites,2,3,true);
        c.DBWrite(1,0,3,bites);
        brojac6 = 2;
        }
        else
        {
           GameObject gameObject = GameObject.Find("Switch6");
        gameObject.transform.Rotate(0,180,0);
        c.DBRead(1,0,3,bites);
        S7.SetBitAt(bites,2,3,false);
        c.DBWrite(1,0,3,bites);
        brojac6 = 1;
        }
    }
    public void switch7()
    {
        if(brojac7  ==  1)
        {
        c.ConnectTo(GameObject.Find("Address").GetComponent<TextMesh>().text,0,1);
        GameObject gameObject = GameObject.Find("Switch7");
        gameObject.transform.Rotate(0,180,0);
        c.DBRead(1,0,3,bites);
        S7.SetBitAt(bites,2,4,true);
        c.DBWrite(1,0,3,bites);
        brojac7 = 2;
        }
        else
        {
        GameObject gameObject = GameObject.Find("Switch7");
        gameObject.transform.Rotate(0,180,0);
        c.DBRead(1,0,3,bites);
        S7.SetBitAt(bites,2,4,false);
        c.DBWrite(1,0,3,bites);
        brojac7 = 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
