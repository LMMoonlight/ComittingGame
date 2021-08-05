using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] int time;
    void Start()
    {
        StartCoroutine(SpawnBall());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnBall()
    {
        float spawnPointZ = Random.Range(-3.5f, 3.5f);
        Vector3 spawnPosition = new Vector3(18.74f, 14, spawnPointZ);
        yield return new WaitForSeconds(time);
        Instantiate(ball, spawnPosition, Quaternion.identity);
        StartCoroutine(SpawnBall());
    }
}
