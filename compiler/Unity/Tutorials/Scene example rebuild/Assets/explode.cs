using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class explode : MonoBehaviour
{
  public GameObject explosionEffect;
  public Transform explosionEffectLocation;
  private AudioSource audios;
  public AudioClip explo;
  private GameObject z;

  public static explode instantiate(Vector3 v, int a)
  {
    GameObject bom = GameObject.Instantiate(Resources.Load("Prefabs/barrel-" + a), v, Quaternion.Euler(new Vector3(90,0,0))) as GameObject;
    explode b = bom.GetComponent<explode>();
    b.audios = bom.GetComponent<AudioSource>();
    return b;
  }
  private bool destroyed;
  public bool Destroyed
  {
    get { return destroyed; }
    set
    {
      if (value)
      {
        GameObject.Destroy(gameObject);
        destroyed = true;
      }
    }
  }
  bool isHit_p;
  public bool isHit
  {
    get { return isHit_p; }
    set { isHit_p = value; }
  }

  void Update()
  {
    if(Explode)
    {

    }
  }

  private bool explosion;
  float explosionRadius = 15.0f;
  public bool Explode
  {
    get { return explosion; }
    set
    {
      z = GameObject.Instantiate(explosionEffect, explosionEffectLocation.position, Quaternion.LookRotation(Vector3.up)) as GameObject;
      z.GetComponent<AudioSource>().Play();
      explosion = value;
      Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius, 1 << 8/*zombie layermask*/);

      foreach (Collider c in colliders)
      {
        Vector3 ImpactDirection = (c.transform.position - transform.position).normalized;
        float ImpactForce = Mathf.InverseLerp(explosionRadius, 0.0f, Vector3.Distance(c.transform.position, transform.position));
        Debug.Log(ImpactForce);
        c.GetComponentInParent<UnityZombie2>().GetHit(ImpactDirection, c.transform, c.GetComponent<Rigidbody>(), c, ImpactForce, true, 1);
      }

    }
  }

}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     