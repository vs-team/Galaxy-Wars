using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityStreetLight : MonoBehaviour
{
  private Light li;
  public static UnityStreetLight instantiate(Transform q, float LeftSide, Transform par)
  {
    GameObject a = GameObject.Instantiate(Resources.Load("Landscape/Urban_Props/Streetlight_With_light"), q.position, Quaternion.Euler(0,LeftSide,0)) as GameObject;
    a.transform.parent = par;
    UnityStreetLight z = a.GetComponent<UnityStreetLight>();
    z.li = a.GetComponentInChildren<Light>();
    return z;
  }

  public bool Lamp
  {
    get { return li.enabled; }
    set { li.enabled = value; }
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
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             