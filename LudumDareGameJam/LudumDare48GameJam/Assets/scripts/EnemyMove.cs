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

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
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

        float angleDirection;
        angleDirection = Convert.ToSingle(Math.Atan(ricoDirection));

       transform.rotation = Quaternion.Euler(0, angleDirection, 0);

        rb.velocity = transform.forward * speed;
    }
}
