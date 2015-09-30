using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityLandscape : MonoBehaviour {

    public static UnityLandscape Instantiate(Vector3 newPos)
  {
    GameObject landscape = GameObject.Instantiate(Resources.Load("Prefabs/Landscape1"),newPos, Quaternion.identity) as GameObject;
    UnityLandscape component = landscape.GetComponent<UnityLandscape>() as UnityLandscape;
    return component;
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