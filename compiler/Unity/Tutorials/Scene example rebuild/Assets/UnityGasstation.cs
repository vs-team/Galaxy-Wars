using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityGasstation : MonoBehaviour {

  public static UnityGasstation Instantiate(Vector3 newPos)
  {
    GameObject gs = GameObject.Instantiate(Resources.Load("Prefabs/Gasstationprefab"), newPos, Quaternion.identity) as GameObject;
    UnityGasstation component = gs.GetComponent<UnityGasstation>() as UnityGasstation;
    component.parkingspots = new List<Transform>();
    Transform comps = gs.transform;
    foreach(Transform child in comps)
    {
      if (child.tag == "Parkingspot")
      {
        Transform toAdd = child.gameObject.GetComponent<Transform>();
        component.parkingspots.Add(toAdd);
      }
    }
    return component;
  }
  public List<string> Jeeps
  {
    get
    {
      List<string> a = new List<string>();
      Object[] models = Resources.LoadAll("Jeeps");
      if (models.Length > 0)
      {
        Debug.Log("Jeepies list filled");
        foreach (Object c in models)
        {
          Debug.Log(c.name);
          a.Add(c.name);
        }

      }
      else
      {
        Debug.Log("Empty jeepies list");
      }
      return a;
    }

  }

  private List<Transform> parkingspots;
  public List<Transform> ParkingSpotList
  {
    get { return parkingspots; }
  }
  public Vector3 Position
  {
    get { return this.transform.position; }
  }

}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                