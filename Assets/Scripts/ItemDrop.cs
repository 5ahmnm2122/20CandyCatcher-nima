using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    public float fallSpeed = 300;
    

    void Update()
    {

        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        

    }

  
}
