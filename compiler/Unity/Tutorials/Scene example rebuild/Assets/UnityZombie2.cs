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
    zmbies_group.impactTargets = new List<Rigidbody>();
    zmbies_group.impacts = new List<Vector3>();
    zmbies_group.impactEndTimes = new List<float>();
    return zmbies_group;
  }
  private NavMeshAgent Agent;
  private Animator motor1;
  private string currentState;
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
      Agent.destination = value;
      var zombieToCarDistance = Vector3.Distance(this.transform.position, value);
      Agent.speed = Mathf.Min(zombieToCarDistance, 16.0f) / 8.0f;
      if (Agent.speed > 1.5f)
      {
        if (currentState != "Run")
        {
          motor1.SetBool(currentState, false);
          motor1.SetBool("Run", true);
          currentState = "Run";
        }
      }
      else
      {
        if (zombieToCarDistance > 5.0f)
        {
          if (currentState != "Walk")
          {
            motor1.SetBool(currentState, false);
            motor1.SetBool("Walk", true);
            currentState = "Walk";
          }
        }
        else
        {
          Agent.speed = 0.2f;
          int ranr = Random.Range(1, 3);
          if (ranr == 1)
          {
            if (currentState != "Attack1")
            {
              motor1.SetBool(currentState, false);
              motor1.SetBool("Attack1", true);
              currentState = "Attack1";
            }
          }
          else
          {
            if (currentState != "Attack2")
            {
              motor1.SetBool(currentState, false);
              motor1.SetBool("Attack2", true);
              currentState = "Attack2";
            }
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
      if (dead)
        Agent.speed = 0.0f;
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

  void OnCollisionEnter(Collision collision)
  {
    Debug.Log("zombie collision");
    if (collision.relativeVelocity.magnitude > 10.0f)
    {
      if (collision.transform.root.tag == "Zombiegroup")
      {
        UnityZombie2 hitZombie = collision.transform.GetComponentInParent<UnityZombie2>();
        if (/*!collidedWithThisFrame.Contains(hitZombie) && */!hitZombie.CollidedWithCar)
        {
          //collidedWithThisFrame.Add(hitZombie);
          Debug.Log("apply zombie collision");
        
          hitZombie.CollisionDirection = -collision.relativeVelocity.normalized;
          hitZombie.Force = collision.relativeVelocity.magnitude;
          hitZombie.HitCollider = collision.collider;
          hitZombie.HitTransform = collision.transform;
          hitZombie.HitRigidbody = collision.rigidbody;
          hitZombie.CollidedWithCar = true;
          hitZombie.IsHitByForce = true;
        }
      }
    }
  }

  public bool ApplyForceOnZombie //Sets the zombie as ragdoll and applies a force in a direction
  {
    get { return applyForceOnZombie; }
    set
    {
      applyForceOnZombie = value;
      if ((collidedWithCar || dead) && applyForceOnZombie)
      {
        Debug.Log("apply ragdoll on zombie");
        //*                                                                     // <---- COMMENT THIS LINE TO /* BEFORE COMPILING CNV. Once done, change it to //*. Then start the scene
        if (gameObject.name == hitCollider.GetComponentInParent<RagdollHelper>().name)
        {
          RagdollHelper helper = hitCollider.GetComponentInParent<RagdollHelper>();
          helper.ragdolled = true;
          impactTargets.Add(hitRigidbody); //set the impact target to whatever the ray hit
          impacts.Add(collisionDirection * force); //impact direction also according to the ray
          impactEndTimes.Add(Time.time + 0.3f); //Apply the force for <float> length
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
    //Pressing space makes the character get up, assuming that the character root has
    //a RagdollHelper script
    /*if (Input.GetKeyDown(KeyCode.Space))
    {
      RagdollHelper helper = GetComponent<RagdollHelper>();
      helper.ragdolled = false;
    }*/
  }

}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            