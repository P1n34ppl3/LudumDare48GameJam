using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overlay : MonoBehaviour
{
    public GameObject menu;
    public GameObject player;
    public PlayerMovement playerMovement;
    public GameObject mainCamera;
    public PlayerLook playerLook;


    void Start()
    {
        menu.SetActive(true);

        playerMovement = player.GetComponent<PlayerMovement>();
        playerMovement.enabled = false;

        playerLook = mainCamera.GetComponent<PlayerLook>();
        playerLook.enabled = false;
    }

    public void PlayGame()
    {   
        menu.SetActive(false);

        playerMovement.enabled = true;

        playerLook.enabled = true;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}