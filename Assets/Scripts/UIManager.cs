using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public float targetTime = 60.0f;
    public Text timerText;

    public Text name;
    
    public ScriptableObject myObject;


    private void Start()
    {
        name.text = myObject.name;
       
    }

    private void Update()
    {
        targetTime -= Time.deltaTime;
        DisplayTime(targetTime);

        if (targetTime <= 0.0f)
        {
            
            LoadWin();
        }

        
    }

   

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timerText.text = string.Format("{0:00}" + " s ", seconds);
    }

   
    
    public void LoadWin()
    {
        SceneManager.LoadScene("WinningScene");
    }
   



}
