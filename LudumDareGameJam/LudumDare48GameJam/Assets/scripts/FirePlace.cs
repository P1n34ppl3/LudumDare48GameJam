using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlace : MonoBehaviour
{
    public GameObject player;
    public GameObject campfireCanvas;
    public GameObject fire;
    float igniteDistance;
    int gameStage;
    bool fireOn = false;

    void Start()
    {
        fire.SetActive(false);
    }
    void Update()
    {
        if ((Vector3.Distance(player.transform.position, transform.position) < 20) && !(fireOn))
        {   
            campfireCanvas.SetActive(true);

            if (Input.GetKey(KeyCode.E))
                {
                    fireOn = true;
                    fire.SetActive(true);
                }
        }
        else
        {
            campfireCanvas.SetActive(false);
        }
        if ((Vector3.Distance(player.transform.position, transform.position) < 12.5) && fireOn)
        {
            if (gameStage < 7)
            {
                print("ded");
            }
            else
            {
                print("ded");
            }
        }
    }


}
