using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityFlashLight : MonoBehaviour
{
  public static UnityFlashLight Find(string j)
  {
    GameObject a = GameObject.Find(j + "/flashlight");
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
    b.Flight = a.GetComponentInChildren<Light>();
    return b;
  }
  private Light Flight;
  public TextMesh BatteryMesh;
  public string BatteryGui
  {
    get { return BatteryMesh.text; }
    set
    {
      if (value.Length > 1)
      {
        var x = value.Substring(0, 3);
        if("100" == x)
        {
          BatteryMesh.text = x + "% left";
        }
        else
        {
          var y = value.Substring(0, 2);
          BatteryMesh.text = y + "% left";
        }
      }
    }
  }

  public bool Lamp
  {
    get { return Flight.enabled; }
    set { Flight.enabled = value; }
  }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           