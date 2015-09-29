using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerLobby : MonoBehaviour {

    // Use this for initialization
    public PlayerLobby find()
    {
        return GameObject.Find("LobbyInfo").GetComponent<PlayerLobby>();
    }

    public string Text
    {
        get { return this.gameObject.transform.GetComponent<Text>().text; }
        set { this.gameObject.transform.GetComponent<Text>().text = value; }
    }
}
                                 