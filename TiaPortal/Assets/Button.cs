using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Button : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();
    public UnityEvent unityEvent2 = new UnityEvent();
    public GameObject button;
    public DoButton do_stuff;
    // Start is called before the first frame update
    void Start()
    {
        button = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        int x = Screen.width / 2;
        int y = Screen.height / 2;
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(x,y));
        RaycastHit hit;
        if(Input.GetKeyDown(KeyCode.E))
        {
         if(Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
              unityEvent.Invoke();
            }
        }
        if(Input.GetKeyDown(KeyCode.H))
            do_stuff.button1();
        if(Input.GetKeyUp(KeyCode.H))
            do_stuff.return_normal1();
            if(Input.GetKeyDown(KeyCode.J))
            do_stuff.button2();
        if(Input.GetKeyUp(KeyCode.J))
            do_stuff.return_normal2();
            if(Input.GetKeyDown(KeyCode.K))
            do_stuff.button3();
        if(Input.GetKeyUp(KeyCode.K))
            do_stuff.return_normal3();
            if(Input.GetKeyDown(KeyCode.L))
            do_stuff.button4();
        if(Input.GetKeyUp(KeyCode.L))
            do_stuff.return_normal4();
        if(Input.GetKeyUp(KeyCode.E))
        {
           if(Physics.Raycast(ray,out hit) && hit.collider.gameObject == gameObject)
            {
               unityEvent2.Invoke();
            }
        }
    }
}
