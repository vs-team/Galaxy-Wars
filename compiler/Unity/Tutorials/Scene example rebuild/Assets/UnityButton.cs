using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Casanova.Prelude;
using System.Collections.Generic;


public class UnityButton : MonoBehaviour
{

  private bool isPressed = false;

  public bool IsPressed { get { return isPressed; } set { isPressed = value; } }

  public static UnityButton Find(string model)
  {
    GameObject a = GameObject.Find(model);
    UnityButton x = a.GetComponent<UnityButton>() as UnityButton;
    return x;
  }

  public void Pressed()
  {
    IsPressed = true;
  }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             