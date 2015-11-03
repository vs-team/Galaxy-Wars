using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityZombie : MonoBehaviour
{

  public static UnityZombie Find(Transform a)
  {
    var zmbies_group = a.GetComponent<UnityZombie>();
    zmbies_group.motor1 = a.GetComponent<Animator>();
    return zmbies_group;
  }

  private Animator motor1;

  public bool shot
  {
    get
    {
      //Debug.Log("get");
      return motor1.GetBool("shot");
    }
    set
    {
      //Debug.Log("set" + value);
      motor1.SetBool("shot", value);
    }
  }
  public bool dead2
  {
    get
    {
      //Debug.Log("get");
      return motor1.GetBool("dead2");
    }
    set
    {
      //Debug.Log("set" + value);
      motor1.SetBool("dead2", value);
    }

  }
  bool destroyed;
    public bool Destroyed
    {
        get { return destroyed; }
        set
        {
            destroyed = value;
            if (destroyed)
                GameObject.Destroy(gameObject);
        }
    }

  public bool OnMouseOver
  {
    get { 
      RaycastHit hit;
      var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      int layermask = 1 << 8;
      if (Physics.Raycast(ray, out hit, 100, layermask))
      {
        if (this.gameObject == hit.collider.gameObject)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
      else
        return false;
    }
  }
  public Vector3 Position
  {
    get { return this.transform.position; }
  }
  public bool IsHit
  {
    get
    {
      GameObject controller = GameObject.Find("truck/Input/RazerJoysticks/Hydra1 - Right");
      RaycastHit hitObject;
      Physics.Raycast(controller.transform.position, controller.transform.forward, out hitObject, 100.0f, 256);
      return (Physics.Raycast(controller.transform.position, controller.transform.forward, out hitObject, 100.0f, 256) &&
             (hitObject.transform.gameObject == this.gameObject));
    }
  }

}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               