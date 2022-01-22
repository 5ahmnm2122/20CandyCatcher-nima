using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject goodItemPrefab;
    public GameObject goodItem2Prefab;
    public GameObject badItemPrefab;
    public float spawnTime;
    private int i;
    public float countdown = 0;

    private void Start()
    {
        i = 1;

        StartSpawn();

        
    }

   

    void StartSpawn()
    {
        if (i >= 1)
        {
            InvokeRepeating("DropGood", 1f, spawnTime);
        }
        else
        {
            InvokeRepeating("DropBad", 1f, spawnTime);
        }

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
        float y = Random.Range(2500, 2500);
        Vector2 spawnPosition = new Vector2(x, y);

        GameObject badItem = Instantiate(badItemPrefab, spawnPosition, Quaternion.identity, GameObject.FindGameObjectWithTag("bad").transform);

        GameObject goodItem = Instantiate(goodItemPrefab, spawnPosition, Quaternion.identity, GameObject.FindGameObjectWithTag("good").transform);

        GameObject goodItem2 = Instantiate(goodItem2Prefab, spawnPosition, Quaternion.identity, GameObject.FindGameObjectWithTag("good2").transform);

    }

    
}
