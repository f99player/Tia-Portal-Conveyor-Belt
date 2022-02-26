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
    public GameObject address;
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
        if(Input.GetKeyUp(KeyCode.E))
        {
           if(Physics.Raycast(ray,out hit) && hit.collider.gameObject == gameObject)
            {
               unityEvent2.Invoke();
            }
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        Application.Quit();
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
        if(Input.GetKeyDown(KeyCode.Alpha0))
            address.GetComponent<TextMesh>().text = address.GetComponent<TextMesh>().text + "0";
        if(Input.GetKeyDown(KeyCode.Alpha1))
            address.GetComponent<TextMesh>().text = address.GetComponent<TextMesh>().text + "1";
        if(Input.GetKeyDown(KeyCode.Alpha2))
            address.GetComponent<TextMesh>().text = address.GetComponent<TextMesh>().text + "2";
        if(Input.GetKeyDown(KeyCode.Alpha3))
            address.GetComponent<TextMesh>().text = address.GetComponent<TextMesh>().text + "3";
        if(Input.GetKeyDown(KeyCode.Alpha4))
            address.GetComponent<TextMesh>().text = address.GetComponent<TextMesh>().text + "4";
        if(Input.GetKeyDown(KeyCode.Alpha5))
            address.GetComponent<TextMesh>().text = address.GetComponent<TextMesh>().text + "5";
        if(Input.GetKeyDown(KeyCode.Alpha6))
            address.GetComponent<TextMesh>().text = address.GetComponent<TextMesh>().text + "6";
        if(Input.GetKeyDown(KeyCode.Alpha7))
            address.GetComponent<TextMesh>().text = address.GetComponent<TextMesh>().text + "7";
        if(Input.GetKeyDown(KeyCode.Alpha8))
            address.GetComponent<TextMesh>().text = address.GetComponent<TextMesh>().text + "8";
        if(Input.GetKeyDown(KeyCode.Alpha9))
            address.GetComponent<TextMesh>().text = address.GetComponent<TextMesh>().text + "9";
        if(Input.GetKeyDown(KeyCode.Period))
            address.GetComponent<TextMesh>().text = address.GetComponent<TextMesh>().text + ".";
        if(Input.GetKeyDown(KeyCode.Backspace))
            address.GetComponent<TextMesh>().text = address.GetComponent<TextMesh>().text.Remove(address.GetComponent<TextMesh>().text.Length-1);
    }
}
