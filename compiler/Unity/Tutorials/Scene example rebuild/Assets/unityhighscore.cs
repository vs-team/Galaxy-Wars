using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


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
  public Font mspacefont;
  private int NotInHighscoreTable;
  void OnGUI()
  {
    int s = PlayerPrefs.GetInt("ReachedByPlayer");
    if (boxCreated)
    {
      GUIStyle a = new GUIStyle();
      a.normal.textColor = Color.blue;
      a.fontSize = 16;
      a.font = mspacefont;

      GUI.Box(new Rect(Screen.width / 2 - 75, 120, 300, 40), "POS     NAME        SCORE ", a);


      for (int i = 1; i <= 8; i++)
      {
        PlayerPrefs.DeleteKey("scor" + i);
        string naam = PlayerPrefs.GetString("posit: " + i);
        var score = PlayerPrefs.GetInt("score: " + i);

        if (i == 8 && score > s && s != 0)
        {
          a.normal.textColor = Color.white;
          GUI.Box(new Rect(Screen.width / 2 - 75, 250 + 20 * i, 300, 15), "you are not in the highscore table. Your score was: " + s, a);
          a.normal.textColor = Color.blue;
        }

        if (score == s)
        {
          a.normal.textColor = Color.green;
          GUI.Box(new Rect(Screen.width / 2 - 75, 120 + 20 * i, 300, 15), i + ".      " + naam.ToUpper().PadRight(12) + "" + score, a);
          a.normal.textColor = Color.blue;
          continue;
        }

        GUI.Box(new Rect(Screen.width / 2 - 75, 120 + 20 * i, 300, 15), i + ".      " + naam.ToUpper().PadRight(12) + "" + score, a);
      }
      HST.SetActive(true);
    }
    else
    {
      HST.SetActive(false);
    }
    PlayerPrefs.Save();
  }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            