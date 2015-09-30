using UnityEngine;
using System.Collections;
using Lidgren.Network;

public class UnityShip : MonoBehaviour {

	//Use this for initialization
	public static UnityShip Instantiate(Vector3 pos)
    {
        GameObject ship = GameObject.Instantiate(Resources.Load("Ship"), pos, Quaternion.identity) as GameObject;
        var debug = ship.GetComponent<UnityShip>();
        return ship.GetComponent<UnityShip>();
    }

    public Vector3 Position
    {
        get { return this.gameObject.transform.position; }
        set { this.gameObject.transform.position = value; }
    }

    
}
                                                                                                                                                                                                              