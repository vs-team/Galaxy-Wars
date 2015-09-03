using UnityEngine;
using System.Collections;

public class NetworkTest : MonoBehaviour {

    NetworkView networkView;

	// Use this for initialization
	void Start () {
        //HostData testhost = new HostData();
        //testhost.ip[0] = "127.0.0.1";
        //testhost.port = 443;
        //testhost.useNat = true;
        //GameObject network = Network.
        //Network.Connect(testhost);
        //Debug.Log("Succes");
        Network.Connect("127.0.0.1", 25002);
        Debug.Log(Network.player);
        networkView = new NetworkView();
        //Debug.Log(Network.);
	}
	
	// Update is called once per frame

    void OnConnectedToServer()
    {
        Debug.Log("succesfully connected");
    }

    void OnFailedToConnect(NetworkConnectionError e)
    {
        Debug.Log("failed to connect to server :" + e);
    }
	void Update () {
	    
	}

    [RPC]
    void PrintText (string text, NetworkMessageInfo n)
    {
        Debug.Log("Bedankt");
    }
}
                                                                                                                     