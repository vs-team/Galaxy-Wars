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
      var cube = GameObject.Find("Newcube");
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
                  var temp = GameObject.Find("Cube");
                  var pos = temp.transform.position;
                  Debug.Log(inc.ReadString());
                  var resp = serv.CreateMessage();
                  var resp2 = serv.CreateMessage();
                  var resp3 = serv.CreateMessage();
                  resp.Write((double)(pos.x));
                  resp2.Write((double)(pos.y));
                  resp3.Write((double)(pos.z));
                  inc.SenderConnection.SendMessage(resp, NetDeliveryMethod.ReliableOrdered, 3);
                  inc.SenderConnection.SendMessage(resp2, NetDeliveryMethod.ReliableOrdered, 3);
                  inc.SenderConnection.SendMessage(resp3, NetDeliveryMethod.ReliableOrdered, 3);
                  break;
              default:
                  Debug.Log("This type of message is not handled" + inc.MessageType);
                  Debug.Log(serv.ConnectionsCount);
                  break;
          }
      }



  }
}