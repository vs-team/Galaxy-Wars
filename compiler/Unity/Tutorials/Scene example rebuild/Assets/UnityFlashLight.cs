using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityFlashLight : MonoBehaviour
{


  public static UnityFlashLight Find(string j)
  {
    Debug.Log(j);
    GameObject a = GameObject.Find(j + "/flashlight");
    Debug.Log(a.name);
    UnityFlashLight b = a.GetComponent<UnityFlashLight>() as UnityFlashLight;

    //textmesh
    Transform c = a.GetComponent<Transform>();
    List<TextMesh> tesla = new List<TextMesh>();

    foreach (Transform z in c)
    {
      if (z.name == "Canvas")
      {
        TextMesh bat = z.GetComponentInChildren<TextMesh>() as TextMesh;
        tesla.Add(bat);
      }
    }
    b.BatteryMesh = tesla[0];
    return b;
  }
  public TextMesh BatteryMesh;
  public string BatteryGui
  {
    get { return BatteryMesh.text; }
    set
    {
      if (value.Length > 3)
      {
        var x = value.Substring(0, 4);
        BatteryMesh.text = x + "% left";
      }
    }
  }
}
                                                                                                         