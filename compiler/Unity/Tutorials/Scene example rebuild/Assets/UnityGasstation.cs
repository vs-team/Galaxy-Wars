using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityGasstation : MonoBehaviour
{
  public GameObject modely;

  public static UnityGasstation Instantiate(Vector3 newPos)
  {
    GameObject gs = GameObject.Instantiate(Resources.Load("Prefabs/Gasstationprefab"), newPos, Quaternion.identity) as GameObject;
    UnityGasstation component = gs.GetComponent<UnityGasstation>() as UnityGasstation;

    List<Transform> parkingspots = new List<Transform>();
    Transform comps = gs.transform;
    foreach (Transform child in comps)
    {
      if (child.tag == "Parkingspot")
      {
        Transform toAdd = child.gameObject.GetComponent<Transform>();
        parkingspots.Add(toAdd);
      }
    }
      List<string> a = new List<string>();
    Object[] models = Resources.LoadAll("JeepModels");
      if (models.Length > 0)
      {
        Debug.Log("Jeepies list filled");
        foreach (Object c in models)
        {
        //Debug.Log(c.name);
          a.Add(c.name);
        }
      }
    var x = gs.transform;
    var dir = parkingspots[0].transform.position;
    var p = x.TransformPoint(dir);
    Debug.Log(p);
    component.modely = GameObject.Instantiate(Resources.Load("JeepModels/" + a[0] + "1"), p, Quaternion.identity) as GameObject;
    return component;
    }
  public Vector3 Position
  {
    get { return this.transform.position; }
  }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      