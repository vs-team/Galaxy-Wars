using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class UnityGun : MonoBehaviour
{
  public TextMesh MagazineBox;
  private AudioSource gunShot;

  public static UnityGun Instantiate(string nm)
  {
    GameObject dad = GameObject.FindWithTag("Gun") as GameObject;
    UnityGun wap = dad.GetComponent<UnityGun>() as UnityGun;
    GameObject Bullet = GameObject.FindGameObjectWithTag("Bullets") as GameObject;
    TextMesh tesla = Bullet.GetComponent<TextMesh>() as TextMesh;
    wap.MagazineBox = tesla;
    wap.gunShot = dad.GetComponent<AudioSource>() as AudioSource;
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
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    