using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UnityToggle : MonoBehaviour {

    static Toggle toggler;

	public static UnityToggle Find(string name)
    {
        GameObject toggle = GameObject.Find(name);
        toggler = toggle.GetComponent<Toggle>();
        return toggle.GetComponent<UnityToggle>();
    }

    public static bool Toggled
    {
        get { return toggler.isOn; }
    }
}
                                                                                                                                                   