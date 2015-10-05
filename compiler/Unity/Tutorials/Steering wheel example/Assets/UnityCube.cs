using UnityEngine;
using System.Collections;

public class UnityCube : MonoBehaviour {

  public Vector3 Rotation
  {
    get { return this.transform.eulerAngles; }
    set { this.transform.eulerAngles = value; } 
  }

  public float Steering
  {
    get { return Input.GetAxis("SW_Joy0X"); }
  }


  
  public static UnityCube Find()
  {
    GameObject var = GameObject.Find("Cube1");
    return var.GetComponent<UnityCube>();
  }
}                                                                                                                                                                                                                               