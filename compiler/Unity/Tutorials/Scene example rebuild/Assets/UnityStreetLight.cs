using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityStreetLight : MonoBehaviour {
  private Light li;
	public static UnityStreetLight instantiate(Transform q)
  {
    GameObject a = GameObject.Instantiate(Resources.Load("Landscape/Urban_Props/Streetlight_With_light"), q.position, Quaternion.identity) as GameObject;
    UnityStreetLight z = a.GetComponent<UnityStreetLight>();
    z.li = a.GetComponentInChildren<Light>();
    return z;
  }

  public bool Lamp
  {
    get { return li.enabled; }
    set { li.enabled = value; }
  }
}
                                                                                                                                                                                                                                                                                               