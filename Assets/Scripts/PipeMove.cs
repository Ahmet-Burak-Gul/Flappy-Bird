using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] float velocity = 2f;
    void Start()
    {
        //Borular� olu�tuktan 5 saniye sonra yok eder.
        Destroy(gameObject, 5);
    }

    void Update()
    {   //Borular�n hareketini sa�lar.
        transform.position += Vector3.left * velocity * Time.deltaTime;
    }
}
