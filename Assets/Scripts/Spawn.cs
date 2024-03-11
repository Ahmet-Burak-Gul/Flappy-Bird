using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject pipePrefab;
    float spawnInterval;

    [SerializeField] private Playercontroller bird;
    
    void Start()
    {
        StartCoroutine(SpawnPipes());
    }
    IEnumerator SpawnPipes()

    {   //Sürekli gelen borularý oluþturur.
        while (!bird.isDead)
        {
            CreatePipe();

            spawnInterval = Random.Range(1f, 2f);
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    private void CreatePipe()
    {
        Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y + Random.Range(-2.5f, 2.5f), transform.position.z);
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }
}

