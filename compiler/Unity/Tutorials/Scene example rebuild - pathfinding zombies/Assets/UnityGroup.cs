﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class UnityGroup : MonoBehaviour {

  public static UnityGroup Instantiate(Vector3 pos)
  {
    GameObject zmbies = GameObject.Instantiate(Resources.Load("Model/Zombiegroup6"), pos, Quaternion.identity) as GameObject;
    UnityGroup comp = zmbies.GetComponent<UnityGroup>() as UnityGroup;
    comp.private_U_ZombieLeader = zmbies.transform.FindChild("ZombieLeader").GetComponent<Transform>() as Transform;
    comp.private_U_Zombies = new List<Transform>();
    Transform comps = zmbies.transform;
    foreach (Transform child in comps)
    {
      if (child.tag == "Zombie")
      {
        Transform toAdd = child.gameObject.GetComponent<Transform>();
        comp.private_U_Zombies.Add(toAdd);
      }
    }
    return comp;
  }
  private Transform private_U_ZombieLeader;
  public Transform U_ZombieLeader
  {
    get { return private_U_ZombieLeader; }
  }
  private List<Transform> private_U_Zombies;
  public List<Transform> U_Zombies
  {
    get { return private_U_Zombies; }
  }

}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 