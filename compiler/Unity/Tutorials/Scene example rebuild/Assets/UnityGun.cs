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
    return wap;
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
  private bool keyboard = false;
  public bool Keyboard
  {
    get { return keyboard; }
    set { keyboard = value; }
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
        // Shoot a ray from gun or mouse, check if zombie is present.
        RaycastHit hitObject; 
        int layermask = 1 << 8;
        if (keyboard)
        {
          Debug.Log("mouse shot");
          Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Create control option for choosing Mouse OR Razer, just like moving the car. Then implement the ray from either the mouse or razer.
          if (Physics.Raycast(ray, out hitObject, 100, layermask))
          {
            if (hitObject.collider.GetComponentInParent<UnityZombie2>())
            {
              UnityZombie2 hitZombie = hitObject.collider.GetComponentInParent<UnityZombie2>();
              Debug.Log("Zombie has been hit, namely:" + hitZombie);
              hitZombie.CollisionDirection = ray.direction;
              hitZombie.HitTransform = hitObject.transform;
              hitZombie.HitRigidbody = hitObject.rigidbody;
              hitZombie.HitCollider = hitObject.collider;
              hitZombie.Force = gunPower / 30.0f;
              hitZombie.CollidedWithCar = false;
              hitZombie.IsHitByForce = true;
            }
          }
          else
            Debug.Log("Nothing has been hit");
        }
        else
        {
          Debug.Log("razer shot");
          Vector3 razerDirection = GetComponentInParent<SixenseHand>().transform.forward;
          if (Physics.Raycast(transform.position, razerDirection, out hitObject, 100.0f, layermask))
          {
            if (hitObject.collider.GetComponentInParent<UnityZombie2>())
            {
              UnityZombie2 hitZombie = hitObject.collider.GetComponentInParent<UnityZombie2>();
              Debug.Log("Position of collision: " + hitObject.point);
              Debug.Log("Zombie has been hit, namely:" + hitZombie.transform);
              hitZombie.CollisionDirection = razerDirection;
              hitZombie.HitTransform = hitObject.transform;
              hitZombie.HitRigidbody = hitObject.rigidbody;
              hitZombie.HitCollider = hitObject.collider;
              Debug.Log("Force: " + gunPower / 30.0f);
              hitZombie.Force = gunPower / 30.0f;
              hitZombie.CollidedWithCar = false;
              hitZombie.IsHitByForce = true;
            }
          }
          else
          {
            Debug.Log("Position of collision: " + hitObject.point);
            Debug.Log("Nothing has been hit");
          }

        }
      }
    }
  }
  public Vector3 Position
  {
    get {
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
    get {
      return this.transform.localEulerAngles; }
    set {
      this.transform.rotation = this.transform.rotation;
    }
  }

}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     