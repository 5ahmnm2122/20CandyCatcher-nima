using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    public GameObject goodItemPrefab;
    public GameObject goodItem2Prefab;
    public GameObject badItemPrefab;

    public GameObject[] drops;

    public float spawnTime;
    
    public float countdown = 0;

    public int i;

    

    private void Start()
    {
        i = Random.Range(1, 5);

        StartSpawn();

        
    }

   
   
    void StartSpawn()
    {
        if (i > 2)
        {
            InvokeRepeating("DropGood", 50f, spawnTime);

            InvokeRepeating("DropGood2", 50f, spawnTime);

            InvokeRepeating("DropBad", 50f, spawnTime);



        } 

        Debug.Log("Start");
    }

    void Update()
    {
        countdown += Time.deltaTime;

        if (countdown >= 2)
        {

            SpawnArea();
            SpawnRandomItem();
            countdown = 0;

            Debug.Log("Spawn");
        }
        
    }

    Vector2 SpawnArea()
    {
        float x = Random.Range(200, 800);
        float y = Random.Range(2400, 2400);

       return new Vector2 (x, y);

    }


    void SpawnRandomItem()
    {
        GameObject randomItem = Instantiate(drops[UnityEngine.Random.Range(0,3)], SpawnArea(), Quaternion.identity, GameObject.FindGameObjectWithTag("good").transform);

    }
}
