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
<<<<<<< HEAD:compiler/Unity/Tutorials/Unity Multiplayer ServerSide Tutorial - Justin/Assets/ServerScript.cs
            Network.InitializeServer(512, 25002, false);
=======
            Network.InitializeServer(1, 25002, false);
>>>>>>> af6e3709317982f68fcf0c2873540bbc51940d03:compiler/Unity/Tutorials/Unity Multiplayer ServerSide Tutorial - Justin/Assets/Networking/ServerScript.cs
            Debug.Log("succesfully initialized server");
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Network.Connect("192.168.2.30", 25002);
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
<<<<<<< HEAD:compiler/Unity/Tutorials/Unity Multiplayer ServerSide Tutorial - Justin/Assets/ServerScript.cs
                                                                                                                                                                 
=======
                                                                                                                                                                                                       
>>>>>>> af6e3709317982f68fcf0c2873540bbc51940d03:compiler/Unity/Tutorials/Unity Multiplayer ServerSide Tutorial - Justin/Assets/Networking/ServerScript.cs
