using UnityEngine;
using System.Collections;

public class UnityNetworkingManager : MonoBehaviour {

  private void StartServer()
  {
    Network.InitializeServer(16, 25002, false);
  }

  private void ConnectToServer()
  {
    Network.Connect("192.168.1.3", 25002);
  }

  void OnServerInitialized()
  {
    Debug.Log("Server has been initialized.");
  }

  void OnPlayerConnected()
  {
    Debug.Log("A player has joined the server.");
  }

  void OnPlayerDisconnected()
  {
    Debug.Log("A player has left the server.");
  }

  void OnFailedToConnect(NetworkConnectionError error)
  {
    Debug.Log("Could not connect to server: " + error);
  }

  void OnConnectedToServer()
  {
    Debug.Log("Connected to server.");
  }

  public void OnGUI()
  {
    if(GUI.Button(new Rect(25f,25f,150f,30f), "Start server"))
    {
      StartServer();
    }
    if (GUI.Button(new Rect(25f, 105f, 150f, 30f), "Join server"))
    {
      Debug.Log("Trying to connect to server...");
      ConnectToServer();
    }
  }
}
                                            