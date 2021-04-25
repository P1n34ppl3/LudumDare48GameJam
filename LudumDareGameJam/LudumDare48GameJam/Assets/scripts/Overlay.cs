using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Overlay : MonoBehaviour
{
    public GameObject menu;
    public GameObject tipsAndObjectives;
    public TextMeshProUGUI objectiveText;
    public GameObject player;
    public PlayerMovement playerMovement;
    public GameObject mainCamera;
    public PlayerLook playerLook;
    public int objectiveNumber = 0;


    void Start()
    {   
        Time.timeScale = 0;

        menu.SetActive(true);

        playerMovement = player.GetComponent<PlayerMovement>();
        playerMovement.enabled = false;

        playerLook = mainCamera.GetComponent<PlayerLook>();
        playerLook.enabled = false;
    }

    void Update()
    {
        UpdateTipsAndObjectives();
    }

    public void PlayGame()
    {   
        Time.timeScale = 1;

        menu.SetActive(false);

        playerMovement.enabled = true;

        playerLook.enabled = true;

        EnableTipsAndObjectives();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void EnableTipsAndObjectives()
    {
        tipsAndObjectives.SetActive(true);
    }

    public void DisableTipsAndObjectives()
    {
        tipsAndObjectives.SetActive(false);
    }

    void UpdateTipsAndObjectives()
    {
        switch(objectiveNumber)
        {
            case 0:
                objectiveText.text = "Go to Sheep";
                break;
            case 1:
                objectiveText.text = "Go to Bed";
                break;
            case 2:
                objectiveText.text = "Go to Bed";
                break;
            case 3:
                objectiveText.text = "filler";
                break;
        }
    }

    public void NextObjective()
    {
        objectiveNumber += 1;
    }
}
