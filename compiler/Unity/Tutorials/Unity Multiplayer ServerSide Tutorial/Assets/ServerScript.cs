﻿using UnityEngine;
using System.Collections;

public class ServerScript : MonoBehaviour {

    public NetworkView networkView;
	// Use this for initialization
	void Start () {
        GameObject var = GameObject.Find("test");
        networkView = var.GetComponent<NetworkView>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.A))
        {
            networkView.RPC("PrintLog", RPCMode.All, null);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Network.InitializeServer(1, 443, false);
            Debug.Log("succesfully initialized server");
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Network.Connect("127.0.0.1", 443);
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
    public void PrintLog()
    {
        Debug.Log("well");
    }
}
                                                                                            