using UnityEngine;
using System.Collections;

public class UnityCheckpoint : MonoBehaviour {

  void OnTriggerEnter(Collider other)
  {
    if (other.name == "First Person Controller")
    {
      privateIsEntered = true;
    }
  }



  private bool privateIsEntered = false;
  public bool isEntered
  {
    get { return privateIsEntered; }
    set { privateIsEntered = value; }
  }
}                                                                                                                          