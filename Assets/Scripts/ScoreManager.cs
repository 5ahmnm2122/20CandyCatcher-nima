using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public GameObject badDrop;
    public GameObject goodDrop;
    public Text scoreText;
    public float scoreValue;

    
    public List<GameObject> hearts = new List<GameObject>();
   
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D otherObject)
    {
       if(otherObject.gameObject.tag == "good")
        {
            Debug.Log("Item caught");
            scoreValue += 1;
            scoreText.text = "" + scoreValue.ToString();

            
        }

        if(otherObject.gameObject.tag == "bad")
        {
            Debug.Log("lose heart");
            Destroy(otherObject);
            hearts.Remove(otherObject.gameObject);
        }
        

        
    }

   
}
