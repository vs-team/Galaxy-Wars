using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UnityButton : MonoBehaviour {

    private static bool clicked;
    private static Text buttonText;

    public static UnityButton Find(string name)
    {
        GameObject button = GameObject.Find(name);
        button.GetComponent<Button>().onClick.AddListener(() => { clicked = true; });
        buttonText = button.transform.FindChild("ButtonText").GetComponent<Text>();
        clicked = false;
        return button.GetComponent<UnityButton>();
    }

    public static bool Clicked
    {
        get { return clicked; }
    }

    public static string ButtonText
    {
        get { return buttonText.text; }
        set { buttonText.text = value; }
    }
}
                                                                                            