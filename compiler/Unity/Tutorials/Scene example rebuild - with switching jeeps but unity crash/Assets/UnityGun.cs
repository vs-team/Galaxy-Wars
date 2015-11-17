using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class UnityGun : MonoBehaviour {

  public TextMesh MagazineBox;
  public static UnityGun Instantiate(string nm)
  {
    GameObject dad = GameObject.Find("Gun") as GameObject;
    GameObject Weapon = GameObject.Instantiate(Resources.Load("Weapons/" + nm), Vector3.zero, Quaternion.identity) as GameObject;
    Weapon.transform.parent = dad.transform;
    UnityGun wap = dad.GetComponent<UnityGun>() as UnityGun;
    GameObject Bullet = GameObject.FindGameObjectWithTag("Bullets") as GameObject;
    Debug.Log(wap);
    Debug.Log(Bullet);
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
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      