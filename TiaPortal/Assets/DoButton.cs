using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoButton : MonoBehaviour
{
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
