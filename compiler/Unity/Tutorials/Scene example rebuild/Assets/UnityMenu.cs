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
  private GameObject countDown1;
  private GameObject countDown2;
  private GameObject countDown3;
  public string begin_a
  {
    set
    {

      PlayB = GameObject.Find("Canvas/Play");
      QuitB = GameObject.Find("Canvas/Quit");

      countDown1 = GameObject.Find("Canvas/countDown1");
      countDown1.SetActive(false);

      countDown2 = GameObject.Find("Canvas/countDown2");
      countDown2.SetActive(false);

      countDown3 = GameObject.Find("Canvas/countDown3");
      countDown3.SetActive(false);
    }
  }
  public string NextScene
  {
    get { return Application.loadedLevel.ToString(); }
    set
    {
      if (value == "Loading")
      {
        PlayB.SetActive(false);
        QuitB.SetActive(false);
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
        Application.LoadLevel(y);
      }
      if (value == "Quit")
      {
        Application.Quit();
      }
    }
  }
}
                                                                                                                             