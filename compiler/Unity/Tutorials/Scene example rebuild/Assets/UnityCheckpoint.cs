using UnityEngine;
using System.Collections;

public class UnityCheckpoint : MonoBehaviour
{

  public static UnityCheckpoint Find()
  {
    GameObject a = GameObject.Find("Repair_Zone");
    UnityCheckpoint b = a.GetComponent<UnityCheckpoint>() as UnityCheckpoint;
    b.PBB = GameObject.Find("ProgressBarLabelInside");
    return b;
  }
  private GameObject PBB;

  void OnTriggerEnter(Collider other)
  {
    var x = other.transform.root.gameObject.tag;
    if (x == "Trucks")
    {
      privateIsEntered = true;
    }
  }
  void OnTriggerExit(Collider other)
  {
    var x = other.transform.root.gameObject.tag;
    if (x == "Trucks")
    {
      privateIsEntered = false;
    }
  }
  private bool privateIsEntered;

  public bool isEntered
  {
    get { return privateIsEntered; }
  }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           