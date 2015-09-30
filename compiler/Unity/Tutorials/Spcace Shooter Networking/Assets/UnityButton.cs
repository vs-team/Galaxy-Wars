using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UnityButton : MonoBehaviour {

    private static Text buttonText;

    public static UnityButton Find(string name)
    {
        GameObject button = GameObject.Find(name);
        button.GetComponent<Button>().onClick.AddListener(() => { Clicked = true; });
        buttonText = button.transform.FindChild("ButtonText").GetComponent<Text>();
        Clicked = false;
        return button.GetComponent<UnityButton>();
    }

    public static bool Clicked
    {
        get;set; 
    }

    public static string ButtonText
    {
        get { return buttonText.text; }
        set { buttonText.text = value; }
    }
}
                                                                                                                                                                    