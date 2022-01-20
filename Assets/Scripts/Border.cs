using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    Vector2 screenBorder;
    float objectWidth;
    float objectHeight;

    // Start is called before the first frame update
    void Start()
    {
        screenBorder = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBorder.x + objectWidth, screenBorder.x * -1 - objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBorder.y + objectHeight, screenBorder.y * -1 - objectHeight);
        transform.position = viewPos;
    }
}
