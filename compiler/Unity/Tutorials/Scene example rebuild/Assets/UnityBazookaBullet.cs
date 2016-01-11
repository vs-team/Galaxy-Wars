﻿using UnityEngine;
using System.Collections;

public class UnityBazookaBullet : MonoBehaviour {
  public Rigidbody Rbody;
  private Vector3 direct;


  public static UnityBazookaBullet Instantiate(Vector3 pos, string nm, float explosionforce, float explosionradius, float explosionupwardforce, float damage)
  {
    GameObject Weapon = GameObject.Instantiate(Resources.Load("Weapons/" + nm), pos, Quaternion.Euler(new Vector3(-90, 0, 0))) as GameObject;
    UnityBazookaBullet wap = Weapon.GetComponent<UnityBazookaBullet>() as UnityBazookaBullet;
    wap.Rbody = Weapon.GetComponent<Rigidbody>() as Rigidbody;
    wap.explosionForce = explosionforce;
    wap.explosionRadius = explosionradius;
    wap.explosionUpwardForce = explosionupwardforce;
    wap.gunPower = damage;
    Physics.IgnoreLayerCollision(wap.gameObject.layer,FindObjectOfType<TruckScript>().gameObject.layer); //Let the bazookabullet ignore the truck
    return wap;
  }
  public Vector3 Frce
  {
    set
    {
      Rbody.AddForce(value * 100.0f);
  }
  }
  void OnCollisionEnter(Collision coll)
  {
    Collider[] colliders = Physics.OverlapSphere(coll.transform.position, explosionRadius, 1 << 8/*zombie layermask*/);
    Debug.Log("Explosion hit " + colliders.Length + " colliders");

    foreach(Collider c in colliders)
    {
      Vector3 ImpactDirection = (c.transform.position - coll.transform.position).normalized;
      Debug.Log(Mathf.InverseLerp(explosionRadius, 0.0f, Vector3.Distance(c.transform.position, coll.transform.position)) * gunPower / 30.0f);
      float ImpactForce = Mathf.InverseLerp(explosionRadius, 0.0f, Vector3.Distance(c.transform.position, coll.transform.position)) * gunPower / 30.0f;
      c.GetComponentInParent<UnityZombie2>().GetShot(ImpactDirection, c.transform, c.GetComponent<Rigidbody>(), c, ImpactForce, false, 2);
      //c.GetComponent<Rigidbody>().AddExplosionForce(explosionForce, coll.transform.position, explosionRadius, explosionUpwardForce, ForceMode.Impulse);
    } 

    if (coll.gameObject.name != "zpickup(Clone)")
    {
      GameObject expl = Instantiate(Resources.Load("Explosion03b"), transform.position, Quaternion.identity) as GameObject;
      Destroy(expl, 2.0f);
      destroyed = true; //Field instead of setter to allow deconstruction in CNV
    }
  }
  private float explosionRadius;
  public float ExplosionRadius
  {
    get { return explosionRadius; }
    set { explosionRadius = value; }
  }
  private float explosionForce;
  public float ExplosionForce
  {
    get { return explosionForce; }
    set { explosionForce = value; }
  }
  private float explosionUpwardForce;
  public float ExplosionUpwardForce
  {
    get { return explosionUpwardForce; }
    set { explosionUpwardForce = value; }
  }
  private float gunPower;
  public float GunDamage
  {
    get { return gunPower; }
    set { gunPower = value; }
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