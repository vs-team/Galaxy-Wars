using UnityEngine;
using System.Collections;

public class TruckScript : MonoBehaviour {

	public static TruckScript Instantiate()
    {
        GameObject var = GameObject.Find("truck");
        return var.GetComponent<TruckScript>();
    }

    public Vector3 Position
    {
        get {return gameObject.transform.position;}
        set { gameObject.transform.position = value;}
    }

    public Vector3 Rotation
    {
        get { return gameObject.transform.eulerAngles; }
        set { gameObject.transform.eulerAngles = value;}
    }
}