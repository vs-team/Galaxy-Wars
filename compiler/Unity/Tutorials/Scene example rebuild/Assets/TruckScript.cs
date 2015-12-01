using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TruckScript : MonoBehaviour
{

  public Rigidbody truckRigidBody;
  public WheelCollider FrontLeftWheel;
  public WheelCollider FrontRightWheel;
  public WheelCollider RearLeftWheel;
  public WheelCollider RearRightWheel;
  public Light HeadlightLeft;
  public Light HeadlightRight;
  private float CarHP = 1.0f;
  public Collider shield;
  private List<UnityZombie2> collidedWithThisFrame;

  public static TruckScript Instantiate(string nm, Vector3 pos)
  {
    GameObject jeepGameObject = GameObject.Instantiate(Resources.Load("Jeeps/" + nm), pos, Quaternion.identity) as GameObject;
    TruckScript truck = jeepGameObject.GetComponent<TruckScript>() as TruckScript;
    truck.truckRigidBody = jeepGameObject.GetComponent<Rigidbody>() as Rigidbody;

    truck.FrontLeftWheel = truck.transform.Find("SUV_wheel_front_left").GetComponent<WheelCollider>() as WheelCollider;
    truck.FrontRightWheel = truck.transform.Find("SUV_wheel_front_right").GetComponent<WheelCollider>() as WheelCollider;
    truck.RearLeftWheel = truck.transform.Find("SUV_wheel_rear_left").GetComponent<WheelCollider>() as WheelCollider;
    truck.RearRightWheel = truck.transform.Find("SUV_wheel_rear_right").GetComponent<WheelCollider>() as WheelCollider;

    truck.HeadlightLeft = truck.transform.Find("LeftLight").GetComponent<Light>() as Light;
    truck.HeadlightRight = truck.transform.Find("RightLight").GetComponent<Light>() as Light;

    truck.shield = truck.transform.Find("Shield").GetComponent<Collider>() as Collider;
    truck.collidedWithThisFrame = new List<UnityZombie2>();
    return truck;
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

  public Vector3 Position
  {
    get { return this.transform.position; }
  }
  public float RotationY
  {
    get
    {
      return this.transform.eulerAngles.y;
    }
  }
  public Vector3 COM
  {
    get { return COM; }
    set { truckRigidBody.centerOfMass = value; } 
  }

  public Vector3 CenterOfMass
  {
    get { return truckRigidBody.centerOfMass; }
    set { truckRigidBody.centerOfMass = value; }
  }

  public float Frce
  {
    set
    {
      truckRigidBody.MovePosition(transform.position + transform.forward * value * -1.0f);
    }
  }
  public Vector3 Trque
  {
    set
    {
      Quaternion deltaRotation = Quaternion.Euler(value * Time.deltaTime);
      truckRigidBody.MoveRotation(truckRigidBody.rotation * deltaRotation);
    }
  }
  public bool HeadlightRightOn
  {
    get { return HeadlightRight.enabled; }
    set { HeadlightRight.enabled = value; }
  }

  public bool HeadlightLeftOn
  {
    get { return HeadlightLeft.enabled; }
    set { HeadlightLeft.enabled = value; }
  }

  public float Steering
  {
    get { return Input.GetAxis("SW_Joy0X"); }
  }

  public float BrakeAndReverse
  {
    get
    {
      if (Input.GetAxisRaw("SW_Joy0Y") >= 0.0f)
      {
        return 0.0f;
      }
      else
      {
        return (Input.GetAxisRaw("SW_Joy0Y") * -1.0f);
      }
    }
  }

  public float Acceleration
  {
    get
    {
      if (Input.GetAxisRaw("SW_Joy0Y") < 0.0f)
      {
        return 0.0f;
      }
      else
      {
        return Input.GetAxis("SW_Joy0Y");
      }
    }
  }
  private bool CollWithModel;
  public bool CollisionWithModel
  {
    get { return CollWithModel; }
    set { CollWithModel = value; }
  }
  void OnCollisionEnter(Collision collision)
  {
    UnityZombie2 hitZombie = collision.transform.GetComponentInParent<UnityZombie2>();
    if (!collidedWithThisFrame.Contains(hitZombie))
    {
      collidedWithThisFrame.Add(hitZombie);
      if (collision.relativeVelocity.magnitude > 10.0f)
      {
        hitZombie.CollisionDamage = collision.relativeVelocity.magnitude;
        hitZombie.impactTargets.Add(collision.rigidbody);
        hitZombie.impacts.Add(collision.relativeVelocity.normalized * collision.relativeVelocity.magnitude);
        hitZombie.impactEndTimes.Add(Time.time + 0.3f);
        if (!hitZombie.Dead)
    {
      CarHP -= collision.relativeVelocity.magnitude / 100;
    }
  }
    }
  }

  public float CarHP2
  {
    get {
      return CarHP; }
    set { CarHP = value; }
  }
  void Update()
  { 
    //Physics.IgnoreCollision(shield, UnityPlane.planeBox, true);
  }

  void LateUpdate()
  {
    if(collidedWithThisFrame.Count > 0)
      collidedWithThisFrame.Clear();
  }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               