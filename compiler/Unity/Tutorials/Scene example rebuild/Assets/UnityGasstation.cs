using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityGasstation : MonoBehaviour
{
  public GameObject modely;
  public Light RepairZone;
  public List<Transform> SP2;
  public List<Vector3> Blocations;

  public static UnityGasstation Instantiate(Vector3 newPos)
  {
    GameObject gs = GameObject.Instantiate(Resources.Load("Prefabs/Gasstationprefab"), newPos, Quaternion.identity) as GameObject;
    UnityGasstation component = gs.GetComponent<UnityGasstation>() as UnityGasstation;
    List<Transform> parkingspots = new List<Transform>();
    List<Vector3> BarrelLocation = new List<Vector3>();
    List<Transform> ZombieSpawnPoint = new List<Transform>();
    Transform comps = gs.transform;
    foreach (Transform child in comps)
    {
      if (child.tag == "Parkingspot")
      {
        Transform toAdd = child.FindChild("truckspawnpoint");
        parkingspots.Add(toAdd);
      }
      if (child.tag == "ZombieSpawnPoint")
      {
        Transform toAdd = child;
        ZombieSpawnPoint.Add(toAdd);
      }
      if (child.tag == "Barrels")
      {
        Vector3 toAdd = child.position;
        BarrelLocation.Add(toAdd);
      }
    }
    List<string> a = new List<string>();
    Object[] models = Resources.LoadAll("JeepModels");
    if (models.Length > 0)
    {
      foreach (Object c in models)
      {
        //Debug.Log(c.name);
        a.Add(c.name);
      }
    }
    var x = gs.transform;
    var dir = parkingspots[0].transform;
    component.modely = GameObject.Instantiate(Resources.Load("JeepModels/" + a[0] + "1"), dir.position, Quaternion.identity) as GameObject;
    component.modely.transform.parent = gs.gameObject.transform;
    component.RepairZone = gs.transform.Find("Repair_Zone").GetComponent<Light>();
    component.SP2 = ZombieSpawnPoint;
    component.Blocations = BarrelLocation;
    return component;
  }

  int Counter;
  void Update()
  {
    Counter++;
    if (Counter < 60)
    {
      RepairZone.cookieSize = Mathf.MoveTowards(0.0f, 30.0f, Counter * 0.5f);
    }
    else
    {
      Counter = 0;
    }
  }
  private bool playerInBounds;

  void OnCollisionEnter(Collision Other)
  {
    if (Other.gameObject.tag == "Trucks")
    {
      Debug.Log("inside repair zone");
      playerInBounds = true;
    }
  }

  void OnCollisionExit(Collision Other)
  {
    if (Other.gameObject.tag == "Trucks")
    {
      Debug.Log("leaving repair zone");
      playerInBounds = false;
    }
  }

  public Vector3 Position
  {
    get { return this.transform.position; }
  }
  bool destroyed;

  public bool Destroyed
  {
    get { return destroyed; }
    set
    {
      destroyed = value;
      if (destroyed)
        GameObject.Destroy(modely);
    }
  }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              