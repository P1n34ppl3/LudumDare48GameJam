using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PilCollection : MonoBehaviour
{
    public GameObject Pil;
    GameObject Player;

    public static int pils;
    public GameObject Holder;

    void Start()
    {
        Holder.SetActive(true);
        Pil.SetActive(true);
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (Progression.Gamestage == 1 || Progression.Gamestage == 4 || Progression.Gamestage == 7)
        {
            if (Vector3.Distance(Player.transform.position, transform.position) <= 15)
            {

                if (Input.GetKey(KeyCode.E))
                {
                    Holder.SetActive(false);
                    pils = pils + 1;
                    FindObjectOfType<AudioManager>().Play("Pill_Pickup");
                    Debug.Log(pils);
                }
            }
        }
        if (Progression.Gamestage > 9)
        {
            Pil.SetActive(false);
        }



    }
}
