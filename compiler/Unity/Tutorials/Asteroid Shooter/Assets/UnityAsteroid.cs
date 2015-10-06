using UnityEngine;
using System.Collections;

public class UnityAsteroid : MonoBehaviour {

    bool destroyed;
    bool hit;
    Camera mainCam;

    void Start()
    {
        destroyed = false;
        hit = false;
    }

	public static UnityAsteroid Instantiate(Vector3 pos)
    {
        var ast = GameObject.Instantiate(Resources.Load("Asteroid"), pos, Quaternion.identity) as GameObject;
        ast.GetComponent<UnityAsteroid>().mainCam = GameObject.Find("Main Camera").GetComponent<Camera>();
        return ast.GetComponent<UnityAsteroid>();
    }

    public Vector3 Position
    {
        get { return this.gameObject.transform.position; }
        set { this.gameObject.transform.position = value; }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            hit = true;
            
        }
    }

    public bool Hit
    {
        get { return this.hit; }
        set { this.hit = value; }
    }

    public bool Destroyed
    {
        get { return this.destroyed; }
        set
        {
            this.destroyed = value;
            if (destroyed)
            {
                var ps = gameObject.GetComponent<ParticleSystem>();
                ps.Play();
                Destroy(gameObject, ps.duration);
            }
                
        }
    }

    public Vector3 ViewPortPoint
    {
        get { return mainCam.WorldToViewportPoint(gameObject.transform.position); }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       