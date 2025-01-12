﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityLandscape : MonoBehaviour {

  public static UnityLandscape Instantiate(Vector3 newPos, int numb)
  {
    GameObject landscape = GameObject.Instantiate(Resources.Load("Prefabs/Landscape"+ numb),newPos, Quaternion.identity) as GameObject;
    UnityLandscape component = landscape.GetComponent<UnityLandscape>() as UnityLandscape;
    component.check = landscape.transform.FindChild("Checkpoint").GetComponent<UnityCheckpoint>();
    component.spawnp = new List<Transform>();
        Transform comps = landscape.transform;
        foreach (Transform child in comps)
        {
            if (child.tag == "Spawnpoint")
            {
                Transform toAdd = child.gameObject.GetComponent<Transform>();
                component.spawnp.Add(toAdd);
            }
        }
        return component;
  }
    private List<Transform> spawnp;
    public List<Transform> Spawnpoints2
    {
        get { return spawnp; }
    }

  private UnityCheckpoint check;
  public UnityCheckpoint Checkpoint { get { return check; } }

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
  public Vector3 Position
  {
    get { return this.transform.position; }
  }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              