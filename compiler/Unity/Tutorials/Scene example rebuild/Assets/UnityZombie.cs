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
  bool destroyed;
  bool hasCollided = false;
  float collisionDamage;

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

  public bool HasCollided
  {
    get { return hasCollided; }
    set { hasCollided = value; }
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

  public float CollisionDamage
  {
    get { return collisionDamage; }
    set { collisionDamage = value; }
  }

  void OnCollisionEnter(Collision collision)
  {
    if (collision.relativeVelocity.magnitude > 15.0f)
    {
      Debug.Log("zombie has been collided with");
      collisionDamage = collision.relativeVelocity.magnitude;
    }
  }

  float impactEndTime = 0;
  Rigidbody impactTarget = null;
  Vector3 impact;

  /*void Update()
   {
     //if left mouse button clicked
     if (OnMouseOver && Input.GetMouseButtonDown(0))
     {
       //Get a ray going from the camera through the mouse cursor
       Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       //check if the ray hits a physic collider
       RaycastHit hit; //a local variable that will receive the hit info from the Raycast call below
       int layermask = 1 << 8;
       if (Physics.Raycast(ray, out hit, 100, layermask))                         // Gun Distance
       {
         string hitPart = hit.transform.name;

         //check if the raycast target has a rigid body (belongs to the ragdoll)
         if (hit.rigidbody != null)
         {
           //find the RagdollHelper component and activate ragdolling
           RagdollHelper helper = hit.transform.root.GetComponent<RagdollHelper>();
           helper.anim.SetFloat("health", helper.anim.GetFloat("health") - 20.0f); // Gun Damage
           if (helper.anim.GetFloat("health") <= 0.0f) // Turn into ragdoll if dead
           {
             helper.ragdolled = true;
             //set the impact target to whatever the ray hit
             impactTarget = hit.rigidbody;
             //impact direction also according to the ray
             impact = ray.direction * 2.0f;                                       // Gun Force
             //the impact will be reapplied for the next 250ms
             //to make the connected objects follow even though the simulated body joints
             //might stretch
             impactEndTime = Time.time + 0.25f;
           }
           else
           {
             string LArm = hit.transform.name;
             if (LArm.Contains("CATRigLArm"))
             {
               helper.anim.SetBool("shot_Left", true);
             }
             else if (LArm.Contains("CATRigRArm"))
             {
               helper.anim.SetBool("shot_Right", true);
             }
             else
             {
               helper.anim.SetBool("shot", true);
             }
           }
         }
       }
     }*/

     //Pressing space makes the character get up, assuming that the character root has
     //a RagdollHelper script
     /*if (Input.GetKeyDown(KeyCode.Space))
     {
       RagdollHelper helper = GetComponent<RagdollHelper>();
       helper.ragdolled = false;
     }*/

  //Check if we need to apply an impact
   /*if (Time.time < impactEndTime)
   {
     impactTarget.AddForce(impact, ForceMode.VelocityChange);
   }
 }*/

}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    