using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playercontroller : MonoBehaviour
{
    public bool isDead;
    [SerializeField] float velocity = 5f;
    private Rigidbody2D rb;

    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject DeathScreen;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }

    void Update()
    {   //Ekrana dokunuþu sorgular
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            Time.timeScale = 0;
            DeathScreen.SetActive(true);
        }
    }

    //Skoru arttýrýr ve ekrana yazdýrýr
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Pipes(Clone)")
        gameManager.UpdateScore();      
    }
}
