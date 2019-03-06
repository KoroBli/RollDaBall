using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardBehaviour : MonoBehaviour
{
    public GameMaster game;
    
    float rotationX = 0f;
    float rotationY = 0f;
    float speed = 20f;
    
	// Use this for initialization
	public void CustomStart ()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
	
	// Update is called once per frame
	public void CustomUpdate ()
    {
        if (!game.gameOver && !game.youWin)
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
}
