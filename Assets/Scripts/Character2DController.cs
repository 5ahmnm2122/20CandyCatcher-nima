using UnityEngine;

public class Character2DController : MonoBehaviour
{

    public float speed = 40;

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * speed;
        
    }
}
