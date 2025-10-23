using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMarioInXAxis : MonoBehaviour
{
    public GameObject Mario;
    public bool EasterEggEnabled = false;
    
    void Update()
    {    
        if(!EasterEggEnabled){  
            transform.position = new Vector3(Mario.transform.position.x, transform.position.y, transform.position.z);
        }
        else{
            transform.position = new Vector3(Mario.transform.position.x, Mario.transform.position.y, transform.position.z);
        }
    }   


}
