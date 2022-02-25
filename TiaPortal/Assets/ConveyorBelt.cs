using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sharp7;
public class ConveyorBelt : MonoBehaviour
{
    [SerializeField] public float speed = 50f;
    public Sharp7.S7Client c = new S7Client();
    public byte[] bites = new byte[2];
    public Vector3 direction = new Vector3(0.075f,0,0);
    public List<GameObject> Items_on_belt;

    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        c.DBRead(1,0,2,bites);
        bool H1_on  = Sharp7.S7.GetBitAt(bites,0,4);
        bool H2_on = Sharp7.S7.GetBitAt(bites,0,5);
        bool H3_on = Sharp7.S7.GetBitAt(bites,0,6);
        bool H4_on = Sharp7.S7.GetBitAt(bites,0,7);
        if(H1_on == true)
            GameObject.Find("H1").GetComponent<Renderer>().material.color = Color.green;
        else
             GameObject.Find("H1").GetComponent<Renderer>().material.color = Color.gray;
        if(H2_on == true)
             GameObject.Find("H2").GetComponent<Renderer>().material.color = Color.green;
        else
             GameObject.Find("H2").GetComponent<Renderer>().material.color = Color.gray;
        if(H3_on == true)
             GameObject.Find("H3").GetComponent<Renderer>().material.color = Color.green;
        else
             GameObject.Find("H3").GetComponent<Renderer>().material.color = Color.gray;
        if(H4_on == true)
             GameObject.Find("H4").GetComponent<Renderer>().material.color = Color.green;
        else
             GameObject.Find("H4").GetComponent<Renderer>().material.color = Color.gray;
        bool left = Sharp7.S7.GetBitAt(bites,1,4);
        bool right = Sharp7.S7.GetBitAt(bites,1,5);
        if(left == true && right == true)
        direction = new Vector3(0,0,0);
        else if(left == true && right == false)
        direction = new Vector3(-0.075f,0,0);
        else if(left == false && right == true)
        direction = new Vector3(0.075f,0,0);
        else
        direction = new Vector3(0,0,0);
        for(int i = 0;i <= Items_on_belt.Count - 1;i++)
        {

            Items_on_belt[i].GetComponent<Rigidbody>().velocity = speed * direction* Time.deltaTime;
        }

    }
    public void OnCollisionEnter(Collision collision)
    {
        Items_on_belt.Add(collision.gameObject);
    }
    public void OnCollisionExit(Collision collision)
    {
        Items_on_belt.Remove(collision.gameObject);
    }
}
