using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    GameObject mainCamera;
    bool carrying;
    GameObject carriedObject;
    public float distance = 3;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        if(carrying)
        {
            carry(carriedObject);
            checkDrop();
        }
            else
            pickup();
    }
    public void carry(GameObject o)
    {
        o.transform.position = mainCamera.transform.position + mainCamera.transform.forward * distance;
    }
    public void pickup()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            int x = Screen.width/2;
            int y = Screen.height / 2;
            Ray ray = mainCamera.GetComponent<Camera>().ScreenPointToRay(new Vector3(x,y));
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                Pickup p = hit.collider.GetComponent<Pickup>();
                if(p != null)
                {
                    carrying = true;
                    carriedObject = p.gameObject;
                    p.gameObject.GetComponent<Rigidbody>().isKinematic = true;
                }
            }
        }
    }
    public void dropObject()
    {
        carrying = false;
        carriedObject.gameObject.GetComponent<Rigidbody>().isKinematic = false;;
        carriedObject = null;

    }
    public void checkDrop()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            dropObject();
        }
    }
}
