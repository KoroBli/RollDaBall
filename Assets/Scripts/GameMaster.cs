using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public BoardBehaviour board;
    public UIBehaviour ui;

    public bool pause;
    public bool gameOver;
    public bool youWin;

    // Update is called once per frame
    void Start()
    {
        gameOver = false;
        youWin = false;
        pause = false;

        board.CustomStart();
        ui.CustomStart();
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Pause) && (!gameOver && !youWin)) pause = !pause;

        if (pause) Pause();
        else Resume();

        if (!gameOver && !youWin)
        {
            board.CustomUpdate();
            ui.CustomUpdate();
        }
        else
        {
            if (Input.GetButtonDown("Restart"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                gameOver = false;
                youWin = false;
            }
        }
	}

    public void Resume()
    {
        Time.timeScale = 1f;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
    }
}
