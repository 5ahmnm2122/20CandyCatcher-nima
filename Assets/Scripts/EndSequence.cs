using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndSequence : MonoBehaviour
{

    public ScriptableObject myObject;
    public Text name;
    public Text scoreText;
    public Text scoreValue;


    // Start is called before the first frame update
    void Start()
    {
        name.text = myObject.name;
        scoreText.text = "" + PlayerPrefs.GetInt("score");
        //scoreText.text = "" + ScoreManager.score.ToString();
        // scoreValue.text = myObject.scoreValue.ToString("");

    }

    // Update is called once per frame
    public void Reset()
    {
        myObject.name = "";
        
        SceneManager.LoadScene("StartScene");
    }
}
