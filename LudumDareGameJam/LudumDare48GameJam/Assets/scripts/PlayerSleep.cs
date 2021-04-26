using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSleep : MonoBehaviour
{
    
    public Animation anim;


    

    void Awake()
    {
        anim.Play("WakeUp");
    }

    void Update()
    {

        GameObject Sleep = GameObject.FindWithTag("Sleep");

        if (Vector3.Distance(Sleep.transform.position, transform.position) <= 15)
        {
            if (PilCollection.pils >= 3)
            {
      
                if (Input.GetKey(KeyCode.E))
                {

                    if (anim.isPlaying != true)
                    {
                        anim.Play("ToSleep");
                        PilCollection.pils = 0;
                        Invoke("Next", 4f);
                    }

                }
            }
            
        }

       
    }
    void Next()
    {
        Progression.Gamestage += 1;
        FindObjectOfType<GameManager>().GoNextScene();
    }


}
