using UnityEngine;
using System.Collections;

public class UnityCheckpoint : MonoBehaviour
{

  public static UnityCheckpoint Find(Vector3 v)
  {
    GameObject[] z = GameObject.FindGameObjectsWithTag("RepairZone");
    GameObject test = z[0];
    foreach (GameObject j in z)
    {
      if (Vector3.Distance(j.transform.position, v) < Vector3.Distance(j.transform.position, test.transform.position))
      {
        test = j;
        Debug.Log("Repair zone "+test.gameObject.transform);
      }
      else
      {
        Debug.Log("not this gameobject"+test.gameObject.transform);
      }
    }
    GameObject a = test;
    UnityCheckpoint b = a.GetComponent<UnityCheckpoint>() as UnityCheckpoint;
    return b;
  }

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