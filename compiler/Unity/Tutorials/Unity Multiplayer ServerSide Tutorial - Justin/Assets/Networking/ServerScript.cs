using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Lidgren.Network;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class ServerScript : MonoBehaviour
{
  public BinaryFormatter bf;
  public MemoryStream ms;
  public NetServer serv;
  public NetworkView networkView;
  public NetIncomingMessage inc;
  // Use this for initialization

  public void Start()
  {
      bf = new BinaryFormatter();
      ms = new MemoryStream();
      GameObject var = GameObject.Find("Cube");
      var cube = GameObject.Find("Cube");
      var script = cube.GetComponent<ServerScript>();
      var test = new NetPeerConfiguration("ServerSide");
      test.LocalAddress = NetUtility.Resolve("localhost");
      test.EnableMessageType(NetIncomingMessageType.ConnectionApproval);
      test.MaximumConnections = 512;
      test.Port = 443;
      serv = new NetServer(test);
      serv.Start();
      Debug.Log("Server is running!");
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
                  Debug.Log("incoming");
                  break;
              case NetIncomingMessageType.Data:
                  Debug.Log(inc.ReadString());
                  var vec = 4.0f;
                  bf.Serialize(ms, vec);
                  byte[] byt = ms.GetBuffer();
                  Debug.Log(byt);
                  var resp = serv.CreateMessage();
                  resp.Write(byt);
                  inc.SenderConnection.SendMessage(resp, NetDeliveryMethod.ReliableOrdered, 3);
                  break;
              default:
                  Debug.Log("This type of message is not handled" + inc.MessageType);
                  Debug.Log(serv.ConnectionsCount);
                  break;
          }
      }



  }
}