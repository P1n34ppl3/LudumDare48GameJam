using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilCollection : MonoBehaviour
{
    private GameObject Pil;
    public GameObject Player;
    public GameObject PressE;
    public static int pils;
    void Update()
    {


        if (Vector3.Distance(Player.transform.position, transform.position) <= 2)
        {
            PressE.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                Pil.SetActive(false);
                pils = pils + 1;
                Debug.Log(pils);
            }
        }
        else
        {
            PressE.SetActive(false);
        }
    }
}
