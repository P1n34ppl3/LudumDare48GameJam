using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            if (Progression.Gamestage < 10)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }
    }


}
