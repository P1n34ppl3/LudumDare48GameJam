using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{   
    public GameObject player;
        void Update()
    {   
        float playerPosX;
        playerPosX = player.transform.position.x;
        float playerPosZ;
        playerPosZ = player.transform.position.z;

        float enemyPosX;
        enemyPosX = transform.position.x;
        float enemyPosZ;
        enemyPosZ = transform.position.z;

        float xDifference;
        xDifference = playerPosX - enemyPosX;
        float zDifference = playerPosZ - enemyPosZ;

    }
}
