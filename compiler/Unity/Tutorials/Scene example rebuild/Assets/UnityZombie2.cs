using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnityZombie2 : MonoBehaviour
{
  // Before compiling CNV, comment the line in ApplyForceOnZombie
  public static UnityZombie2 Find(Transform a)
  {
    var zmbies_group = a.GetComponent<UnityZombie2>();
    zmbies_group.Agent = a.GetComponent<NavMeshAgent>();
    zmbies_group.motor1 = a.GetComponent<Animator>();
    //Debug.Log("insideFind gunForce: " + wap.GunForce);
    zmbies_group.impactTargets = new List<Rigidbody>();
    zmbies_group.impacts = new List<Vector3>();
    zmbies_group.impactEndTimes = new List<float>();
    return zmbies_group;
  }
  private NavMeshAgent Agent;
  private Animator motor1;
  private bool destroyed;
  private bool dead;
  private bool applyForceOnZombie;
  private bool isHitByForce;
  private bool collidedWithCar;

  private float force;
  private float damage;
  private float bodyPartMultiplier;
  private bodyPart hitBodyPart;

  private Transform hitTransform;
  private Rigidbody hitRigidbody;
  private Vector3 collisionDirection;
  private Collider hitCollider;

  public List<Rigidbody> impactTargets;
  public List<Vector3> impacts;
  public List<float> impactEndTimes;

  enum bodyPart
  {
    Head,
    Limbs,
    Torso
  }

  public Vector3 Dest
  {
    get { return Agent.destination; }
    set
    {
      var y = Vector3.Distance(this.transform.position, value);
      Agent.destination = value;
      var x = Mathf.Min(y, 16.0f);
      Agent.speed = x / 8.0f;
      motor1.SetBool("Run", false);
      motor1.SetBool("Walk", false);
      motor1.SetBool("Attack1", false);
      motor1.SetBool("Attack2", false);
      if (Agent.speed > 1.5f)
      {
        //Debug.Log("run forest run");
        motor1.SetBool("Run", true);
      }
      else
      {
        if (y > 5.0f)
        {
          //Debug.Log("just walk slooooow");
          motor1.SetBool("Walk", true);
        }
        else
        {
          Agent.speed = 0.2f;
          int ranr = Random.Range(1, 3);
          //Debug.Log("Attack!!!"+ranr);
          if (ranr == 1)
          {
            motor1.SetBool("Attack1", true);
          }
          else
          {
            motor1.SetBool("Attack2", true);
          }
        }
      }

    }
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
  public Vector3 Position
  {
    get { return this.transform.position; }
  }
  public Vector3 CollisionDirection
  {
    get { return collisionDirection; }
    set { collisionDirection = value; }
  }
  public float Force
  {
    get { return force; }
    set { force = value; }
  }
  public float Damage
  {
    get { return damage; }
    set { damage = value; }
  }
  public bool CollidedWithCar
  {
    get { return collidedWithCar; }
    set { collidedWithCar = value; }
  }
  /*public RaycastHit Hit
  {
    get { return hit; }
    set
    {
      hit = value;
      if (!dead || !collidedWithCar)
      {
        string hitBodyPartName = hit.transform.name;
        if (hitBodyPartName.Contains("CATRigLArm") || hitBodyPartName.Contains("CATRigRArm") || hitBodyPartName.Contains("CATRigLLeg1") || hitBodyPartName.Contains("CATRigRLeg1"))
          hitBodyPart = bodyPart.Limbs;
        else if (hitBodyPartName.Contains("CATRigHub003"))
          hitBodyPart = bodyPart.Head;
        else if (hitBodyPartName.Contains("CATRigSpine1"))
          hitBodyPart = bodyPart.Torso;
        BodyPartMultiplier = 0.0f; // Set BodyPartMultiplier for damage calculation in CNV
      }
    }
  }*/
  public Transform HitTransform
  {
    get { return hitTransform; }
    set
    {
      hitTransform = value;
      if (!dead || !collidedWithCar)
      {
        string hitBodyPartName = hitTransform.name;
        if (hitBodyPartName.Contains("CATRigLArm") || hitBodyPartName.Contains("CATRigRArm") || hitBodyPartName.Contains("CATRigLLeg1") || hitBodyPartName.Contains("CATRigRLeg1"))
          hitBodyPart = bodyPart.Limbs;
        else if (hitBodyPartName.Contains("CATRigHub003"))
          hitBodyPart = bodyPart.Head;
        else if (hitBodyPartName.Contains("CATRigSpine1"))
          hitBodyPart = bodyPart.Torso;
        BodyPartMultiplier = 0.0f; // Set BodyPartMultiplier for damage calculation in CNV
      }
    }
  }
  public Rigidbody HitRigidbody
  {
    get { return hitRigidbody; }
    set { hitRigidbody = value; }
  }
  public Collider HitCollider
  {
    get { return hitCollider; }
    set { hitCollider = value; }
  }

  public bool IsHitByForce
  {
    get
    {
      return isHitByForce;
      /*GameObject controller = GameObject.Find("truck/Input/RazerJoysticks/Hydra1 - Right");
      RaycastHit hitObject;
      Physics.Raycast(controller.transform.position, controller.transform.forward, out hitObject, 100.0f, 256);
      return (Physics.Raycast(controller.transform.position, controller.transform.forward, out hitObject, 100.0f, 256) &&
             (hitObject.transform.gameObject == this.gameObject));*/
    }
    set
    {
      isHitByForce = value;
    }
  }

  public float BodyPartMultiplier
  {
    get { return bodyPartMultiplier; }
    set
    {
      if (hitBodyPart == bodyPart.Head)
      {
        bodyPartMultiplier = 1.25f;
      }
      else if (hitBodyPart == bodyPart.Torso)
      {
        bodyPartMultiplier = 1f;
      }
      else if (hitBodyPart == bodyPart.Limbs)
      {
        bodyPartMultiplier = 0.75f;
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

  public bool ApplyForceOnZombie //Sets the zombie as ragdoll and applies a force in a direction
  {
    get { return applyForceOnZombie; }
    set
    {
      applyForceOnZombie = value;
      if ((collidedWithCar || dead) && applyForceOnZombie)
      {
        Debug.Log("apply ragdoll on zombie");
        /*                                                                     // <---- COMMENT THIS LINE TO /* BEFORE COMPILING CNV. Once done, change it to //*. Then start the scene
        if (gameObject.name == hitCollider.GetComponentInParent<RagdollHelper>().name)
        {
          RagdollHelper helper = hitCollider.GetComponentInParent<RagdollHelper>();
          helper.ragdolled = true;
          impactTargets.Add(hitRigidbody); //set the impact target to whatever the ray hit
          impacts.Add(collisionDirection * force); //impact direction also according to the ray
          impactEndTimes.Add(Time.time + 0.3f); //Apply the force for <float> length
          Debug.Log("Time of adding zombie to impactList: " + Time.time);
        }
        //*/
        IsHitByForce = false;
      }
      else if (!dead && applyForceOnZombie)
      {
        Debug.Log("apply force on zombie");
        string hitBodyPartName = hitTransform.name;
        if (hitBodyPartName.Contains("CATRigLArm"))
          motor1.SetBool("shot_Left", true);
        else if (hitBodyPartName.Contains("CATRigRArm"))
          motor1.SetBool("shot_Right", true);
        else
          motor1.SetBool("shot", true);

        IsHitByForce = false;
      }
    }
  }

  void Update() 
  {
    //Check if we need to apply an impact for each impact in impactEndTimes
    if (impactEndTimes.Count > 0)
    {
      for (int i = impactEndTimes.Count - 1; i >= 0; i--)
      {
        if (Time.time < impactEndTimes[i])
        {
          Debug.Log("Time of applying the impact to the zombie: " + Time.time);
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