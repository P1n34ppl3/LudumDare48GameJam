using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathscript : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
            FindObjectOfType<GameManager>().GoBack();
    }
}
