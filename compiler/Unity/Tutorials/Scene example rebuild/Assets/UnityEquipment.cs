using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityEquipment : MonoBehaviour {

  public List<string> HR;
  public List<string> HL;
  public Transform TransformHR;
  public Transform TransformHL;

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
    }
    Debug.Log("HR add" + equip.HR.Count);

    equip.TransformHL = GameObject.Find("Hydra1 - Left").GetComponent<Transform>();
    foreach (Transform b in equip.TransformHL)
    {
      if (b.tag == ("Gun"))
      {
        equip.HL.Add(b.name);
      }
    }
    Debug.Log("HR add" + equip.HL.Count);


    return equip;
  }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            