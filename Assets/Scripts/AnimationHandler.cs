using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationHandler : MonoBehaviour
{
    private  Animator PlayerAnimator;

    void Start()
    {
        PlayerAnimator = GetComponent<Animator>();
    }
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        if (moveInput != 0)
        {   
            PlayerAnimator.SetBool("IsRunning", true);
        }
        else
        {
            PlayerAnimator.SetBool("IsRunning", false);
        }
        if(Input.GetButtonDown("Jump"))
        {
            PlayerAnimator.SetTrigger("Jump");
        }
    }
}
