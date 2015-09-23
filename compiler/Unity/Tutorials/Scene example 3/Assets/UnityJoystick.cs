using UnityEngine;
using System.Collections;

public class UnityJoystick : MonoBehaviour {


  void Update()
  {

    //Vector2 Dpad = new Vector2(Input.GetAxis("SW_DPad_X"), Input.GetAxis("SW_DPad_Y"));
    //Debug.Log(Dpad);
    Debug.Log("XXXX" + Input.GetAxis("SW_Joy0X"));
    Debug.Log("YYYY" + Input.GetAxis("SW_Joy0Y"));
    Debug.Log("VERT" + Input.GetAxis("SW_DPad_X"));
    Debug.Log("HORI" + Input.GetAxis("SW_Joy0F"));


    /*Debug.Log("Button1 " + Input.GetButtonDown("SW_Button1"));
    Debug.Log("Button2 " + Input.GetButtonDown("SW_Button2"));
    Debug.Log("Button3 " + Input.GetButtonDown("SW_Button3"));
    Debug.Log("Button4 " + Input.GetButtonDown("SW_Button4"));
    Debug.Log("Button5 " + Input.GetButtonDown("SW_Button5"));
    Debug.Log("Button6 " + Input.GetButtonDown("SW_Button6"));
    Debug.Log("Button7 " + Input.GetButtonDown("SW_Button7"));
    Debug.Log("Button8 " + Input.GetButtonDown("SW_Button8"));
    Debug.Log("Button9 " + Input.GetButtonDown("SW_Button9"));
    Debug.Log("Button10 " + Input.GetButtonDown("SW_Button10"));
    Debug.Log("Button11 " + Input.GetButtonDown("SW_Button11"));
    Debug.Log("Button12 " + Input.GetButtonDown("SW_Button12"));*/
  }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          