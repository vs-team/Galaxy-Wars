using UnityEngine;
using System.Collections;
using Casanova.Prelude;
using System.Collections.Generic;
using UnityEngine.UI;

public class UnityMenu : MonoBehaviour
{
  public Texture backgroundTexture;

  private GameObject PlayB;
  private GameObject QuitB;
  private GameObject BTMB;
  private GameObject CreditsB;
  private GameObject HSB;
  private GameObject countDown1;
  private GameObject countDown2;
  private GameObject countDown3;
  private GameObject CreditText;
  private InputField inp;

  public int upd
  {
    get { return 0; }
    set
    {
      for (int i = 1; i <= 8; i++)
      {
        string st = i.ToString();
        string p = PlayerPrefs.GetString("pos" + st);
        if (p == "NameNotSetYet")
        {
          int s = PlayerPrefs.GetInt("scor" + st);
          PlayerPrefs.DeleteKey("pos" + st);
          PlayerPrefs.DeleteKey("scor" + i);
          PlayerPrefs.SetString("posit: " + st, inp.text);
          PlayerPrefs.SetInt("score: " + st, s);
        }
      }
      PlayerPrefs.Save();
    }
  }
  public int sc
  {
    get { return reachedscor; }
    set
    {
      for (int i = 1; i <= 8; i++)
      {
        int p = PlayerPrefs.GetInt("scor" + i);
        if (p != 0)
        {
          PlayerPrefs.DeleteKey("ReachedByPlayer");
          reachedscor = p;
          Debug.Log("p unitymenu" + p);
          PlayerPrefs.SetInt("ReachedByPlayer", p);
        }
      }

      PlayerPrefs.Save();
    }
  }
  public int rbp
  {
    get { return PlayerPrefs.GetInt("ReachedByPlayer"); }
  }

  private int reachedscor;

  public string begin_a
  {
    set
    {
      if (Application.loadedLevel == 0)
      {
        QuitB = GameObject.Find("Canvas/Quit");
        CreditsB = GameObject.Find("Canvas/Credits");
        HSB = GameObject.Find("Canvas/HighScore");
      }

      if (Application.loadedLevel == 0 || Application.loadedLevel == 2)
      {
        PlayB = GameObject.Find("Canvas/Play");
        countDown1 = GameObject.Find("Canvas/countDown1");
        countDown1.SetActive(false);

        countDown2 = GameObject.Find("Canvas/countDown2");
        countDown2.SetActive(false);

        countDown3 = GameObject.Find("Canvas/countDown3");
        countDown3.SetActive(false);
      }

      if (Application.loadedLevel == 2 || Application.loadedLevel == 3)
      {
        BTMB = GameObject.Find("Canvas/Back_To_Menu");
      }
      if (Application.loadedLevel == 4)
      {
        inp = GameObject.Find("Canvas/input_field").GetComponent<InputField>();

      }

    }
  }
  public string NextScene
  {
    get { return Application.loadedLevel.ToString(); }
    set
    {
      if (Application.loadedLevel == 0)
      {
        CreditsB.SetActive(false);
        HSB.SetActive(false);
        QuitB.SetActive(false);
      }
      if (Application.loadedLevel == 2)
      {
        BTMB.SetActive(false);
      }

        if (value == "Loading")
      {
        PlayB.SetActive(false);

      }
      if (value == "countDown3")
      {
        countDown3.SetActive(true);
      }
      if (value == "countDown2")
      {
        countDown3.SetActive(false);
        countDown2.SetActive(true);
      }
      if (value == "countDown1")
      {
        countDown2.SetActive(false);
        countDown1.SetActive(true);
      }
      if (value == "NextScene")
      {
        var x = Application.loadedLevel;
        var y = x + 1;
        Application.LoadLevel(1);
      }
      if (value == "Quit")
      {
        Application.Quit();
        PlayB.SetActive(false);
      }
    }
  }
  public int LL
  {
    get { return Application.loadedLevel; }
    set
    {
      if(Application.loadedLevel == 0 && value == 2)
      {
        PlayerPrefs.DeleteKey("ReachedByPlayer");
        PlayerPrefs.Save();
      }
      Application.LoadLevel(value);
    }
  }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                