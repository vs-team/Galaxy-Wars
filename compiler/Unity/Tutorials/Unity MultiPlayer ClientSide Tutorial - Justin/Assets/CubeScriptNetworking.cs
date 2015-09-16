using UnityEngine;
using System.Collections;
using Lidgren.Network;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public class CubeScriptNetworking : MonoBehaviour {

    public static NetClient netcli;

    public static CubeScriptNetworking Instantiate()
    {
        var conf = new NetPeerConfiguration("ServerSide");
        netcli = new NetClient(conf);
        netcli.Start();
        netcli.Connect("127.0.0.1", 443);
        Debug.Log("Connected to Server");
        var cube = GameObject.Instantiate((Resources.Load("Cube")), Vector3.zero, Quaternion.identity) as GameObject;
        return cube.GetComponent<CubeScriptNetworking>();
    }
	
    public Vector3 Position
    {
        get
        {
            var mess = netcli.CreateMessage();
            byte[] message = new byte[8];
            
            message[0] = 0;
            message[1] = 0;
            message[2] = 0;
            message[3] = 0;
            message[4] = 0;
            message[5] = 0;
            message[6] = 0;
            message[7] = 1;



            
            mess.Write(message);
            netcli.SendMessage(mess, NetDeliveryMethod.ReliableOrdered);
            Debug.Log("sent message");
            List<NetIncomingMessage> tes = new List<NetIncomingMessage>();
            var response = netcli.ReadMessages(tes);
            foreach (NetIncomingMessage n in tes)
            {
                //Debug.Log(n.ReadFloat());
            }
            if (tes.Count == 3)
            {
                Debug.Log(tes.Count);
                float temp1 = tes[0].ReadFloat();
                Debug.Log(temp1);
                float temp2 = tes[1].ReadFloat();
                Debug.Log(temp2);
                float temp3 = tes[2].ReadFloat();
                Debug.Log(temp3);
                Debug.Log(temp2 + temp3);
                var finvec = new Vector3(temp1, temp2, temp3);
                return finvec; 
            }
            else
            {
                return gameObject.transform.position;
            }
            
            
            
        }

        set
        {
            gameObject.transform.position = value;
        }
    }

    public byte[] intToBit(int e)
    {
        int size = 32;
        byte[] b = new byte[8];
        for (int i = 2; i < 8; i++)
        {
            if(e >= size)
            {
                b[i] = 1;
            }
            else
            {
                b[1] = 0;
            }
        }
        return b;

    }


}
                                                                                                                                                                                                                                                                                                                                                                 