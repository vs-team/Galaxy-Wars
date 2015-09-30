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
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    