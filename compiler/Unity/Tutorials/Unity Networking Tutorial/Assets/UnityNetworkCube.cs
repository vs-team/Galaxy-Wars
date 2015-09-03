using UnityEngine;
using System.Collections;

public class UnityNetworkCube : MonoBehaviour {

	public static UnityNetworkCube Instantiate()
    {
        GameObject var = GameObject.Find("Cube");
        UnityNetworkCube cube = var.GetComponent<UnityNetworkCube>();
       
        return cube;

    }

    public Color Color
    {
        get { return gameObject.renderer.material.color; }
        set { gameObject.renderer.material.color = value; }
    }

    public static void testNet()
    {
        
    }
}
<<<<<<< HEAD
                                                                                                                                                                                                                                                               
=======
                                                                                                                                                                                 
>>>>>>> origin/master
