using UnityEngine;
using System.Collections;

public class UnityCheckpoint : MonoBehaviour {

  void OnTriggerEnter(Collider other)
  {
    if (other.name == "Jeep_KM_body")
    {
      Debug.Log("Entered");
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