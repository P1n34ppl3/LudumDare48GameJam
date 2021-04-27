using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Overlay : MonoBehaviour
{
 
    public TextMeshProUGUI objectiveText;
    public string[] Objectives;



    void Update()
    {
        UpdateTipsAndObjectives();
    }



    void UpdateTipsAndObjectives()
    {
        objectiveText.text = Objectives[Progression.Gamestage];
    }


}
