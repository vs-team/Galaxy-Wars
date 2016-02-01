using UnityEngine;
using System.Collections.Generic;
using System;

public class UnityEquipment : MonoBehaviour
{

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

    equip.HR = new List<string>();
    equip.HL = new List<string>();
    equip.TransformHR = GameObject.Find("Hydra1 - Right").GetComponent<Transform>();
    foreach (Transform b in equip.TransformHR)
    {
      if (b.tag == ("Gun"))
      {
        equip.HR.Add(b.name);
      }
      if (b.name == "flashlight")
      {
        equip.flashR = b.gameObject.transform;
      }
    }

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
    equip.ammos = new List<Casanova.Prelude.Tuple<int, int>>();
    for (int j = 0; j < equip.HR.Count; j++)
    {
      if (j == 0)
      {
        equip.ammos.Add(new Casanova.Prelude.Tuple<int, int>(50, 850));
      }
      if (j == 1)
      {
        equip.ammos.Add(new Casanova.Prelude.Tuple<int, int>(20, 200));
      }
      if (j == 2)
      {
        equip.ammos.Add(new Casanova.Prelude.Tuple<int, int>(5, 60));
      }
      if (j == 3)
      {
        equip.ammos.Add(new Casanova.Prelude.Tuple<int, int>(0, 25));
      }

    }


    return equip;
  }

  private List<Casanova.Prelude.Tuple<int, int>> ammos;
  public List<Casanova.Prelude.Tuple<int, int>> Ammos
  {
    get { return ammos; }
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
      if (value[0] == "")
      {
        return;
      }
      foreach (string a in value) // value is a list of strings
      {
        string q = (a.Substring(7, 1));
        int ind = Int32.Parse(q);
        var side = a.Substring(29, 4);

        if (side.Contains("Left"))
        {
          var p = HL[ind];
          Transform z = TransformHL.Find(p);
          z.gameObject.SetActive(false);
        }
        else
        {
          var p = HR[ind];
          Transform z = TransformHR.Find(p);
          z.gameObject.SetActive(false);
        }
      }
    }
  }
  public Vector3 Position
  {
    get { return transform.localPosition; }
    set { transform.localPosition = value; }
  }
}                                                                                                                                                                                                                                                                                                                                                                                                                                        