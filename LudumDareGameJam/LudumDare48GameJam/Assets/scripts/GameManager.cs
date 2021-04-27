using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Script;
    public static int QuickFix;
    public void GoNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Invoke("fix", 1);
    }
    void fix()
    {
        if (Progression.Gamestage == 2)
        {
            Script.GetComponent<Progression>().D1();
        }
        if (Progression.Gamestage == 5)
        {
            Script.GetComponent<Progression>().D2();
        }
        if (Progression.Gamestage == 8)
        {
            Script.GetComponent<Progression>().D3();
        }
    }

    public void RestartScene()
    {
        if (Progression.Gamestage == 0 || Progression.Gamestage == 1 || Progression.Gamestage == 2)
        {
            Script.GetComponent<Progression>().S1();
        }
        if (Progression.Gamestage == 3 || Progression.Gamestage == 4 || Progression.Gamestage == 5)
        {
            Script.GetComponent<Progression>().D1();
        }
        if (Progression.Gamestage == 6 || Progression.Gamestage == 7 || Progression.Gamestage == 8)
        {
            Script.GetComponent<Progression>().D2();
        }
        if (Progression.Gamestage == 9 || Progression.Gamestage == 10 || Progression.Gamestage == 11)
        {
            Script.GetComponent<Progression>().D3();
        }
        if (Progression.Gamestage == 12 || Progression.Gamestage == 13 )
        {
            Script.GetComponent<Progression>().D2Re();
        }
        if (Progression.Gamestage == 14 || Progression.Gamestage == 15)
        {
            Script.GetComponent<Progression>().D1Re();
        }
        if (Progression.Gamestage == 16)
        {
            Script.GetComponent<Progression>().S1Re();
        }


        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoBack()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Invoke("fix2", 1);
    }
    void fix2()
    {
        if (Progression.Gamestage == 9 || Progression.Gamestage == 10 || Progression.Gamestage == 11)
        {
            Script.GetComponent<Progression>().D2Re();
        }
        if (Progression.Gamestage == 12 || Progression.Gamestage == 13)
        {
            Script.GetComponent<Progression>().D1Re();
        }
        if (Progression.Gamestage == 14 || Progression.Gamestage == 15)
        {
            Script.GetComponent<Progression>().S1Re();
        }
    }
}
