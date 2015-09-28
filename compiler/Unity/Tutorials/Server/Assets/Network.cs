using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Network : NetworkBehaviour {

    public GameObject pref;
    NetworkServer net;
    NetworkClient netcli;
	// Use this for initialization
	void Start () {
        SetupServer();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(NetworkServer.connections.Count);
        if(Input.GetKeyDown(KeyCode.D))
        {
            Rpc_createCube();
        }
	}

    public virtual void OnServerReady(NetworkConnection conn)
    {
        NetworkServer.SetClientReady(conn);
        Debug.Log("Server Ready!");
    }

    

    [ClientRpc]
    void Rpc_createCube()
    {
        GameObject tes = GameObject.Instantiate(pref, new Vector3(1.0f, 1.0f, 1.0f), Quaternion.identity) as GameObject;
        NetworkServer.Spawn(tes);
    }

    public void SetupServer()
    {
        NetworkServer.Listen(12345);
        Debug.Log("Listening!");
    }
}
                                                      