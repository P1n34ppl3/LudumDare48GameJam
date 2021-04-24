using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyMove : MonoBehaviour
{   
    public GameObject player;
    public Rigidbody rb;
    public float speed;
    public float viewDistance;
        void Update()
    {   
        if (Vector3.Distance(player.transform.position, transform.position) < viewDistance)
        {
            followPlayer();
        }
        else
        {
            rb.velocity = transform.forward * speed;
        }
    }

    void followPlayer()
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
        float zDifference;
        zDifference = playerPosZ - enemyPosZ;

        double ricoDirection;
        ricoDirection = zDifference/xDifference;

        double angleDirection;
        angleDirection = Math.Atan(ricoDirection);

        float xVelocity;
        xVelocity = Convert.ToSingle(Math.Cos(angleDirection));

        float zVelocity;
        zVelocity = Convert.ToSingle(Math.Cos(angleDirection));

        rb.velocity = new Vector3(xVelocity * speed, 0, zVelocity * speed);
    }
}