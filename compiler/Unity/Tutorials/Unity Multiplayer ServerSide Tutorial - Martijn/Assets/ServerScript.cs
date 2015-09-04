using UnityEngine;
using System.Collections;

public class ServerScript : MonoBehaviour {

    public GameObject cube;
    public NetworkView networkView;
	// Use this for initialization
	void Start () {
        GameObject var = GameObject.Find("test");
        networkView = var.GetComponent<NetworkView>();
        cube = GameObject.Find("Cube");
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.A))
        {
            networkView.RPC("MoveRight", RPCMode.All, null);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            networkView.RPC("MoveLeft", RPCMode.All, null);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Network.InitializeServer(1, 443, false);
            Debug.Log("succesfully initialized server");
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Network.Connect("145.24.235.242", 443);
        }
     
	}

    void OnConnectedToServer()
    {
        Debug.Log("succesfully connected to Server");
    }

    void OnPlayerConnected()
    {
        Debug.Log("Player connected to server");
    }

    void OnDisconnectedFromServer()
    {
        Debug.Log("Disconnected from server");
    }

    void OnFailedToConnect(NetworkConnectionError n)
    {
        Debug.Log("Failed to connect" + n);
    }

    [RPC]
    public void MoveLeft()
    {
        cube.transform.position -= Vector3.right * 2f;
    }
    [RPC]
    public void MoveRight()
    {
        cube.transform.position += Vector3.right * 2f;
    }
}
                                                                                                                                                         