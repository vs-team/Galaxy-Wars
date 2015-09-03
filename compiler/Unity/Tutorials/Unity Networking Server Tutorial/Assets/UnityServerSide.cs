using UnityEngine;
using System.Collections;

public class UnityServerSide : MonoBehaviour {
    NetworkView networkView;

	// Use this for initialization
	void Start () {
        Network.InitializeServer(1, 25002, false);
        Debug.Log("succesfully hosted server on port 25002");
        networkView = new NetworkView();

	}

    void OnPlayerConnected()
    {
        Debug.Log("player has succesfully connected");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            networkView.RPC("PrintText", RPCMode.All, "test");
            Debug.Log("Succes!");
        }
	}
}
                                                                                                   