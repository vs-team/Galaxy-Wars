using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class UnityGun : MonoBehaviour {
  private Quaternion BazookaRot = Quaternion.Euler(new Vector3(0, 180, 0));
  public TextMesh MagazineBox;
  public static UnityGun Instantiate(string nm)
  {
    GameObject dad = GameObject.Find("Gun") as GameObject;
    GameObject Weapon = GameObject.Instantiate(Resources.Load("Weapons/" + nm), dad.transform.position, Quaternion.Euler(new Vector3(0, 180, 0))) as GameObject;
    UnityGun wap = dad.GetComponent<UnityGun>() as UnityGun;
    GameObject Bullet = GameObject.FindGameObjectWithTag("Bullets") as GameObject;
    TextMesh tesla = Bullet.GetComponent<TextMesh>() as TextMesh;
    wap.MagazineBox = tesla;
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
  public Vector3 Position
  {
    get {
      Debug.Log("transform pos unitygun" + this.transform.position);
      return this.transform.position; }
  }
  public Vector3 Rotation
  {
    get {
      return BazookaRot.eulerAngles; }
  }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          