using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ServerScript : MonoBehaviour
{

  public GameObject cube;
  public NetworkView networkView;
  // Use this for initialization
  void Start()
  {
    GameObject var = GameObject.Find("test");
    networkView = var.GetComponent<NetworkView>();
    cube = GameObject.Find("Cube");
  }

  List<string> current_rpcs = new List<string>();

  private int myVar;

  [RPC]
  public int MyProperty
  {
    get { return myVar; }
    set
    {
      current_rpcs.Add("MyProperty");
      myVar = value;
    }
  }



  // Update is called once per frame
  void Update()
  {
    foreach (var rpc_to_call in current_rpcs)
    {
      networkView.RPC(rpc_to_call, RPCMode.All, null);

    }
    current_rpcs.Clear();




    Debug.Log("Myproperty : " + MyProperty);


    if (Input.GetKeyDown(KeyCode.A))
    {
      MyProperty++;
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