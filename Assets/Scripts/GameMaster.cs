using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public BallBehaviour game;
	
	// Update is called once per frame
	void Update ()
    {
		if(game.gameOver || game.youWin)
        {
            if(Input.GetButtonDown("Restart"))
            {
                SceneManager.LoadScene(0);
                game.gameOver = false;
                game.youWin = false;
            }
        }
	}
}
