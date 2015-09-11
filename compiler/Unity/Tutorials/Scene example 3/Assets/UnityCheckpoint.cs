using UnityEngine;
using System.Collections;

public class UnityCheckpoint : MonoBehaviour {

  void OnTriggerEnter(Collider other)
  {
    Debug.Log(other.name);
    if (other.name == "truck")
    {
      Debug.Log("Check has entered");
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