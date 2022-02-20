using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sharp7;
public class Detect : MonoBehaviour
{
    public bool on1; //detects if hit
    public bool s1_on = true;//just controls if the sensor is on of off
    public bool on2;
    public bool s2_on = true;
    public bool on3;
    public bool s3_on = true;
    public bool on4;
    public bool s4_on = true;
    public Sharp7.S7Client c = new Sharp7.S7Client();
    public byte[] bites = new byte[2];
    void Start()
    {
        
    }
    public void ConnectTia()
    {
      
    }
    public ConveyorBelt belt;

    // Update is called once per frame
    void Update()
    {
        if(on1 == true && s1_on == true)
        {
            GameObject.Find("H1").GetComponent<Renderer>().material.color = Color.yellow;
        }
        else
        {
            GameObject.Find("H1").GetComponent<Renderer>().material.color = Color.gray;
        }
        if(on2 == true && s2_on == true)
        {
            GameObject.Find("H2").GetComponent<Renderer>().material.color = Color.yellow;
        }
        else
        {
            GameObject.Find("H2").GetComponent<Renderer>().material.color = Color.gray;
        }
        if(on3 == true && s3_on == true)
        {
            GameObject.Find("H3").GetComponent<Renderer>().material.color = Color.yellow;
        }
        else
        {
            GameObject.Find("H3").GetComponent<Renderer>().material.color = Color.gray;
        }
        if(on4 == true && s4_on == true)
        {
            GameObject.Find("H4").GetComponent<Renderer>().material.color = Color.yellow;
        }
        else
        {
            GameObject.Find("H4").GetComponent<Renderer>().material.color = Color.gray;
        }
    }
    public void OnTriggerEnter(Collider collider)
    {
        string address = GameObject.Find("Address").GetComponent<TextMesh>().text;
        int result = c.ConnectTo(address, 0, 1);
        if (collider.gameObject.name == "Ray1" && s1_on == true)
        {
            on1 = true;
            int p = c.DBRead(1, 0, 1, bites);
            S7.SetBitAt(ref bites, 0, 0, true);
            int k = c.DBWrite(1, 0, 2, bites);
        }
        if (collider.gameObject.name == "Ray2" && s2_on == true)
        {
            on2 = true;
            int p = c.DBRead(1, 0, 1, bites);
            S7.SetBitAt(ref bites, 0, 1, true);
            int k = c.DBWrite(1, 0, 2, bites);
        }
        if (collider.gameObject.name == "Ray3" && s3_on == true)
        {
            on3 = true;
            int p = c.DBRead(1, 0, 1, bites);
            S7.SetBitAt(ref bites, 0, 2, true);
            int k = c.DBWrite(1, 0, 2, bites);
        }
        if(collider.gameObject.name == "Ray4" && s4_on == true)
        {
           int p = c.DBRead(1, 0, 1, bites);
            S7.SetBitAt(ref bites, 0, 3, true);
            int k = c.DBWrite(1, 0, 2, bites);
            on4 = true;
        }
    }
    public int p;
    public void OnTriggerExit(Collider collider)
    {
        string address = GameObject.Find("Address").GetComponent<TextMesh>().text;
        int result = c.ConnectTo(address, 0, 1);
        if (collider.gameObject.name == "Ray1" && s1_on == true)
        {
            on1 = false;
            int p = c.DBRead(1, 0, 1, bites);
            S7.SetBitAt(ref bites, 0, 0, false);
            int k = c.DBWrite(1, 0, 2, bites);
         }
        if (collider.gameObject.name == "Ray2" && s2_on == true)
        {
            on2 = false;
            int p = c.DBRead(1, 0, 1, bites);
            S7.SetBitAt(ref bites, 0, 1, false);
            int k = c.DBWrite(1, 0, 2, bites);
        }
        if (collider.gameObject.name == "Ray3" && s3_on == true)
        {
            on3 = false;
            int p = c.DBRead(1, 0, 1, bites);
            S7.SetBitAt(ref bites, 0, 2, false);
            int k = c.DBWrite(1, 0, 2, bites);
        }
        if (collider.gameObject.name == "Ray4" && s4_on == true)
        {
            int p1 = c.DBRead(1, 0, 1, bites);
            S7.SetBitAt(ref bites, 0, 3, true);
            int k2 = c.DBWrite(1, 0, 2, bites);
            on4 = false;
            int p = c.DBRead(1, 0, 1, bites);
            S7.SetBitAt(ref bites, 0, 3, false);
            int k = c.DBWrite(1, 0, 2, bites);
        }
    }

}
