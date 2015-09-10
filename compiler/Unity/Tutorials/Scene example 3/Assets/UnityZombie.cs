using UnityEngine;
using System.Collections;

public class UnityZombie : MonoBehaviour
{

    public static UnityZombie Instantiate(Vector3 pos)
    {
        var Zombie = GameObject.Instantiate(Resources.Load("Model/Zombie"), pos - (new Vector3(Random.value * 6.0f, 0.0f, Random.value * 6.0f)), Quaternion.identity) as GameObject;
        var zbie = Zombie.GetComponent<UnityZombie>();
        return zbie;
    }

    public Vector3 targeta;
    public Vector3 currenta;
    public float speed;

    public Vector3 Position
    {
        get { return gameObject.transform.position; }
        set
        {
            transform.position = Vector3.MoveTowards(currenta, targeta, speed);
        }

    }
    public Quaternion Rotation
    {
        get { return gameObject.transform.rotation; }
        set
        {
                Vector3 newDir = targeta - currenta;
                gameObject.transform.rotation = Quaternion.LookRotation(newDir);
        }

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
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            