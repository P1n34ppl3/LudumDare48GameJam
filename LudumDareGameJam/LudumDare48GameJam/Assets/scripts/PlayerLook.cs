using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    //Private
    float x;
    float y;
    float xRotation;
    //Public
    public float mouseSensetivity;

    public Transform player;
    void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        //Input
        x = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensetivity;
        y = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensetivity;

        
        xRotation -= y;
        xRotation = Mathf.Clamp(xRotation, -90,90);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * x);
    }
}
