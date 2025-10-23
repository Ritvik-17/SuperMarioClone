using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject YouDiedScreen;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            YouDiedScreen.SetActive(true);
            FindObjectOfType<AudioManager>().Stop("Theme");            
            FindObjectOfType<AudioManager>().Play("GameOver");
            Time.timeScale = 0f;
        }        
    }
}
