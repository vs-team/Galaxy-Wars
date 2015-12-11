﻿using UnityEngine;
using System.Collections;

public class UnityBullet : MonoBehaviour {
  public Rigidbody Rbody;
  private Vector3 direct;

  public static UnityBullet Instantiate(Vector3 pos, string nm)
  {
    GameObject Weapon = GameObject.Instantiate(Resources.Load("Weapons/" + nm), pos, Quaternion.Euler(new Vector3(-90, 0, 0))) as GameObject;
    UnityBullet wap = Weapon.GetComponent<UnityBullet>() as UnityBullet;
    wap.Rbody = Weapon.GetComponent<Rigidbody>() as Rigidbody;
    return wap;
  }
  public Vector3 Frce
  {
    set
    {
      var xd = value.x;
      var yd = value.y;
      var zd = value.z;
      var vect = new Vector3(xd, yd,0.0f);
      Debug.Log(vect);
      Rbody.AddRelativeForce(vect * 40.0f, ForceMode.VelocityChange);
  }
  }
  void OnCollisionEnter(Collision coll)
  {
    ContactPoint contact = coll.contacts[0];
    var pos = contact.point;
    Debug.Log(coll.gameObject.name);
    if( coll.gameObject.name != "zpickup(Clone)")
    {
      GameObject expl = Instantiate(Resources.Load("Explosion03b"), this.transform.position, Quaternion.identity) as GameObject;
      Destroy(this.gameObject, 0.1f);
      Destroy(expl, 2.0f);

    }
  }
  void Update()
  {
    //Debug.Log(Rbody.transform.position);
  }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   