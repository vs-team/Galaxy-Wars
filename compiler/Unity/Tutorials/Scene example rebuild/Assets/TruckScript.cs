using UnityEngine;
using System.Collections;

public class TruckScript : MonoBehaviour {

  public Rigidbody truckRigidBody;

  public static TruckScript Instantiate()
    {
        GameObject jeepGameObject = GameObject.Find("truck");
        TruckScript truck = jeepGameObject.GetComponent<TruckScript>() as TruckScript;
        truck.truckRigidBody = jeepGameObject.GetComponent<Rigidbody>() as Rigidbody;
        return truck;
    }
  public Vector3 Position
  {
    get { return this.transform.position;}
  }
  public Vector3 Frce
  {
    get { return truckRigidBody.position; }
    set { truckRigidBody.AddForce(value, ForceMode.Force); }
  }
  public Vector3 Trque
  {
    set { truckRigidBody.AddTorque(value, ForceMode.Force); }
  }
}                      