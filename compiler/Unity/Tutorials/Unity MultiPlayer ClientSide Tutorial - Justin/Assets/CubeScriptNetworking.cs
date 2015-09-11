using UnityEngine;
using System.Collections;
using Lidgren.Network;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public class CubeScriptNetworking : MonoBehaviour {

    public static NetClient netcli;
    public static BinaryFormatter bf;
    public static MemoryStream ms;

    public static CubeScriptNetworking Instantiate()
    {
        bf = new BinaryFormatter();
        ms = new MemoryStream();
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
            mess.Write("Position request");
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


}
                                                                                                                                                                                                                                                                                                              