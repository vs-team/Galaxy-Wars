using UnityEngine;
using System.Collections;

public class UnityZombie : MonoBehaviour
{
    public static UnityZombie Instantiate(Vector3 pos)
    {
        var Zombie = GameObject.Instantiate(Resources.Load("Model/Zombie"), pos, Quaternion.identity) as GameObject;
        var zbie = Zombie.GetComponent<UnityZombie>();
        return zbie;
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
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       