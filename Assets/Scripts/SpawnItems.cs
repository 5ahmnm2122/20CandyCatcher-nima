using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject goodItemPrefab;
    public GameObject badItemPrefab;
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
            InvokeRepeating("DropGood", 50f, spawnTime);
        }
        else
        {
            InvokeRepeating("DropBad", 50f, spawnTime);
        }

        Debug.Log("Start");
    }

    void Update()
    {
        countdown += Time.deltaTime;
        if (countdown >= 5)
        {


            //DropGood();
            //DropBad();
            SpawnArea();
            countdown = 0;

            Debug.Log("Spawn");
        }

        
    }

    void SpawnArea()
    {
        float x = Random.Range(200, 800);
        float y = Random.Range(2500, 2500);
        Vector2 spawnPosition = new Vector2(x, y);

        GameObject badItem = Instantiate(badItemPrefab, spawnPosition, Quaternion.identity, GameObject.FindGameObjectWithTag("bad").transform);
        
        GameObject goodItem = Instantiate(goodItemPrefab, spawnPosition, Quaternion.identity, GameObject.FindGameObjectWithTag("good").transform);
    }

    void DropGood()
    {

        // Vector2 positionItem = new Vector2(Random.Range(800,800), Random.Range(640, 640));
        // Instantiate(goodItem, goodItem.transform);
       // Instantiate(goodItem, spawnPosition, Quaternion.identity);


    }

    void DropBad()
    {

       // Vector2 positionItem = new Vector2(Random.Range(800, 800), Random.Range(640, 640));
       // Instantiate(badItem, badItem.transform);
    

    }

    
}
