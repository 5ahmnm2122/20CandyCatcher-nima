using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

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

    public AudioSource backgroundMusic;
    public AudioSource collectGoodItem;
    public AudioSource collectBadItem;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("score", score);
       
        backgroundMusic.Play(); 
        
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

            
            collectGoodItem.Play(3);
        }


        if (otherObject.gameObject.tag == "good2")
        {
            Debug.Log("Item caught");
            score += 3;
            scoreText.text = "" + score.ToString();
            PlayerPrefs.SetInt("score", score);

            
            collectGoodItem.Play(3);

        }

        if (otherObject.gameObject.tag == "bad")
        {
            
                Debug.Log("lose heart");
                LoseHeart();

           
            collectBadItem.Play(5);

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
