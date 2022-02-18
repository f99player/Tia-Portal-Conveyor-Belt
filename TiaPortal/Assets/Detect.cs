using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour
{
    public bool on1;
    public bool s1_on = true;
    public bool on2;
    public bool s2_on = true;
    public bool on3;
    public bool s3_on = true;
    public bool on4;
    public bool s4_on = true;
    void Start()
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
        if(collider.gameObject.name == "Ray1" && s1_on == true)
        on1 = true;
        if(collider.gameObject.name == "Ray2" && s2_on == true)
        on2 = true;
        if(collider.gameObject.name == "Ray3" && s3_on == true) 
        on3 = true;
        if(collider.gameObject.name == "Ray4" && s4_on == true)
        {
        on4 = true;
        belt.direction = -belt.direction;
        }
    }
    public void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.name == "Ray1" && s1_on == true)
        on1 = false;
        if(collider.gameObject.name == "Ray2" && s2_on == true) 
        on2 = false;
        if(collider.gameObject.name == "Ray3" && s3_on == true)
        on3 = false;
        if(collider.gameObject.name == "Ray4" && s4_on == true)
        on4 = false;
    }

}
