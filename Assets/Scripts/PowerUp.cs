using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject Mario;

    void OnCollisionEnter2D(Collision2D Collider2D){
        if(Collider2D.gameObject.CompareTag("Player")){
            AddPowerUpEffects();
        }
    }

    void AddPowerUpEffects(){
        Mario.transform.localScale = new Vector3(Mario.transform.localScale.x*2,Mario.transform.localScale.y*2,Mario.transform.localScale.z);
        Mario.GetComponent<Movement>().AddVelocity = 8f;
        Mario.GetComponent<Movement>().holdJumpForce = 20f;
        Mario.GetComponent<Movement>().Lives =+ 1;
        FindObjectOfType<AudioManager>().Play("Mushroom");
        Destroy(gameObject);
    }

}
