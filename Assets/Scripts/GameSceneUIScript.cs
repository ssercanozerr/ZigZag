using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneUIScript : MonoBehaviour
{
    bool GameIsPause = false;
    public void MainMenuButton()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void PauseButton()
    {
        if (GameIsPause == false)
        {
            Time.timeScale = 0f;
            GameIsPause = true;
        }
        else
        {
            Time.timeScale = 1f;
            GameIsPause = false;
        }
    }
}
