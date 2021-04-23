using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JesusMovement : MonoBehaviour
{
    CharacterController controller;
    float x;
    float zzzzzz;
    public int needForJesusSpeed;
    Vector3 gojesusgo;
    void Awake()
    {
        //ALMIGHTYJESUS GETS CHARACTERCONTROLLER ASSIGNED FOR SUPERIORITY
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        //YOU WILL CONTROL THE JESUSBEAN
        x = Input.GetAxis("Horizontal") * Time.deltaTime;
        zzzzzz = Input.GetAxis("Vertical") * Time.deltaTime;

        //JESUSBEAN WILL NOT STOP FOR ANYONE
        gojesusgo = Vector3.right * x + Vector3.forward * zzzzzz;
        
        //WALK ON WATER DUM DUM DUM ***QUE MILK INC.***
        controller.Move(gojesusgo * needForJesusSpeed);

    }
}
