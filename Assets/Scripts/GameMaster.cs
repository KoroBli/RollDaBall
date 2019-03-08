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
        if (Input.GetButtonDown("Jump") && (!gameOver && !youWin)) pause = !pause;

        if (pause)
        {
            Pause();
        }
        else
        {
            Resume();
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if(SceneManager.GetActiveScene().buildIndex >= SceneManager.sceneCountInBuildSettings - 1)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                SceneManager.LoadScene(0);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

        ui.CustomUpdate();

        if (!gameOver && !youWin)
        {
            board.CustomUpdate();
        }

        if (SceneManager.GetActiveScene().buildIndex != 0 && Input.GetButtonDown("Restart"))
        {
            ResetScene();
        }
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        ui.pause.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        pause = false;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        ui.pause.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void QuitToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ResetScene()
    {
        gameOver = false;
        youWin = false;
        pause = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
