using UnityEngine;
using System.Collections;
using Lidgren.Network;
using Lidgren;

public class ClientScript : MonoBehaviour {

    public NetClient net;
	// Use this for initialization
	void Start () {
        var test = new NetPeerConfiguration("ServerSide");
        net = new NetClient(test);
        net.Start();
        net.Connect("127.0.0.1", 57621);
        Debug.Log("Connection request sent");
        
	}
	
	// Update is called once per frame
	void Update () {
	     if (Input.GetKeyDown(KeyCode.K))
         {
             Debug.Log(net.Status);
         }
	}
}
   