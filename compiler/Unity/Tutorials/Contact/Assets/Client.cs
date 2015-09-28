using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Client : MonoBehaviour {

    bool clicked;

    Button b;
	// Use this for initialization
	void Start () {
        b = GameObject.Find("Client").GetComponent<Button>();
        clicked = false;
        b.onClick.AddListener(() => { clicked = true; });

    }

    // Update is called once per frame
    void Update () {
            if(clicked == true)
        {
            Debug.Log("Client clicked!");
        }
	}

    
}
                     