using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningPole : MonoBehaviour
{
    public GameObject YouWonScreen;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {   
            YouWonScreen.SetActive(true);
            //Time.timeScale = 0f;
        }
    }
}
