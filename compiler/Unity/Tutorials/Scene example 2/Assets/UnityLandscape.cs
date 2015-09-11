using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityLandscape : MonoBehaviour {

  private UnityCheckpoint check;

  public UnityCheckpoint Checkpoint { get { return check; } }
  public static UnityLandscape Instantiate(Vector3 newPos)
  {
    GameObject landscape = GameObject.Instantiate(Resources.Load("Prefabs/Landscape_01"),newPos, Quaternion.identity) as GameObject;
    UnityLandscape component = landscape.GetComponent<UnityLandscape>() as UnityLandscape;
    component.check = landscape.transform.FindChild("Checkpoint").GetComponent<UnityCheckpoint>();
    return component;
  }


  public Vector3 Position
  {
    get { return this.transform.position; }
    set { this.transform.position = value; }
  }

  private bool destroyed;
  public bool Destroyed
  {
    get { return destroyed; }
    set
    {
      destroyed = value;
      if (destroyed)
        GameObject.Destroy(gameObject);
    }
  }
}                                                                                                                                                                                              