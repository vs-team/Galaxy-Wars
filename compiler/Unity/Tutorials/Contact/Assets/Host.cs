using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Host : MonoBehaviour {

    bool clicked;
    Button b;
	// Use this for initialization
	void Start () {
        clicked = false;
        b = GameObject.Find("Host").GetComponent<Button>();
        b.onClick.AddListener(() => { clicked = true; });
	}
	
	// Update is called once per frame
	void Update () {
	     if(clicked == true)
        {
            Debug.Log("Host Selected!");
            Application.LoadLevel("Menu");
        }
    }
}
                                             