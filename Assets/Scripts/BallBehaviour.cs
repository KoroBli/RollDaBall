using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public GameMaster game;

    public Collider GOCollider;
    public Collider GWCollider;

    public void OnTriggerEnter(Collider other)
    {
        if (other == GOCollider && !game.youWin)
        {
            game.gameOver = true;
        }
        else if (other == GWCollider && !game.gameOver)
        {
            game.youWin = true;
        }
    }
}
