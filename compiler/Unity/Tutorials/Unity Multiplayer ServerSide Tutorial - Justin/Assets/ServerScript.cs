using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Lidgren.Network;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class ServerScript : MonoBehaviour
{
  public NetServer serv;
  public NetIncomingMessage inc;

  public void Start()
  {
    
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
                  byte[] incData = new byte[8];
                  inc.ReadBytes(8, out incData);
                  for (int i = 0; i < 8; i++)
                  {
                      Debug.Log(incData[i]);
                  }
                  switch(incData[0])
                  {
                      case 0:
                          if(incData[1]==0)
                          {
                                var t = bitToInt(incData);
                                Debug.Log(t);
                                var temp = GameObject.Find(t.ToString());
                                var pos = temp.transform.position;
                                Debug.Log(inc.ReadString());
                                var resp = serv.CreateMessage();
                                var resp2 = serv.CreateMessage();
                                var resp3 = serv.CreateMessage();
                                resp.Write((pos.x));
                                resp2.Write((pos.y));
                                resp3.Write((pos.z));
                                inc.SenderConnection.SendMessage(resp, NetDeliveryMethod.ReliableOrdered, 3);
                                inc.SenderConnection.SendMessage(resp2, NetDeliveryMethod.ReliableOrdered, 3);
                                inc.SenderConnection.SendMessage(resp3, NetDeliveryMethod.ReliableOrdered, 3);
                              break;                    //this option is preset for Position.
                          }
                          else
                          {
                              break;                    //this option is preset for rotation.
                          }

                      case 1:
                          if(incData[1]==0)
                          {
                              break;                    //this option is preset for animations.
                          }
                          else
                          {
                              break;                    //this option is preset for ...
                          }

                      default:
                          Debug.Log("Something went wrong");
                          break;
                  }
                  
                  
                  
                  break;
              default:
                  Debug.Log("This type of message is not handled" + inc.MessageType);
                  Debug.Log(serv.ConnectionsCount);
                  break;
          }
      }
  }

      public int bitToInt(byte[] b)
      {
            int ID = 0;
            int size = 32;
            for (int i = 2; i < 8; i++)
			   {
			    if(b[i]==1)
                {
                    ID += size;
                    
                }
                size = size / 2;
                   
			   }
               return ID;     
      }

  
}                                                                              