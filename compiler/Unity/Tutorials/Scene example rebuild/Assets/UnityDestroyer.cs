using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityDestroyer : MonoBehaviour
{
  public static UnityDestroyer instantiate(float e, Vector3 i)
  {
    GameObject c = GameObject.Find("Destroyer");
    UnityDestroyer d = c.GetComponent<UnityDestroyer>() as UnityDestroyer;
    if (e != 10)
    {
      GameObject[] f = GameObject.FindGameObjectsWithTag("Landscape");
      foreach (GameObject g in f)
      {
        if (g.transform.position.z == e)
        {
          GameObject.Destroy(g);
          break;
        }
      }
    }
    int distance_to_Delete = 400;

    GameObject[] a = GameObject.FindGameObjectsWithTag("Zombiegroup");
    foreach (GameObject b in a)
    {
      if (b.transform.childCount < 1)
      {
        GameObject.Destroy(b);
        break;
      }
    }
    GameObject[] h = GameObject.FindGameObjectsWithTag("Power_Up");
    foreach(GameObject b in h)
    {
      if (Vector3.Distance(b.transform.position,i) > distance_to_Delete)
      {
        GameObject.Destroy(b);
      }
    }
    GameObject[] j = GameObject.FindGameObjectsWithTag("Gasstation");
    foreach (GameObject b in j)
    {
      if (Vector3.Distance(b.transform.position, i) > distance_to_Delete)
      {
        GameObject.Destroy(b);
        break;
      }
    }
    GameObject[] k = GameObject.FindGameObjectsWithTag("TruckModel");
    foreach (GameObject b in k)
    {
      if (Vector3.Distance(b.transform.position, i) > distance_to_Delete)
      {
        GameObject.Destroy(b);
        break;
      }
    }
    GameObject[] l = GameObject.FindGameObjectsWithTag("Streetlight_light");
    foreach (GameObject b in l)
    {
      if (Vector3.Distance(b.transform.position, i) > distance_to_Delete)
      {
        GameObject.Destroy(b);
        break;
      }
    }
    GameObject[] m = GameObject.FindGameObjectsWithTag("Barrels");
    foreach (GameObject b in m)
    {
      if (Vector3.Distance(b.transform.position, i) > distance_to_Delete)
      {
        GameObject.Destroy(b);
        break;
      }
    }
    return d;
  }

}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  