using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ManageScenes : MonoBehaviour
{
    public AudioSource gameOver;
    public AudioSource win;

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
        gameOver.Play();

    }
    public void LoadWin()
    {
        SceneManager.LoadScene("WinningScene");
        win.Play();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
