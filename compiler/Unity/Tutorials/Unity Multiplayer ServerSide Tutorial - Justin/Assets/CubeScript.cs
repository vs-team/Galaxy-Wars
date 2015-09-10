using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

	public static CubeScript Instantiate()
    {
        var temp = GameObject.Find("Newcube");
        var comp = temp.GetComponent<CubeScript>();
        return comp;
    }

    public Vector3 Position
    {
        get { return gameObject.transform.position; }
        set { gameObject.transform.position = value; }
    }
}
                                                 