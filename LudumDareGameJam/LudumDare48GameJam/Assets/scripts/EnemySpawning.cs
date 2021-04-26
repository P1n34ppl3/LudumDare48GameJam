using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    bool monstersActive;
    public GameObject EnemyPrefab;
    void Update()
    {
        if (!monstersActive && (Progression.Gamestage >= 9))
        {
            GameObject[] sheep = GameObject.FindGameObjectsWithTag("sheep");
            foreach(GameObject shep in sheep)
            {
            Instantiate(EnemyPrefab, shep.transform.position, shep.transform.rotation);
            GameObject.Destroy(shep);
            }
        }
    }
}
