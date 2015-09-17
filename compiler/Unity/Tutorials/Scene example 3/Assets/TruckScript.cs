using UnityEngine;
using System.Collections;

public class TruckScript : MonoBehaviour {

  public Rigidbody truckRigidBody;
	public static TruckScript Instantiate()
    {
        GameObject var = GameObject.Find("truck");
        TruckScript truck = var.GetComponent<TruckScript>() as TruckScript;
        truck.truckRigidBody = var.GetComponent<Rigidbody>() as Rigidbody;
        return truck;
    }

    public Vector3 Position
    {
      get { return gameObject.transform.position; }
      set { gameObject.transform.position = value; }
    }

    public Vector3 Rotation
    {
        get { return gameObject.transform.eulerAngles; }
        set { gameObject.transform.eulerAngles = value;}
    }
  
    public float AddFors
    {
      set { truckRigidBody.AddForce(-transform.forward * value); }
    }
    public Vector3 RotateCar
    {
      set { truckRigidBody.AddRelativeTorque(value); }
    }
    public Vector3 CenterOfMass
    {
      get { return truckRigidBody.centerOfMass; }
      set { truckRigidBody.centerOfMass = value; }
    }
}                                                                                                                         