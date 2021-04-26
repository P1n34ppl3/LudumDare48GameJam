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
    public string[] Text;
    private int index = 0;
    int wait;

    void Awake()
    {
        Gamestage = 0;
        StartCoroutine(Storyteller());
    }

    IEnumerator Storyteller()
    {
        yield return new WaitForSeconds(20);
        StoryHolder.SetActive(true);
        Story.text = Text[0];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.E) == true);
        StoryHolder.SetActive(false);
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[1];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.E) == true);
        StoryHolder.SetActive(false);
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[2];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.E) == true);
        StoryHolder.SetActive(false);
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[3];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.E) == true);
        StoryHolder.SetActive(false);
        yield return new WaitForSeconds(wait);
        Gamestage = 1;


    }

}
