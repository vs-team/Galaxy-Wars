using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Lidgren.Network;

public class ServerScript : MonoBehaviour
{
  public NetServer serv;
  public NetworkView networkView;
  public NetIncomingMessage inc;
  // Use this for initialization

  public ServerScript Find()
  {
      GameObject var = GameObject.Find("Cube");
      var cube = GameObject.Find("Cube");
      var script = cube.GetComponent<ServerScript>();
      var test = new NetPeerConfiguration("ServerSide");
      test.LocalAddress = NetUtility.Resolve("localhost");
      test.EnableMessageType(NetIncomingMessageType.ConnectionApproval);
      test.Port = 57621;
      serv = new NetServer(test);
      serv.Start();
      Debug.Log("Server is running!");
      return script;
  }
  

  // Update is called once per frame
  void Update()
  {
    if ((inc = serv.ReadMessage()) != null)
    {
        switch (inc.MessageType)
        {
            case NetIncomingMessageType.ConnectionApproval:
                inc.SenderConnection.Approve();
                break;
            default:
                Debug.Log("This type of message is not handled"+inc.MessageType);
                Debug.Log(serv.ConnectionsCount);
                break;
        }
    }
    if(Input.GetKey(KeyCode.T))
    {
        serv.Shutdown("test");
    }

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
      Network.InitializeServer(512, 25002, false);
      Debug.Log("succesfully initialized server");
    }

    if (Input.GetKeyDown(KeyCode.Z))
    {
      Debug.Log("Trying to connect to server...");
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