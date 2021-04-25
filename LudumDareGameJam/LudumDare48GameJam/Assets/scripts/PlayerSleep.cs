using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSleep : MonoBehaviour
{
    
    public Animation anim;
    public GameObject PressE;


    void Awake()
    {
        anim.Play("WakeUp");
    }

    void Update()
    {
        GameObject Sleep = GameObject.FindWithTag("Sleep");

        if (Vector3.Distance(Sleep.transform.position, transform.position) <= 2)
        {
            PressE.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("ok");
                if (anim.isPlaying != true)
                {
                    anim.Play("ToSleep");
                    Invoke("Next", 4f);
                }
               
            }
        }
        else
        {
            PressE.SetActive(false);
        }
    }
    void Next()
    {
        Debug.Log("next scene");
    }

}
