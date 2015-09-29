﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityLandscape : MonoBehaviour {

  private UnityCheckpoint check;

  public UnityCheckpoint Checkpoint { get { return check; } }

  //spawnpoints
  private List<Transform> spawnp;
  public List<Transform> randr(List<Transform> a)
  {
    for (int i = 0; i < a.Count; i++)
    {
      Transform temp = a[i];
      int randomIndex = Random.Range(i, a.Count);
      a[i] = a[randomIndex];
      a[randomIndex] = temp;

    }
    return spawnp;
  }
    
    public List<Transform> Spawnpoints2
    {
        get { return randr(spawnp); }
    }




    // landscape prefabs
    private static List<GameObject> myListObjects = new List<GameObject>();
    public List<GameObject> prefabs(List<GameObject> a)
    {
        for (int i = 0; i < a.Count; i++)
        {
            GameObject temp = a[i];
            int randomIndex = Random.Range(i, a.Count);
            a[i] = a[randomIndex];
            a[randomIndex] = temp;

        }
        return myListObjects;
    }

    void Start()
    {
        if (myListObjects.Count == 0)
        {
            Object[] subListObjects = Resources.LoadAll("Prefabs", typeof(GameObject));
            foreach (GameObject subListObject in subListObjects)
            {
                GameObject lo = (GameObject)subListObject;
                //Debug.Log("prefabs " + subListObject.name);
                myListObjects.Add(lo);
            }
        }
        else
        {
            int x = 1;
            foreach (GameObject a in myListObjects)
            {
                //Debug.Log("Prefab nr " + x + " = " + a.name);
                x++;
            }
        }

    }
    public List<GameObject> LandscapePrefabs
    {
        get { return prefabs(myListObjects); }
    }





    public static UnityLandscape Instantiate(Vector3 newPos, string p)
  {
    GameObject landscape = GameObject.Instantiate(Resources.Load("Prefabs/"+p),newPos, Quaternion.identity) as GameObject;
    UnityLandscape component = landscape.GetComponent<UnityLandscape>() as UnityLandscape;
    component.check = landscape.transform.FindChild("Checkpoint").GetComponent<UnityCheckpoint>();
    component.spawnp = new List<Transform>();
    Transform comps = landscape.transform;
    foreach (Transform child in comps)
    {
      //Debug.Log("Child");
      if (child.tag == "Spawnpoint")
      {
        Transform toAdd = child.gameObject.GetComponent<Transform>();
        //Debug.Log("spawnpoints " + child);
        component.spawnp.Add(toAdd);
        //Counter++;
      }
    }
    /*
    if (Counter < 1)
    {
        Debug.Log("No spawnpoints found in this landscape");
    }
    */
    return component;
  }


  public Vector3 Position
  {
    get { return this.transform.position; }
    set { this.transform.position = value; }
  }

  public Vector3 LocPosition
  {
    get { return this.transform.TransformPoint(this.transform.position); }
    set { this.transform.TransformPoint(value); }
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