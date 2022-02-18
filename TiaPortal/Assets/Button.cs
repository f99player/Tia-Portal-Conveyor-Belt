using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Button : MonoBehaviour
{
    public UnityEvent unityEvent = new UnityEvent();
    public GameObject button;
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
    }
}
