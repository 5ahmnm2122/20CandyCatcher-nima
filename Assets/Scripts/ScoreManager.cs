using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    public GameObject badDrop;
    public GameObject goodDrop;
    public GameObject goodDrop2;
    public Text scoreText;
    public static int score;


    public GameObject[] hearts;
    public int health = 3;

    public ScriptableObject myObject;


    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("score", score);
        
    }



    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.gameObject.tag == "good")
        {
            Debug.Log("Item caught");
            score += 1;
            scoreText.text = "" + score.ToString();
            PlayerPrefs.SetInt("score", score);
            // Destroy(this.gameObject);


        }


        if (otherObject.gameObject.tag == "good2")
        {
            Debug.Log("Item caught");
            score += 3;
            scoreText.text = "" + score.ToString();
            PlayerPrefs.SetInt("score", score);



        }

        if (otherObject.gameObject.tag == "bad")
        {
            
                Debug.Log("lose heart");
                LoseHeart();
        
           
        }


    }

    public void LoseHeart()
    {
        hearts[health - 1].SetActive(false);
        health -= 1;

        if (health == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
