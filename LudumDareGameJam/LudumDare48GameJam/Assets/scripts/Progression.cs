using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Progression : MonoBehaviour
{
    public static int Gamestage;
    public TextMeshProUGUI Story;
    public GameObject StoryHolder;
    public string[] Text;
    
    int wait = 1;

    void Start()
    {
        if (GameManager.QuickFix == 0)
        {
            Gamestage = 0;
            S1();
            GameManager.QuickFix = 1;
        }
        
    }
    public void S1()
    {
        StopCoroutine(Scene1());
        StoryHolder.SetActive(false);
        PilCollection.pils = 0;
        StartCoroutine(Scene1());
    }
    public void D1()
    {
        StopCoroutine(Dream1());
        StoryHolder.SetActive(false);
        PilCollection.pils = 0;
        StartCoroutine(Dream1());
    }
    public void D2()
    {
        StopCoroutine(Dream2());
        StoryHolder.SetActive(false);
        PilCollection.pils = 0;
        StartCoroutine(Dream2());
    }
    public void D3()
    {
        StopCoroutine(Dream3());
        StoryHolder.SetActive(false);
        PilCollection.pils = 0;
        StartCoroutine(Dream3());
    }
    public void D2Re()
    {
        StopCoroutine(Dream3());
        StopCoroutine(Dream2Re());
        StoryHolder.SetActive(false);
        StartCoroutine(Dream2Re());
    }
    public void D1Re()
    {
        StopCoroutine(Dream2Re());
        StopCoroutine(Dream1Re());
        StoryHolder.SetActive(false);
        StartCoroutine(Dream1Re());
    }
    public void S1Re()
    {
        SceneManager.LoadScene("Menu 1");
    }

    IEnumerator Scene1()
    {
        Gamestage = 0;
        StoryHolder.SetActive(false);
        yield return new WaitForSeconds(10);
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
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        yield return new WaitUntil(() => PilCollection.pils >= 2);
        StoryHolder.SetActive(true);
        Story.text = Text[5];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        yield return new WaitUntil(() => PilCollection.pils >= 3);
        StoryHolder.SetActive(true);
        Story.text = Text[6];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        Gamestage = 2;
    }
    IEnumerator Dream1()
    {
        Gamestage = 3;
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
    IEnumerator Dream2()
    {
        Gamestage = 6;
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
    }
    IEnumerator Dream3()
    {
        Gamestage = 9;
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
    }
    IEnumerator Dream2Re()
    {
        yield return new WaitForSeconds(0.1f);
        Gamestage = 12;
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[18];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        Gamestage = 13;
    }
    IEnumerator Dream1Re()
    {
        yield return new WaitForSeconds(0.1f);
        Gamestage = 14;
        yield return new WaitForSeconds(wait);
        StoryHolder.SetActive(true);
        Story.text = Text[19];
        yield return new WaitUntil(() => Input.GetKey(KeyCode.T) == true);
        StoryHolder.SetActive(false);
        Gamestage = 15;
    }
    
    

}
