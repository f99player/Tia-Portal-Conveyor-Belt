using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    [SerializeField] public float speed = 50f;
    public Vector3 direction = new Vector3(5,0,0);
    public List<GameObject> Items_on_belt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
