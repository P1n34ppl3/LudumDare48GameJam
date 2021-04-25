using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Overlay : MonoBehaviour
{
    public GameObject tipsAndObjectives;
    public TextMeshProUGUI objectiveText;
    public int objectiveNumber = 0;

    void Update()
    {
        UpdateTipsAndObjectives();
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
