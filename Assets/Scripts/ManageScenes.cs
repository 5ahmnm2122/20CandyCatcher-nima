using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManageScenes : MonoBehaviour
{
    public void LoadStart()
    {
        SceneManager.LoadScene("IntroScene");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void LoadWin()
    {
        SceneManager.LoadScene("WinningScene");
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
