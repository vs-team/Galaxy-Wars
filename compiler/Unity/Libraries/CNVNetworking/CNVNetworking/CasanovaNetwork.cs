using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lidgren.Network;
using UnityEngine;
using UnityEngineInternal;

namespace CNVNetworking
{
    public class Messaging
    {
        public void sendRequest(NetClient n, int id, byte property)
        {
            NetOutgoingMessage propertyMessage = n.CreateMessage();
            propertyMessage.Write(id);
            NetOutgoingMessage idMessage = n.CreateMessage();
            idMessage.Write(property);
            n.SendMessage(idMessage, NetDeliveryMethod.ReliableOrdered);
            n.SendMessage(propertyMessage, NetDeliveryMethod.ReliableOrdered);
        }

        public NetClient connectToServer(string ip, int port, string appname, int playernr, int entityID)
        {
            NetPeerConfiguration npc = new NetPeerConfiguration(appname);
            NetClient n = new NetClient(npc);
            n.Connect(ip, port);
            Debug.Log("Connected succesfully!");
            NetOutgoingMessage mess = n.CreateMessage();
            mess.Write(playernr);
            NetOutgoingMessage nm = n.CreateMessage();
            nm.Write(entityID);
            n.SendMessage(mess, NetDeliveryMethod.ReliableOrdered);
            n.SendMessage(nm, NetDeliveryMethod.ReliableOrdered);
            Debug.Log("Cleared identity with server!");
            return n;
        }
        public void handleRequest(NetServer s)
        {
            NetIncomingMessage inc;
            if ((inc = s.ReadMessage()) != null)
            {
                switch (inc.MessageType)
                {
                    case NetIncomingMessageType.Data:
                        break;

                    default:

                        break;
                }
            }

        }

    }
}
