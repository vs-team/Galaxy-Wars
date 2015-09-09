using UnityEngine;
using System.Collections;
using Lidgren.Network;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
            var response = netcli.ReadMessage();
            byte[] byteresp = response.ReadBytes(10);
            ms.Write(byteresp, 0,2);
            var finalresp = bf.Deserialize(ms);
            Debug.Log(finalresp);
            Debug.Log(response.ReadString());
            var resp = response.ReadString();
            return Vector3.zero;
        }

        set
        {
            gameObject.transform.position = value;
        }
    }


}
                                                                                                                                                                            