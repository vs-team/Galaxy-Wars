using UnityEngine;
using System.Collections;

public class UnityCheckpoint : MonoBehaviour
{

  public static UnityCheckpoint Find()
  {
    Vector3 v = Vector3.zero;
    GameObject c = GameObject.Instantiate(Resources.Load("Prefabs/Empty"), v, Quaternion.identity) as GameObject;
    GameObject d = GameObject.Find("Repair_Zone");
    Vector3 e = d.transform.localPosition + new Vector3(0.0f, 0.0f, d.transform.parent.position.z);
    c.transform.position = c.transform.TransformPoint(e);
    UnityCheckpoint b = c.GetComponent<UnityCheckpoint>() as UnityCheckpoint;
    return b;
  }
  void Update()
  {
    if (tex == null)
      tex = GameObject.FindGameObjectWithTag("Trucks").transform.FindChild("Main Camera/Minigame").GetComponent<TextMesh>();
  }
  public TextMesh tex;
  public float Show
  {
    get
    {
      float x = float.Parse(tex.text.Substring(0, 2));
      if (x > 0)
        return x;
      else
        return 0.0f;
    }
    set
    {
      if (value > 0.0f)
      {
        tex.gameObject.SetActive(true);
        Debug.Log("new value");
        int j = (int)value;
        if (j > 0)
          tex.text = j + " %";
        else 
          tex.text = "";
      }
      else
        tex.gameObject.SetActive(false);
    }
  }

  void OnTriggerEnter(Collider other)
  {
    var x = other.transform.root.gameObject.tag;
    if (x == "Trucks")
    {
      privateIsEntered = true;
    }
  }
  void OnTriggerExit(Collider other)
  {
    var x = other.transform.root.gameObject.tag;
    if (x == "Trucks")
    {
      privateIsEntered = false;
    }
  }
  private bool privateIsEntered;
  public bool isEntered
  {
    get { return privateIsEntered; }
  }
  bool destroyed;

  public bool Destroyed
  {
    get { return destroyed; }
    set
    {
      destroyed = value;
      if (destroyed)
        GameObject.Destroy(GameObject.FindGameObjectWithTag("UnityCheckp") as GameObject);
    }
  }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      