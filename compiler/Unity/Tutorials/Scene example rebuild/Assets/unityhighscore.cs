using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class unityhighscore : MonoBehaviour
{

  private bool boxCreated;
  public bool Box
  {
    get { return boxCreated; }
    set
    {
      boxCreated = value;
    }
  }
  private GameObject HST;
  public static unityhighscore instantiate()
  {
    GameObject a = GameObject.Find("Highscore");
    unityhighscore z = a.GetComponent<unityhighscore>();
    GameObject b = GameObject.Find("Canvas/HighScoreTable");
    z.HST = b;
    return z;
  }
  void OnGUI()
  {
    if (boxCreated)
    {
      GUIStyle a = new GUIStyle();
      a.normal.textColor = Color.blue;
      a.fontSize = 12;
      GUI.Box(new Rect(Screen.width / 2 - 75, 120, 300, 40), "POS  NAME      SCORE ", a);
      for (int i = 1; i <= 8; i++)
      {
        string naam = PlayerPrefs.GetString("posit: " + i);
        var score = PlayerPrefs.GetInt("score: " + i);
        GUI.Box(new Rect(Screen.width / 2 - 75, 120 + 20 * i, 300, 15), i + ".      " + naam.ToUpper().PadRight(12) + "" + score, a);
      }
      HST.SetActive(true);
    }
    else
    {
      HST.SetActive(false);
    }
  }
}
                                                                                                                                                                                                                                                                                                                           