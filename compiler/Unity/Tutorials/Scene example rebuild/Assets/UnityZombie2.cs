using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityZombie2 : MonoBehaviour
{
                                                      // Before compiling CNV, comment the line in Update()
  public static UnityZombie2 Find(Transform a)
  {
    var zmbies_group = a.GetComponent<UnityZombie2>();
    zmbies_group.motor1 = a.GetComponent<Animator>();
    GameObject dad = GameObject.FindWithTag("Gun") as GameObject;
    UnityGun wap = dad.GetComponent<UnityGun>() as UnityGun;  // Change once multiple guns are implemented
    Debug.Log("insideFind gunForce: " + wap.GunForce);
    zmbies_group.gunForce = wap.GunForce;
    zmbies_group.impactTargets = new List<Rigidbody>();
    zmbies_group.impacts = new List<Vector3>();
    zmbies_group.impactEndTimes = new List<float>();
    return zmbies_group;
  }

  private Animator motor1;
  bool destroyed;
  bool dead;
  public bool isHitByBullet;
  private bool isHitByCar;
  //bool hasCollided = false;
  float collisionDamage;
  private RaycastHit hit;
  Ray ray;
  float bodyPartMultiplier;
  float gunForce;
  bodyPart hitBodyPart;
  public List<Rigidbody> impactTargets;
  public List<Vector3> impacts;
  public List<float> impactEndTimes;

  enum bodyPart
  {
    Head,
    Limbs,
    Torso
  }

  public bool Dead
  {
    get { return dead; }
    set
    {
      dead = value;
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
    get
    {
      ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      int layermask = 1 << 8;
      if (Physics.Raycast(ray, out hit, 100, layermask))
      {
        if (this == hit.collider.GetComponentInParent<UnityZombie2>())
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

  /*public bool HasCollided
  {
    get { return hasCollided; }
    set { hasCollided = value; }
  }*/
  public bool IsHitByBullet
  {
    get
    {
      return isHitByBullet;
      /*GameObject controller = GameObject.Find("truck/Input/RazerJoysticks/Hydra1 - Right");
      RaycastHit hitObject;
      Physics.Raycast(controller.transform.position, controller.transform.forward, out hitObject, 100.0f, 256);
      return (Physics.Raycast(controller.transform.position, controller.transform.forward, out hitObject, 100.0f, 256) &&
             (hitObject.transform.gameObject == this.gameObject));*/
    }
    set
    {
      isHitByBullet = value;
      if(!dead && isHitByBullet)
      {
        string hitBodyPartName = hit.transform.name;
        if (hitBodyPartName.Contains("CATRigLArm"))
          motor1.SetBool("shot_Left", true);
        else if (hitBodyPartName.Contains("CATRigRArm"))
          motor1.SetBool("shot_Right", true);
        else
          motor1.SetBool("shot", true);

        if (hitBodyPartName.Contains("CATRigLArm") || hitBodyPartName.Contains("CATRigRArm") || hitBodyPartName.Contains("CATRigLLeg1") || hitBodyPartName.Contains("CATRigRLeg1"))
          hitBodyPart = bodyPart.Limbs;
        else if (hitBodyPartName.Contains("CATRigHub003"))
          hitBodyPart = bodyPart.Head;
        else if (hitBodyPartName.Contains("CATRigSpine1"))
          hitBodyPart = bodyPart.Torso;
        BodyPartMultiplier = 0.0f; // Set BodyPartMultiplier for CNV
      }
    }
  }

  public float BodyPartMultiplier
  {
    get { return bodyPartMultiplier; }
    set
    {
      if(hitBodyPart == bodyPart.Head)
      {
        bodyPartMultiplier = 1.25f;
      }
      else if(hitBodyPart == bodyPart.Torso)
      {
        bodyPartMultiplier = 1f;
      }
      else if (hitBodyPart == bodyPart.Limbs)
      {
        bodyPartMultiplier = 0.75f;
      }
    }
  }

  public float CollisionDamage
  {
    get { return collisionDamage; }
    set {
      collisionDamage = value;
      if(value > 0.0f)
      {
        Debug.Log("collisiondamage: " + collisionDamage);
        isHitByCar = true;
        /*car collision physics here*/
      }
    }
  }
  /*void OnCollisionEnter(Collision collision)
  {
    if (collision.relativeVelocity.magnitude > 15.0f)
    {
      Debug.Log("zombie has been collided with");
      collisionDamage = collision.relativeVelocity.magnitude;
    }
  }*/

  void Update()
  {
    // Create ApplyForceOnRagdoll method
    if (dead && isHitByBullet)
    {
      /*                                                                          // <---- COMMENT THIS LINE TO /* BEFORE COMPILING CNV. Once done, change it to //*. Then start the scene
      if (this.gameObject.name == hit.collider.GetComponentInParent<RagdollHelper>().name)
      {
        RagdollHelper helper = hit.collider.GetComponentInParent<RagdollHelper>();
        helper.ragdolled = true;
        //set the impact target to whatever the ray hit
        impactTargets.Add(hit.rigidbody);
        //impact direction also according to the ray
        impacts.Add(ray.direction * gunForce);                                // Gun Force
                                                                              //the impact will be reapplied for the next 250ms
                                                                              //to make the connected objects follow even though the simulated body joints
                                                                              //might stretch
        impactEndTimes.Add(Time.time + 0.3f);
      }
      //*/
    }
    //Check if we need to apply an impact
    if (impactEndTimes.Count > 0)
    {
      for(int i = impactEndTimes.Count - 1; i >= 0; i--)
      {
        if (Time.time < impactEndTimes[i])
        {
          Debug.Log("Apply force to rigidbody: " + impactTargets[i]);
          impactTargets[i].AddForce(impacts[i], ForceMode.VelocityChange);
        }
        else
        {
          impactEndTimes.RemoveAt(i);
          impactTargets.RemoveAt(i);
          impacts.RemoveAt(i);
        }
      }
    }
    //if left mouse button clicked
    /*if (OnMouseOver && Input.GetMouseButtonDown(0))
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

      /*foreach (float t in impactEndTimes)
      {
        int indexOfT = impactEndTimes.IndexOf(t);
        if (Time.time < t)
        {
          Debug.Log("Apply force to rigidbody: " + impactTargets[indexOfT]);
          impactTargets[indexOfT].AddForce(impacts[indexOfT], ForceMode.VelocityChange);
        }
        else
        {
          impactEndTimes.Remove(t);
          impactTargets.RemoveAt(indexOfT);
          impacts.RemoveAt(indexOfT);
        }
      }*/
  /*if (Time.time < impactEndTime)
  {
    impactTarget.AddForce(impact, ForceMode.VelocityChange);
  }*/
}

}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           