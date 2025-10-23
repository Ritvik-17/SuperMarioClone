using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{  
    public GameObject YouDiedScreen;
    public GameObject Mario;

    private Rigidbody2D EnemyRigidbody;
    private int Direction = -1; 

    void Start()
    {
        EnemyRigidbody = GetComponent<Rigidbody2D>();
        EnemyRigidbody.velocity = new Vector2(Direction * 3f, EnemyRigidbody.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(!collision.gameObject.CompareTag("Ground")){
            Direction = Direction*-1;
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x)*Direction, transform.localScale.y, transform.localScale.z);               
            EnemyRigidbody.velocity = new Vector2(Direction * 3f, EnemyRigidbody.velocity.y);
        }
        if (collision.gameObject.CompareTag("Player"))
        {   
            YouDiedScreen.SetActive(true);
            FindObjectOfType<AudioManager>().Stop("Theme");            
            FindObjectOfType<AudioManager>().Play("GameOver");
            Time.timeScale = 0f;
            RemovePowerUp();
        }
    }

    void RemovePowerUp(){
        Mario.transform.localScale = new Vector3(Mario.transform.localScale.y/2,Mario.transform.localScale.x/2,Mario.transform.localScale.z);
        Mario.GetComponent<Movement>().AddVelocity = 5f;
        Mario.GetComponent<Movement>().holdJumpForce = 10f;
    }
}
