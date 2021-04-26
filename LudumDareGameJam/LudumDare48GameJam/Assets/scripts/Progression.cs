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
        
        StoryHolder.SetActive(true);
        Story.text = Text[6];
        StoryHolder.SetActive(false);
        Gamestage = 2;
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
        yield return new WaitUntil(() => Gamestage == 6);
        PilCollection.pils = 0;
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[10];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[11];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        Gamestage = 7;
        yield return new WaitUntil(() => PilCollection.pils >= 3);
        StoryHolder.SetActive(true);
        Story.text = Text[12];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        Gamestage = 8;
        yield return new WaitUntil(() => Gamestage == 9);
        PilCollection.pils = 0;
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[13];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false); 
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[14];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false); 
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[15];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        Gamestage = 10;
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[16];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        Gamestage = 11;
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[17];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        yield return new WaitUntil(() => Gamestage == 12);
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[18];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        Gamestage = 13;
        yield return new WaitUntil(() => Gamestage == 14);
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[19];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        Gamestage = 15;
        yield return new WaitUntil(() => Gamestage == 16);
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[19];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[19];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);



    }

}
