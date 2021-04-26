using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KnifeScript : MonoBehaviour
{
    public GameObject player;
    public GameObject knifeCanvas;
    void Start()
    {   
        knifeCanvas = GameObject.Find("knifeCanvas");
        knifeCanvas.SetActive(false);
        player = GameObject.Find("Player");
    }
    void Update()
    {
        if ((Vector3.Distance(player.transform.position, transform.position) < 20) && (Progression.Gamestage > 13))
        {   
            knifeCanvas.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }
        else
        {
            knifeCanvas.SetActive(false);
        }       
    }
}
