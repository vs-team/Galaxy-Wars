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
          return d;
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
          return d;
      }
    }
    /*
    */
    GameObject[] j = GameObject.FindGameObjectsWithTag("Gasstation");

    foreach (GameObject b in j)
    {
      if (Vector3.Distance(b.transform.position, i) > distance_to_Delete)
      {
        GameObject.Destroy(b);
          return d;
      }
    }
    GameObject[] m = GameObject.FindGameObjectsWithTag("Barrels");

    foreach (GameObject b in m)
    {
      if (Vector3.Distance(b.transform.position, i) > distance_to_Delete)
      {
        GameObject.Destroy(b);
      }
    }
    return d;
  }

}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                