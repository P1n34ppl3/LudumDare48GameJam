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

    int wait = 5;

    void Start()
    {
        Gamestage = 0;
        StartCoroutine(Storyteller());
    }
    private void Update()
    {
        Debug.Log(Gamestage);
    }
    IEnumerator Storyteller()
    {
        StoryHolder.SetActive(false);
        yield return new WaitForSecondsRealtime(2);
        StoryHolder.SetActive(true);
        Story.text = Text[0];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[1];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[2];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[3];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
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
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        yield return new WaitUntil(() => Gamestage == 3);
        PilCollection.pils = 0;
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[7];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[8];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        Gamestage = 4;
        yield return new WaitUntil(() => PilCollection.pils >= 3);
        StoryHolder.SetActive(true);
        Story.text = Text[9];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        Gamestage = 5;

    }

}
