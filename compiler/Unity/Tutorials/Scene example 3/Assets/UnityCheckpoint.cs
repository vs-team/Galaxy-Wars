using UnityEngine;
using System.Collections;

public class UnityCheckpoint : MonoBehaviour {

  void OnTriggerEnter(Collider other)
  {
    if (other.name == "truck")
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