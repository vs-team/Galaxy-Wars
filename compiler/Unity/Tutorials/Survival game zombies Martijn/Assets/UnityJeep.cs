using UnityEngine;
using System.Collections;

public class UnityJeep : MonoBehaviour {

    public static UnityJeep Instantiate()
    {
        var Jeep = GameObject.Instantiate(Resources.Load("Model/Jeep")) as GameObject;
        var Jep = Jeep.GetComponent<UnityJeep>();
        return Jep;
    }

    public Vector3 Position
    {
        get { return gameObject.transform.position; }
        set { gameObject.transform.position = value; }
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
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               