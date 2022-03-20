using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public Camera cam;
    public float defaultFOV = 60f;
    public float mouse_sensitivity = 500f;
    public Transform User_body;
    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        float mouse_X = Input.GetAxis("Mouse X") * mouse_sensitivity * Time.deltaTime;
        float mouse_Y = Input.GetAxis("Mouse Y") * mouse_sensitivity * Time.deltaTime;
        xRotation -= mouse_Y;
        xRotation = Mathf.Clamp(xRotation, -90f,90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        User_body.Rotate(Vector3.up*mouse_X);
        if(Input.GetMouseButton(1))
        cam.fieldOfView = (defaultFOV/2);
        else
        cam.fieldOfView = defaultFOV;
    }
}
