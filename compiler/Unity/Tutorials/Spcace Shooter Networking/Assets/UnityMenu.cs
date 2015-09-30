using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UnityMenu : MonoBehaviour {
 

	public static UnityMenu Find()
    {
        GameObject menu = GameObject.Find("Menu");
        return menu.GetComponent<UnityMenu>();
    }

    

}
 

                                                                                                                                                                           