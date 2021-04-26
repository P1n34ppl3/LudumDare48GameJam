using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Progression : MonoBehaviour
{
    public static int Gamestage;
    int RepeatBlock = 0;
    public TextMeshProUGUI Story;
    public GameObject StoryHolder;
    string Line;

    void Awake()
    {
        Gamestage = 0;
    }
    void Update()
    {
        switch (Gamestage)
        {
            case 0:
                if (RepeatBlock == 0)
                {
                    RepeatBlock = 1;
                    Invoke("T1", 5f);

                }
                break;
        }

    }
    void T1()
    {
        StoryHolder.SetActive(true);
        Story.text = "Insomnia. The terrible condition of not being able to sleep.";
        if (Input.GetKey(KeyCode.T))
        {
            StoryHolder.SetActive(false);
            Invoke("T1", 5f);
        }
        else
        {
            T1();
        }
    }

}
