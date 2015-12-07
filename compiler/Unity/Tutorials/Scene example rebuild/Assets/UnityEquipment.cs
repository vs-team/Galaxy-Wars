using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System;

public class UnityEquipment : MonoBehaviour {

  public List<string> HR;
  public List<string> HL;
  public Transform TransformHR;
  public Transform TransformHL;
  public Transform flashL; 
  public Transform flashR; 

  public static UnityEquipment Instantiate()
  {
    Transform a = GameObject.Find("Input").GetComponent<Transform>() as Transform;
    UnityEquipment equip = a.GetComponent<UnityEquipment>() as UnityEquipment;
    Debug.Log(equip);

    equip.HR = new List<string>();
    equip.HL = new List<string>();
    equip.TransformHR = GameObject.Find("Hydra1 - Right").GetComponent<Transform>();
    foreach (Transform b in equip.TransformHR)
    {
      if (b.tag == ("Gun"))
      {
        equip.HR.Add(b.name);
      }
      if(b.name == "flashlight")
      {
        equip.flashR = b.gameObject.transform;
      }
    }
    Debug.Log("HR add" + equip.HR.Count);

    equip.TransformHL = GameObject.Find("Hydra1 - Left").GetComponent<Transform>();
    foreach (Transform b in equip.TransformHL)
    {
      if (b.tag == ("Gun"))
      {
        equip.HL.Add(b.name);
      }
      if (b.name == "flashlight")
      {
        equip.flashL = b.gameObject.transform;
      }
    }
    Debug.Log("HR add" + equip.HL.Count);


    return equip;
  }
  private List<bool> bools;
  public List<bool> sap
  {
    set
    {
      List<bool> bools = value;
      bool R = bools[0];
      bool L = bools[1];
      flashR.gameObject.SetActive(R);
      flashL.gameObject.SetActive(L);
    }
  }
  public List<string> asdf
  {
    set
    {
      foreach (Transform p in TransformHL)
      {
        p.gameObject.SetActive(true);
      }
      foreach (Transform p in TransformHR)
      {
        p.gameObject.SetActive(true);
      }
      foreach (string a in value) // value is a list of strings
      {
        string q = (a.Substring(7, 1));
        int ind = Int32.Parse(q);
        var side = a.Substring(29,4);


        if (side.Contains("Left"))
        {
          //Debug.Log("left " + ind);
          var p = HL[ind]; // list all guns left
          Transform z = TransformHL.Find(p);
          z.gameObject.SetActive(false);
        }
        else
        {
            //Debug.Log("right " + ind);
            var p = HR[ind]; // list all guns left
            Transform z = TransformHR.Find(p);
            z.gameObject.SetActive(false);
        }


      }
    }
  }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            