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
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Create control option for choosing Mouse OR Razer, just like moving the car. Then implement the ray from either the mouse or razer.
        RaycastHit hit; 
        int layermask = 1 << 8;
        if (Physics.Raycast(ray, out hit, 100, layermask))
        {
          if (hit.collider.GetComponentInParent<UnityZombie2>())
          {
            UnityZombie2 hitZombie = hit.collider.GetComponentInParent<UnityZombie2>();
            Debug.Log("Zombie has been hit, namely:" + hitZombie);
            hitZombie.CollisionDirection = ray.direction;
            hitZombie.HitTransform = hit.transform;
            hitZombie.HitRigidbody = hit.rigidbody;
            hitZombie.HitCollider = hit.collider;
            hitZombie.Force = gunPower / 30.0f;
            hitZombie.CollidedWithCar = false;
            hitZombie.IsHitByForce = true;
          }
          else
          {
            Debug.Log("Ray has collided with: " + hit.collider);
          }
        }
        else
          Debug.Log("Nothing has been hit");
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