using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject goodItem;
    public GameObject badItem;
    public float spawnTime;
    private int i;
    public float countdown = 0;

    private void Start()
    {
        i = Random.Range(1, 6);

        StartSpawn();
    }

   

    void StartSpawn()
    {
        if (i > 3)
        {
            InvokeRepeating("goodItem", 50f, spawnTime);
        }
        else
        {
            InvokeRepeating("badItem", 50f, spawnTime);
        }

    }

    private void Update()
    {
        countdown += Time.deltaTime;
        if (countdown >= 5)
        {

            DropGood();
            DropBad();

            countdown = 0;
        }

        
    }

    void DropGood()
    {
        Vector2 positionItem = new Vector2(Random.Range(100,800), Random.Range(640, 640));
        Instantiate(goodItem, goodItem.transform);
        

    }

    void DropBad()
    {

        Vector2 positionItem = new Vector2(Random.Range(100, 800), Random.Range(640, 640));
        Instantiate(badItem, badItem.transform);
        //Instantiate(badItem, new Vector2(transform.position.x, 0), Quaternion.identity);

    }

    
}
