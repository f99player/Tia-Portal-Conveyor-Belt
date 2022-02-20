using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sharp7;
public class ConveyorBelt : MonoBehaviour
{
    [SerializeField] public float speed = 50f;
    public Sharp7.S7Client c = new S7Client();
    public byte[] bites = new byte[2];
    public Vector3 direction = new Vector3(0.15f,0,0);
    public List<GameObject> Items_on_belt;

    // Start is called before the first frame update
    void Start()
    {
    }
    bool on = false;
    // Update is called once per frame
    void Update()
    {
        c.DBRead(1,0,1,bites);
        bool power = Sharp7.S7.GetBitAt(bites,0,4);
        bool direct = Sharp7.S7.GetBitAt(bites,0,5);
        if(direct == true)
        direction = new Vector3(-0.15f,0,0);
        else
        direction = new Vector3(0.15f,0,0);
        if(power == true)
          on = true;   
        else
            on = false;
        if(on == true)
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
