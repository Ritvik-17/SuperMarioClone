using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{  
    public GameObject YouDiedScreen;

    private Rigidbody2D EnemyRigidbody;
    private int Direction = -1; 

    void Start()
    {
        EnemyRigidbody = GetComponent<Rigidbody2D>();
        EnemyRigidbody.velocity = new Vector2(Direction * 3f, EnemyRigidbody.velocity.y);
        Debug.Log(EnemyRigidbody.velocity);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(!collision.gameObject.CompareTag("Ground")){
            Debug.Log("Collided with: " + collision.gameObject.name);
            Direction = Direction*-1;
            transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x)*Direction, transform.localScale.y, transform.localScale.z);               
            EnemyRigidbody.velocity = new Vector2(Direction * 3f, EnemyRigidbody.velocity.y);
        }
        if (collision.gameObject.CompareTag("Player"))
        {   
            YouDiedScreen.SetActive(true);
            //FindObjectOfType<AudioManager>().Play("GameOver");
            //Time.timeScale = 0f;
        }
    }
}
