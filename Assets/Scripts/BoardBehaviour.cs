using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardBehaviour : MonoBehaviour {

    float rotationX = 0f;
    float rotationY = 0f;
    float speed = 10f;
    
	// Use this for initialization
	void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
	
	// Update is called once per frame
	void Update ()
    {
        rotationX = Input.GetAxis("Mouse X") * Time.deltaTime * speed;
        rotationY = Input.GetAxis("Mouse Y") * Time.deltaTime * speed;

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x - rotationY, 0, transform.localEulerAngles.z + rotationX);

        if (transform.localEulerAngles.x >= 30 && transform.localEulerAngles.x <= 35) transform.localEulerAngles = new Vector3(30, 0, transform.localEulerAngles.z + rotationX);
        else if (transform.localEulerAngles.x <= 330 && transform.localEulerAngles.x >= 325) transform.localEulerAngles = new Vector3(-30, 0, transform.localEulerAngles.z + rotationX);

        if (transform.localEulerAngles.z >= 30 && transform.localEulerAngles.z <= 35) transform.localEulerAngles = new Vector3(transform.localEulerAngles.x + rotationY, 0, 30);
        else if (transform.localEulerAngles.z <= 330 && transform.localEulerAngles.z >= 325) transform.localEulerAngles = new Vector3(transform.localEulerAngles.x + rotationY, 0, -30);
    }
}
