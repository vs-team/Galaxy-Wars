using UnityEngine;

public class UnityEntity : MonoBehaviour
{
    public Color Color
    {
        get { return gameObject.renderer.material.color; }
        set { gameObject.renderer.material.color = value; }
    }

    public static UnityEntity Find()
    {
        return GameObject.Find("/Cube").GetComponent<UnityEntity>();
    }

<<<<<<< HEAD
}                                                                                                        
=======
}           
>>>>>>> 0a1a55ec895325c2dcafa9037d6353303806410b
