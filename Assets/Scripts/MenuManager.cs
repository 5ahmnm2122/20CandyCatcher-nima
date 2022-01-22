using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public InputField nameInput;
    public Button nextSceneBtn;
    public Color red;

    public ScriptableObject myObject;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    

    public void LoadScene()
    {
        if(nameInput.GetComponent<InputField>().text == "")
        {
            nameInput.GetComponent<Image>().color = Color.red;
        }
        else
        {
            myObject.name = nameInput.GetComponent<InputField>().text;
            SceneManager.LoadScene("MainScene");
        }
    }
}
