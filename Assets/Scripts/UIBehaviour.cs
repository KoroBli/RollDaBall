using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBehaviour : MonoBehaviour {

    public Transform arrow;
    public GameMaster game;

    public Text countdownText;
    public Text restart;
    public Text gameOverText;
    public Text congratsText;
    public Image gameOverImage;
    public Image winImage;

    private int direction = 1;
    private int speed = 5;

    private float timeCounter = 0f;

    public void CustomStart()
    {
        restart.gameObject.SetActive(false);
        gameOverText.gameObject.SetActive(false);
        congratsText.gameObject.SetActive(false);
        gameOverImage.gameObject.SetActive(false);
        winImage.gameObject.SetActive(false);
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
            restart.gameObject.SetActive(true);
            gameOverText.gameObject.SetActive(true);
            gameOverImage.gameObject.SetActive(true);
        }

        if(game.youWin)
        {
            restart.gameObject.SetActive(true);
            congratsText.gameObject.SetActive(true);
            winImage.gameObject.SetActive(true);
        }
    }
}
