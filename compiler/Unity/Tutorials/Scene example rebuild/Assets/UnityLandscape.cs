using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityLandscape : MonoBehaviour
{

  public static UnityLandscape Instantiate(Vector3 newPos, int numb)
  {
    GameObject landscape = GameObject.Instantiate(Resources.Load("Prefabs/Landscape" + numb), newPos, Quaternion.identity) as GameObject;
    UnityLandscape component = landscape.GetComponent<UnityLandscape>() as UnityLandscape;
    component.spawnp = new List<Transform>();
    component.streetl = new List<Casanova.Prelude.Tuple<Transform, int>>();

    Transform comps = landscape.transform;
    foreach (Transform child in comps)
    {
      if (child.tag == "Spawnpoint")
      {
        Transform toAdd = child.gameObject.GetComponent<Transform>();
        component.spawnp.Add(toAdd);
      }
      if (child.tag == "Streetlight")
      {
        Transform toAdd = child.gameObject.GetComponent<Transform>();
        string p = toAdd.gameObject.name.ToString();
        int j =  int.Parse(p.Substring(21));
        component.streetl.Add(new Casanova.Prelude.Tuple<Transform, int>(toAdd, j));
      }
    }
    return component;
  }
  private List<Transform> spawnp;
  public List<Transform> Spawnpoints2
  {
    get { return spawnp; }
  }
  private List<Casanova.Prelude.Tuple<Transform, int>> streetl;
  public List<Casanova.Prelude.Tuple<Transform, int>> Streetlights
  {
    get { return streetl; }
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
  public Vector3 Position
  {
    get { return this.transform.position; }
  }
  public Transform par
  {
    get { return this.gameObject.transform; }
  }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   