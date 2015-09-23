using UnityEngine;
using System.Collections;

public class UnityZombie : MonoBehaviour
{

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

  public bool collision
  {
    get
    {
      //Debug.Log("get");
      return motor1.GetBool("collision");
    }
    set
    {
      //Debug.Log("set" + value);
      motor1.SetBool("collision",value);
    }
  }

    public static UnityZombie Instantiate(Vector3 pos)
    {
        var Zombie = GameObject.Instantiate(Resources.Load("Model/Zombie"), pos, Quaternion.identity) as GameObject;
        var zbie = Zombie.GetComponent<UnityZombie>();
        zbie.motor1 = Zombie.GetComponent<Animator>();
        return zbie;
    }

    public Vector3 targeta;
    public Vector3 currenta;
    public float speed;

    public Vector3 Position
    {
        get { return gameObject.transform.position; }
        set
        {
            transform.position = Vector3.MoveTowards(currenta, targeta, speed);
        }

    }
    public Quaternion Rotation
    {
        get { return gameObject.transform.rotation; }
        set
        {
            Vector3 newDir = targeta - currenta;
            gameObject.transform.rotation = Quaternion.LookRotation(newDir);
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
      //if (this.gameObject..name.Equals(hit.collider.gameObject.name))
      //{
        //return true;
      //}
      else
        return false;
    }
  }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      