using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deathscript : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        FindObjectOfType<GameManager>().GoBack();
    }
}
