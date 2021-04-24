using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Private
    CharacterController controller;
    float x;
    float y;
    float z;
    Vector3 move;
    int jumped; //timer to wait some frames after jumping
    
    //Public
    public int moveSpeed;
    public float gravityStrength;
    public int jumpStrength;
    public LayerMask groundLayer;

    void Awake()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }
    void Update()
    {
        //Input
        x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        //Gravity
        if(IsGrounded() && jumped < 0)
        {
            y = -1f;
            jumped --;
        }
        else
            y -= gravityStrength * Time.deltaTime;

        //Jump
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            y = jumpStrength;
            jumped = 5;
        }
        
        //putting variables in vector and calling Move function
        move = transform.right * x + Vector3.up * y * Time.deltaTime + transform.forward * z;
        controller.Move(move);
    }

    bool IsGrounded()
    {
        float margin = 1f;
        return Physics.CheckBox(controller.bounds.center + Vector3.down * (controller.bounds.extents.y - margin + 0.01f), new Vector3(controller.bounds.extents.x, margin, controller.bounds.extents.z), Quaternion.Euler(0,0,0), groundLayer);
    }
}
