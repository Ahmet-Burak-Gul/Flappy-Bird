using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject pipePrefab;
    float spawnInterval = 7;
    
    void Start()
    {
        StartCoroutine(SpawnPipes());
    }

    void Update()
    {
        
    }

    IEnumerator SpawnPipes()

    {   //S�rekli gelen borular� olu�turur.
        while (true)
        {   
            //bir sorneki borunun konumunu belirlenen miktarda rastgele de�i�tirir.
            Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y + Random.Range(-2.5f,2.5f), transform.position.z);
            Instantiate(pipePrefab, spawnPos, Quaternion.identity);

            //bir sornaki borunun olu�mas� i�in belirlenen aral�kta rastgele bir s�re beklenir.
            spawnInterval = Random.Range(1f, 2f);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}

