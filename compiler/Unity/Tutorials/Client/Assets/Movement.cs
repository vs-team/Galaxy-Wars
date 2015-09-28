using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKey(KeyCode.W))
        {
            this.gameObject.transform.position += new Vector3(1.0f, 0.0f, 0.0f);
        }
	}
}
         