using UnityEngine;
using System.Collections;
using Lidgren.Network;

public class UnityShip : MonoBehaviour {

    private NetClient nc;
    private NetServer ns;
	// Use this for initialization
	public UnityShip Instantiate(Vector3 pos, bool isHost, string gameName, string endPoint, int conPort)
    {
        GameObject ship = GameObject.Instantiate(Resources.Load("Ship"), pos, Quaternion.identity) as GameObject;
        if(isHost)
        {
            NetPeerConfiguration config = new NetPeerConfiguration(gameName);
            ns = new NetServer(config);
        }
        else
        {
            NetPeerConfiguration config = new NetPeerConfiguration(gameName);
            nc = new NetClient(config);
            nc.Connect(host: endPoint, port: conPort);
        }
        return ship.GetComponent<UnityShip>();

    }

    // Update is called once per frame
    void Update () {
	
	}
}
                                                                                                                                          