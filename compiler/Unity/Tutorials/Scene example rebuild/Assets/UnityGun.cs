using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class UnityGun : MonoBehaviour
{
  public TextMesh MagazineBox;
  private AudioSource gunShot;
  public static UnityGun Instantiate(string nm, string j)
  {
    GameObject pap = GameObject.Find("Input/RazerJoysticks/" + j + "/" + nm) as GameObject;
    UnityGun wap = pap.GetComponent<UnityGun>() as UnityGun;
    wap.razer = wap.GetComponentInParent<SixenseHand>();

    //textmesh
    Transform a = pap.GetComponent<Transform>();
    List<TextMesh> tesla = new List<TextMesh>();
    foreach (Transform z in a)
    {
      if (z.name == "Canvas")
      {
        TextMesh Bullet = z.GetComponentInChildren<TextMesh>() as TextMesh;
        tesla.Add(Bullet);
      }
    }
    wap.MagazineBox = tesla[0];

    wap.gunShot = pap.GetComponent<AudioSource>() as AudioSource;

    GameObject inp = GameObject.Find("Input");
    wap.Ammo = inp.GetComponent<AudioSource>() as AudioSource;

    return wap;
  }
  private bool OutofAmmoSound;
  private bool ReloadSound;

  public AudioClip ammo;
  public AudioClip Reloader;

  private AudioSource Ammo;

  public bool Rel
  {
    get { return ReloadSound; }
    set
    {
      if (value)
      {
        Ammo.clip = ammo;
        Ammo.Play();
      }
      ReloadSound = value;
    }
  }

  public bool OoAs
  {
    get { return OutofAmmoSound; }
    set
    {
      if (value)
      {
        Ammo.clip = Reloader;
        Ammo.Play();
      }
      OutofAmmoSound = value;
    }
  }
  private SixenseHand razer;
  public SixenseHand Razer
  {
    get { return razer; }
    set { razer = value; }
  }
  private int InTheMag;
  public int InMag
  {
    get { return InTheMag; }
    set { InTheMag = value; }
  }
  private int NotInTheMag;
  public int NotInMag
  {
    get { return NotInTheMag; }
    set { NotInTheMag = value; }
  }
  public string MagazineGUI
  {
    get { return MagazineBox.text; }
    set
    {
      MagazineBox.text = InTheMag + "/" + NotInTheMag;
    }
  }
  private bool keyboardShooting = false;
  public bool KeyboardShooting
  {
    get { return keyboardShooting; }
    set { keyboardShooting = value; }
  }
  private float gunPower; //Used for damage and impactforce
  public float GunDamage
  {
    get
    {
      return gunPower;
    }
    set
    {
      //Debug.Log("insideGunForceSet gunForce: " + value);
      gunPower = value;
    }
  }
  private bool shot;
  public bool Shoot
  {
    get { return shot; }
    set
    {
      shot = value;
      if (shot)
      {
        gunShot.Play();

        RaycastHit hitObject; 
        int layermask = 1 << 8; //Layermask of zombies
        if (keyboardShooting && name != "Bazooka")
        {
          Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
          if (Physics.Raycast(ray, out hitObject, 100, layermask))
          {
            if (hitObject.collider.GetComponentInParent<UnityZombie2>())
            {
              GameObject bloodFX = Instantiate(Resources.Load("Blood"), hitObject.transform.position, Quaternion.FromToRotation(Vector3.zero,ray.direction)) as GameObject;
              ParticleSystem bloodPS = bloodFX.GetComponentInChildren<ParticleSystem>();
              Destroy(bloodFX, bloodPS.duration);
              hitObject.collider.GetComponentInParent<UnityZombie2>().GetHit(ray.direction, hitObject.transform, hitObject.rigidbody, 
                                                                              hitObject.collider, gunPower / 30.0f, false, 2);
            }
            else if(hitObject.collider.tag == "Barrels")
            {
              Debug.Log("Hit barrel");
              hitObject.rigidbody.AddForce(ray.direction * gunPower);
            }
          }
          else
            Debug.Log("No zombie hit by mouse");
        }
        else if (!keyboardShooting && name != "Bazooka")
        {
          Vector3 razerDirection = razer.transform.forward;
          if (Physics.Raycast(transform.position, razerDirection, out hitObject, 100.0f, layermask))
          {
            if (hitObject.collider.GetComponentInParent<UnityZombie2>())
            {
              GameObject bloodFX = Instantiate(Resources.Load("Blood"), hitObject.transform.position, Quaternion.identity) as GameObject;
              ParticleSystem bloodPS = bloodFX.GetComponentInChildren<ParticleSystem>();
              Destroy(bloodFX, bloodPS.duration);
              hitObject.collider.GetComponentInParent<UnityZombie2>().GetHit(razerDirection, hitObject.transform, hitObject.rigidbody, 
                                                                              hitObject.collider, (gunPower / 30.0f), false, 2);
            }
            else if(hitObject.collider.tag == "Barrels")
            {
              hitObject.rigidbody.AddForce(razerDirection * gunPower);
            }
          }
        }
        layermask = 1 << 11; //Layermask of barrel
        if (keyboardShooting)
        {
          Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
          if (Physics.Raycast(ray, out hitObject, 100, layermask))
          {
            if (hitObject.collider.GetComponent<explode>())
            {
              hitObject.collider.GetComponent<explode>().isHit = true;
              Debug.Log("a barrel has been hit");
            }
          }
        }
        else if (!keyboardShooting)
        {
          Vector3 razerDirection = razer.transform.forward;
          if(Physics.Raycast(transform.position, razerDirection, out hitObject, 100.0f, layermask))
          {
            if (hitObject.collider.GetComponent<explode>())
            {
              hitObject.collider.GetComponent<explode>().isHit = true;
              Debug.Log("a barrel has been hit");
            }
          }
        }
      }
    }
  }
  public Vector3 Position
  {
    get
    {
      return this.transform.localPosition;
    }
    set
    {
      var x = this.transform.localPosition;
      this.transform.localPosition = x;
  }
}                                                      
  public Vector3 Rotation
  {
    get
    {
      return this.transform.localEulerAngles;
    }
    set
    {
      this.transform.rotation = this.transform.rotation;
    }
  }

}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    