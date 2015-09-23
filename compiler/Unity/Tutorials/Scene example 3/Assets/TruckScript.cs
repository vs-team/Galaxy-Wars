using UnityEngine;
using System.Collections;

public class TruckScript : MonoBehaviour {

  public Rigidbody truckRigidBody;
  public WheelCollider leftFrontWheel;
  public WheelCollider rightFrontWheel;
  public WheelCollider leftRearWheel;
  public WheelCollider rightRearWheel;

  public static TruckScript Instantiate()
    {
        GameObject jeepGameObject = GameObject.Find("truck");
        TruckScript truck = jeepGameObject.GetComponent<TruckScript>() as TruckScript;
        truck.truckRigidBody = jeepGameObject.GetComponent<Rigidbody>() as Rigidbody;
        truck.leftFrontWheel = GameObject.Find("SUV_wheel_front_left").GetComponent<WheelCollider>() as WheelCollider;
        truck.rightFrontWheel = GameObject.Find("SUV_wheel_front_right").GetComponent<WheelCollider>() as WheelCollider;
        truck.leftRearWheel = GameObject.Find("SUV_wheel_rear_left").GetComponent<WheelCollider>() as WheelCollider;
        truck.rightRearWheel = GameObject.Find("SUV_wheel_rear_right").GetComponent<WheelCollider>() as WheelCollider;
        return truck;
    }
    public Vector3 CenterOfMass
    {
      get { return truckRigidBody.centerOfMass; }
      set { truckRigidBody.centerOfMass = value; }
    }
    public Vector3 Position
    {
        get { return gameObject.transform.position; }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             