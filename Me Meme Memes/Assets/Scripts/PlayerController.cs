using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    public bool jumpOn = true;
    public bool crouchOn = true;

    float horizMove = 0f;
    bool jump = false;
    bool crouch = false;
    
    void Update()
    {
        horizMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (jumpOn)
        {
            if (Input.GetButtonDown("Jump"))
            {
                jump = true;
            }
        }
        if (crouchOn)
        {
            if (Input.GetButtonDown("Crouch") )
            {
                crouch = true;
            } else if (Input.GetButtonUp("Crouch"))
            {
                crouch = false;
            }
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizMove * Time.fixedDeltaTime, crouch, jump);
        
        jump = false;

    }
}
