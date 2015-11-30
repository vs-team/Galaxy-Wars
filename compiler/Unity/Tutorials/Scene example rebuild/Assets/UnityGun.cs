using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class UnityGun : MonoBehaviour
{
  public TextMesh MagazineBox;
  private AudioSource gunShot;
  public Transform SixHandTF;
  private Transform GunTsf;

  public static UnityGun Instantiate(string nm)
  {
    GameObject pap = GameObject.FindWithTag("Gun") as GameObject;
    UnityGun wap = pap.GetComponent<UnityGun>() as UnityGun;

    // pos GunTransform && Hydra Transform
    wap.SixHandTF = GameObject.Find("Hydra1 - Right").GetComponent<Transform>() as Transform;
    wap.GunTsf = GameObject.Find("Gun").GetComponent<Transform>() as Transform;

    //textmesh
    GameObject Bullet = GameObject.FindGameObjectWithTag("Bullets") as GameObject;
    TextMesh tesla = Bullet.GetComponent<TextMesh>() as TextMesh;
    wap.MagazineBox = tesla;

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
      Debug.Log("insideGunForceSet gunForce: " + value);
      gunPower = value;
    }
  }
  public Vector3 directio;
  public Vector3 WorldPos;
  private bool shot;
  public bool Shoot
  {
    get { return shot; }
    set
    {
      directio = SixHandTF.forward;
      WorldPos = this.transform.TransformPoint(this.transform.position);
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
      //Debug.Log("SixHandTF.position" + SixHandTF.position);
      var x = new Vector3(SixHandTF.position.x, SixHandTF.position.y + 1.7f, SixHandTF.position.z-1.9f);
      this.transform.localPosition = x;
  }
}                                                      
  public Vector3 Rotation
  {
    get {
      return this.transform.localEulerAngles; }
    set {
      this.transform.rotation = SixHandTF.rotation;
    }
  }

}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   