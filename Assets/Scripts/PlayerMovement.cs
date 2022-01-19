using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode leftKey;
    public KeyCode rightKey;
    public Vector2 direction;
    public Rigidbody2D player;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(leftKey))
        {

            player.AddForce((direction*-1)*speed);
            Debug.Log("go left");
        }

        if (Input.GetKeyDown(rightKey))
        {
            player.AddForce(direction*speed);
            Debug.Log("go right");
        }
    }
}
