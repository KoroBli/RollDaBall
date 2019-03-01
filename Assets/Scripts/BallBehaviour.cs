using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public bool gameOver;
    public bool youWin;

    public Collider GOCollider;
    public Collider GWCollider;
	
	// Update is called once per frame
	void Start ()
    {
        gameOver = false;
        youWin = false;
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other == GOCollider && !youWin)
        {
            gameOver = true;
        }
        else if (other == GWCollider && !gameOver)
        {
            youWin = true;
        }
    }
}
