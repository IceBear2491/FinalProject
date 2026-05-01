using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Bullet;
    public float breakDuration = 2.0f;

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnRoutine()
    {
        while (true) // Loop continuously
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(breakDuration); // Wait for X seconds
        }
    }
}
