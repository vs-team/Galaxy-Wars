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
        public void sendRequest(NetClient n, int property, int id, int tag)
        {
            NetOutgoingMessage propertyMessage = n.CreateMessage();
            propertyMessage.Write(property);
            NetOutgoingMessage idMessage = n.CreateMessage();
            idMessage.Write(id);
            NetOutgoingMessage tagMessage = n.CreateMessage();
            tagMessage.Write(tag);
            n.SendMessage(propertyMessage, NetDeliveryMethod.ReliableOrdered);
            n.SendMessage(idMessage, NetDeliveryMethod.ReliableOrdered);
            n.SendMessage(tagMessage, NetDeliveryMethod.ReliableOrdered);
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
