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
    public void Back()
    {
       GameObject gameObject = GameObject.Find("Connect");
       gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,gameObject.transform.position.z-0.075f);
    }
    public void Connect()
    {
        GameObject gameObject = GameObject.Find("Connect");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,gameObject.transform.position.z+0.075f);
        belt.c.ConnectTo(GameObject.Find("Address").GetComponent<TextMesh>().text,0,1);
        int result = c.ConnectTo(GameObject.Find("Address").GetComponent<TextMesh>().text, 0, 1);
        if(result == 0)
        {
            GameObject.Find("H5").GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            GameObject.Find("H5").GetComponent<Renderer>().material.color = Color.red;
        }
        Invoke("Back",0.5f);
    }
    // Update is called once per frame
    void Update()
    {
    }
}
