using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Progression : MonoBehaviour
{
    public static int Gamestage;
    public TextMeshProUGUI Story;
    public GameObject StoryHolder;
    public string[] Text;

    int wait;

    void Start()
    {
        Gamestage = 0;
        StartCoroutine(Storyteller());
    }

    IEnumerator Storyteller()
    {
        StoryHolder.SetActive(false);
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
        Gamestage = 1;
        yield return new WaitUntil(() => PilCollection.pils >= 1);
        StoryHolder.SetActive(true);
        Story.text = Text[4];
        yield return new WaitForSeconds(3f);
        StoryHolder.SetActive(false);
        yield return new WaitUntil(() => PilCollection.pils >= 2);
        StoryHolder.SetActive(true);
        Story.text = Text[5];
        yield return new WaitForSeconds(3f);
        StoryHolder.SetActive(false);
        yield return new WaitUntil(() => PilCollection.pils >= 3);
        Gamestage = 2;
        StoryHolder.SetActive(true);
        Story.text = Text[6];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.E) == true);
        StoryHolder.SetActive(false);
        yield return new WaitUntil(() => Gamestage == 3);


    }

}
