using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityZombie : MonoBehaviour
{

    public static UnityZombie Instantiate(Vector3 pos)
    {
        var Zombie = GameObject.Instantiate(Resources.Load("Model/Zombie"), pos, Quaternion.identity) as GameObject;
        var zbie = Zombie.GetComponent<UnityZombie>();
        zbie.motor1 = Zombie.GetComponent<Animator>();
        return zbie;
    }
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
    get
    {
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
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    