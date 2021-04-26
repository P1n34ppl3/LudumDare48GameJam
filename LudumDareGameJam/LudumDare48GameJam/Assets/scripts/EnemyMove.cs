using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour
{   
    public GameObject player;
    public Rigidbody rb;
    public float speed;
    public float viewDistance;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {   
        if (Vector3.Distance(player.transform.position, transform.position) < viewDistance)
        {
            followPlayer();
        }
        
        if (Vector3.Distance(player.transform.position, transform.position) < 12)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void followPlayer()
    {
        var target = player.GetComponent<Transform>();
        
        var lookPos = target.position - transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 1);

        
        rb.velocity = new Vector3(0, rb.velocity.y, 0) + transform.forward * speed;
    }
}
