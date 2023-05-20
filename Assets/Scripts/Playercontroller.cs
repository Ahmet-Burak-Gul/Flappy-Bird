using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Playercontroller : MonoBehaviour
{
    [SerializeField] float velocity = 10f;
    int score = 0;
    [SerializeField] GameObject scoreText;
    Rigidbody2D rb;
    Touch touch;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {   //Ekrana dokunuþu sorgular
        if (Input.touchCount > 0)
        {   
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {   
                //zýplamayý saðlar
                rb.velocity = Vector2.up * velocity;

            }
        }
    }

    //kuþun herhangi bir yere temasýnda oyunu yeniden baþlatýr
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }

    //Skoru arttýrýr ve ekrana yazdýrýr
    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        scoreText.GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}
