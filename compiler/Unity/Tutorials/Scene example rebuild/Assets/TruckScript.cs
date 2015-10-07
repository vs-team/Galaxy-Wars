using UnityEngine;
using System.Collections;

public class TruckScript : MonoBehaviour
{

  public Rigidbody truckRigidBody;
  public WheelCollider FrontLeftWheel;
  public WheelCollider FrontRightWheel;
  public WheelCollider RearLeftWheel;
  public WheelCollider RearRightWheel;
  public Light lampi;

  public static TruckScript Instantiate()
  {
    GameObject jeepGameObject = GameObject.Find("truck");
    TruckScript truck = jeepGameObject.GetComponent<TruckScript>() as TruckScript;

    truck.FrontLeftWheel = GameObject.Find("SUV_wheel_front_left").GetComponent<WheelCollider>() as WheelCollider;
    truck.FrontRightWheel = GameObject.Find("SUV_wheel_front_right").GetComponent<WheelCollider>() as WheelCollider;
    truck.RearLeftWheel = GameObject.Find("SUV_wheel_rear_left").GetComponent<WheelCollider>() as WheelCollider;
    truck.RearRightWheel = GameObject.Find("SUV_wheel_rear_right").GetComponent<WheelCollider>() as WheelCollider;
    truck.lampi = GameObject.Find("Hydra1 - Right").GetComponent<Light>() as Light;
    truck.truckRigidBody = jeepGameObject.GetComponent<Rigidbody>() as Rigidbody;
    return truck;
  }
  public Vector3 Position
  {
    get { return this.transform.position; }
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
  public bool LightOn
  {
    get { return lampi.enabled; }
    set { lampi.enabled = value; }
  }

  public float Steering
  {
    get { return Input.GetAxisRaw("SW_Joy0X"); }
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
      if (Input.GetAxisRaw("SW_Joy0Y") <= 0.0f)
      {
        return 0.0f;
      }
      else
      {
        return Input.GetAxisRaw("SW_Joy0Y");
      }
    }
  }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           