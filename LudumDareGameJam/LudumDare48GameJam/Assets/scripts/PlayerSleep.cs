using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSleep : MonoBehaviour
{
    
    public Animation anim;

    
    

    void Start()
    {
        
        anim.Play("WakeUp");
        
    }

    void Update()
    {

        GameObject Sleep = GameObject.FindWithTag("Sleep");

        if (Vector3.Distance(Sleep.transform.position, transform.position) <= 15)
        {
            if (Progression.Gamestage == 2 || Progression.Gamestage == 5 || Progression.Gamestage == 8)
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
        

        
        
        FindObjectOfType<GameManager>().GoNextScene();
    }


}
