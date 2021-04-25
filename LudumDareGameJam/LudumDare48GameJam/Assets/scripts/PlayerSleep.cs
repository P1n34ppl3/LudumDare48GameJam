using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSleep : MonoBehaviour
{
    
    public Animation anim;
    public GameObject PressE;
    float timer = 1f;
    

    void Awake()
    {
        anim.Play("WakeUp");
    }

    void Update()
    {
        timer -= Time.deltaTime;
        GameObject Sleep = GameObject.FindWithTag("Sleep");

        if (Vector3.Distance(Sleep.transform.position, transform.position) <= 15)
        {
            if (PilCollection.pils >= 3)
            {
                PressE.SetActive(true);
                if (Input.GetKey(KeyCode.E))
                {

                    if (anim.isPlaying != true)
                    {
                        anim.Play("ToSleep");
                        Invoke("Next", 4f);
                    }
                    PressE.SetActive(false);
                }
            }
            
        }
        if (timer <= 0f)
        {
            PressE.SetActive(false);
            timer = 1f;
        }
       
    }
    void Next()
    {
        FindObjectOfType<GameManager>().GoNextScene();
    }


}
