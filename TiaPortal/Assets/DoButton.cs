using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DoButton : MonoBehaviour
{
    public Sharp7.S7Client c = new Sharp7.S7Client();
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public ConveyorBelt belt;
    public Detect disable;
    public int s1 = 1;
    public int s2 = 1;
    public int s3 = 1;
    public int s4 = 1;
    public void return_normal1()
    {
        GameObject gameObject = GameObject.Find("B1");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.89f,gameObject.transform.position.z);
    }
    public void button1()
    {
        GameObject gameObject = GameObject.Find("B1");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.88f,gameObject.transform.position.z);
        if(s1 == 1)
        {
        s1 = 2;
        disable.s1_on = false;
        }
        else 
        {
            disable.s1_on = true;
            s1 = 1;
        }
        Invoke("return_normal1",0.5f);
    }
    public void return_normal2()
    {
        GameObject gameObject = GameObject.Find("B2");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.89f,gameObject.transform.position.z);
    }
    public void button2()
    {
        GameObject gameObject = GameObject.Find("B2");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.88f,gameObject.transform.position.z);
        if(s2 == 1)
        {
        s2 = 2;
        disable.s2_on = false;
        }
        else
        {
            disable.s2_on = true;
            s2 = 1;
        }
        Invoke("return_normal2",0.5f);
    }
    public void return_normal3()
    {
        GameObject gameObject = GameObject.Find("B3");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.89f,gameObject.transform.position.z);
    }
    public void button3()
    {
        GameObject gameObject = GameObject.Find("B3");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.88f,gameObject.transform.position.z);
        if(s3 == 1)
        {
        s3 = 2;
        disable.s3_on = false;
        }
        else 
        {
            disable.s3_on = true;
            s3 = 1;
        }
        Invoke("return_normal3",0.5f);
    }
    public void return_normal4()
    {
        GameObject gameObject = GameObject.Find("B4");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.89f,gameObject.transform.position.z);
    }
    public void button4()
    {
        GameObject gameObject = GameObject.Find("B4");
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,2.88f,gameObject.transform.position.z);
        if(s4 == 1)
        {
        s4 = 2;
        disable.s4_on = false;
        }
        else
        {
            disable.s4_on = true;
            s4 = 1;
        }
        Invoke("return_normal4",0.5f);
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
        s1 = 2;
        disable.s1_on = false;
        s2 = 2;
        disable.s2_on = false;
        s3 = 2;
        disable.s3_on = false;
        s4 = 2;
        disable.s4_on = false;
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
