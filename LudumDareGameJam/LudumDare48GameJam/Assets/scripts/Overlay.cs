using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Overlay : MonoBehaviour
{
 
    public TextMeshProUGUI objectiveText;
    public GameObject deathScreen;
    public string[] Objectives;

    void Start()
    {   
        deathScreen = GameObject.Find("CaughtByNightmareScreen");
        deathScreen.SetActive(false);
    }

    void Update()
    {
        UpdateTipsAndObjectives();
    }



    void UpdateTipsAndObjectives()
    {
        objectiveText.text = Objectives[Progression.Gamestage];
    }


}
