using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBehaviour : MonoBehaviour {

    public Transform arrow;
    public GameMaster game;
    public GameObject win;
    public GameObject lose;
    public GameObject pause;

    public Text countdownText;
    public Text restart;
    public Text advance;

    private int direction = 1;
    private int speed = 5;

    private float timeCounter = 0f;

    public void CustomStart()
    {
        restart.gameObject.SetActive(false);
        advance.gameObject.SetActive(false);
        win.gameObject.SetActive(false);
        lose.gameObject.SetActive(false);
        pause.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void CustomUpdate ()
    {
        timeCounter += Time.deltaTime;

        countdownText.text = Mathf.Round(timeCounter).ToString();
        arrow.Translate(0, speed * Time.deltaTime * direction, 0);

        if (arrow.position.z <= -60) direction *= -1;
        else if (arrow.position.z >= -55) direction *= -1;

        if(game.gameOver)
        {
            lose.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
        }
        else if(game.youWin)
        {
            win.gameObject.SetActive(true);
            restart.gameObject.SetActive(true);
            advance.gameObject.SetActive(true);
        }
    }
}
