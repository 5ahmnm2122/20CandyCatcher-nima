using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public GameObject badDrop;
    public GameObject goodDrop;
    public Text scoreText;
    public static int score;


    public List<GameObject> hearts = new List<GameObject>();

    public ScriptableObject myObject;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if (otherObject.gameObject.tag == "good")
        {
            Debug.Log("Item caught");
            score += 1;
            scoreText.text = "" + score.ToString();



        }


        if (otherObject.gameObject.tag == "good2")
        {
            Debug.Log("Item caught");
            score += 3;
            scoreText.text = "" + score.ToString();



        }

        if (otherObject.gameObject.tag == "bad")
        {
            Debug.Log("lose heart");
            Destroy(otherObject);
            hearts.Remove(otherObject.gameObject);
        }



    }

    public void Scoring()
    {
        /* float value = score;
         scoreValue.text = value.ToString();
         myObject.scoreValue = value;
     */

    }
}
