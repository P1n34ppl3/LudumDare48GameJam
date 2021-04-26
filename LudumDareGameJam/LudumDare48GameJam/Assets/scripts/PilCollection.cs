using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PilCollection : MonoBehaviour
{
    public GameObject Pil;
    GameObject Player;
    public GameObject PressE;
    public static int pils;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        

        if (Vector3.Distance(Player.transform.position, transform.position) <= 15)
        {
            PressE.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                Pil.SetActive(false);
                pils = pils + 1;
                FindObjectOfType<AudioManager>().Play("Pill_Pickup");
                Debug.Log(pils);
            }
        }
    }
}
