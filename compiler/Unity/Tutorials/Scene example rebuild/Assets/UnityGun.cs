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
    Debug.Log(tesla[0]);
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
  private float gunPower; //Used to determine the impactForce on ragdolls
  public float GunForce
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
        gunShot.Play();
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