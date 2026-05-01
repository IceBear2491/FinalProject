using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float speed = 10.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 5.47)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
        if (transform.position.y < 5.47)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
    }
}
