using UnityEngine;
using System.Collections;

public class UnityPlayerHealth : MonoBehaviour {

    GameObject life1;
    GameObject life2;
    GameObject life3;

	public static UnityPlayerHealth Instantiate(Vector3 pos)
    {
        GameObject Health = GameObject.Instantiate(Resources.Load("HealthBar"), pos, Quaternion.identity) as GameObject;
        var script = Health.GetComponent<UnityPlayerHealth>();
        script.life1 = script.transform.FindChild("Life1").gameObject as GameObject;
        script.life2 = script.transform.FindChild("Life2").gameObject as GameObject;
        script.life3 = script.transform.FindChild("Life3").gameObject as GameObject;
        return Health.GetComponent<UnityPlayerHealth>();
    }

    public bool FirstLife
    {
        get { return life1.active; }
        set { life1.SetActive(value); }
    }

    public bool SecondLife
    {
        get { return life2.active; }
        set { life2.SetActive(value); }
    }

    public bool ThirdLife
    {
        get { return life3.active; }
        set { life3.SetActive(value); }
    }


}
                                                                                                                                                                                                                                                                                                                    