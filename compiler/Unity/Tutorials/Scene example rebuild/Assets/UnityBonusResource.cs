﻿using UnityEngine;
using System.Collections;

public class UnityBonusResource : MonoBehaviour {
  public static UnityBonusResource Instantiate(Vector3 pos, string a)
  {
    GameObject Bonus = GameObject.Instantiate(Resources.Load("PowerUps/Prefabs/" + a), pos, Quaternion.identity) as GameObject;
    UnityBonusResource comp = Bonus.GetComponent<UnityBonusResource>() as UnityBonusResource;
    comp.cols = false;
    return comp;
  }
  private bool cols;
  public bool collids
  {
    get { return cols; }
    set { cols = value; }
  }
  void OnTriggerEnter(Collider other)
  {
    if (other.name == "Jeep_KM_body")
    {
      Debug.Log("Collision with truck");
      cols = true;
    }
  }
  bool destroyed;
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
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  