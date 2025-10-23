using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMarioInXAxis : MonoBehaviour
{
    public GameObject Mario;
    
    void Update()
    {
       transform.position = new Vector3(Mario.transform.position.x, transform.position.y, transform.position.z);
    }
}
