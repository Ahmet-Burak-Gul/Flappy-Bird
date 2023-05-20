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

    {   //Sürekli gelen borularý oluþturur.
        while (true)
        {   
            //bir sorneki borunun konumunu belirlenen miktarda rastgele deðiþtirir.
            Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y + Random.Range(-2.5f,2.5f), transform.position.z);
            Instantiate(pipePrefab, spawnPos, Quaternion.identity);

            //bir sornaki borunun oluþmasý için belirlenen aralýkta rastgele bir süre beklenir.
            spawnInterval = Random.Range(1f, 2f);
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}

