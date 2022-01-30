using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    public float fallSpeed = 150;
    

    void Update()
    {

        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        

    }

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("hit platform");
            Destroy(gameObject);
        }
        
    }
}
