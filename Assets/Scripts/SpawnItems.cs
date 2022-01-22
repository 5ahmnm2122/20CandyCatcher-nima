using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject goodItemPrefab;
    public GameObject goodItem2Prefab;
    public GameObject badItemPrefab;
    
    public float countdown = 0;

    private void Start()
    {
        

        StartSpawn();

        
    }

   
   
    void StartSpawn()
    {


        InvokeRepeating("DropGood", 1, 3);

        InvokeRepeating("DropGood2", 1, 3);

        InvokeRepeating("DropBad", 1, 3);
        

        Debug.Log("Start");
    }

    void Update()
    {
        countdown += Time.deltaTime;
        if (countdown >= 5)
        {

            SpawnArea();
            countdown = 0;

            Debug.Log("Spawn");
        }

        
    }

    void SpawnArea()
    {
        float x = Random.Range(200, 800);
        float y = Random.Range(2400, 2400);

        Vector2 spawnPosition = new Vector2(x, y);

        GameObject badItem = Instantiate(badItemPrefab, spawnPosition, Quaternion.identity, GameObject.FindGameObjectWithTag("bad").transform);

        GameObject goodItem = Instantiate(goodItemPrefab, spawnPosition, Quaternion.identity, GameObject.FindGameObjectWithTag("good").transform);

        GameObject goodItem2 = Instantiate(goodItem2Prefab, spawnPosition, Quaternion.identity, GameObject.FindGameObjectWithTag("good2").transform);

    }

    
}
