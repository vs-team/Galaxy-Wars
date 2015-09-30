using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UnityToggle : MonoBehaviour {

	public static UnityToggle Find(string name)
    {
        GameObject toggle = GameObject.Find(name);
        return toggle.GetComponent<UnityToggle>();
    }

    public bool Toggled
    {
        get { return this.GetComponent<Toggle>(); }
    }
}
                                                                           