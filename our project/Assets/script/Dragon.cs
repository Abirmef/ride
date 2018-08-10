using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Dragon : MonoBehaviour
{
     public Text scoreText;
    int score = 0;
    bool isDead;
    Rigidbody2D rb2d;

    public float speed = 5f;

    [SerializeField]
    private float flapForce = 20f;
    public void playLoad()
    {
        SceneManager.LoadScene(3);
    }


    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();

        rb2d.velocity = Vector2.right * speed * Time.deltaTime;
    }

    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            rb2d.velocity = Vector2.right * speed * Time.deltaTime;


            rb2d.AddForce(Vector2.up * flapForce);
            
        }
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "coin")
        {
            Destroy(col.gameObject);
            score += 100;
            scoreText.text = score.ToString();
        }
        if (col.gameObject.tag == "obstacle")
        { 
            
            SceneManager.LoadScene(1);
        }

    }
        
      
    
}