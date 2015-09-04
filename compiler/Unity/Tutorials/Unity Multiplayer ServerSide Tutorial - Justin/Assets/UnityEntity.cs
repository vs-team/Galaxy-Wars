using UnityEngine;

public class UnityEntity : MonoBehaviour
{
  public Color Color {
		get { return gameObject.renderer.material.color;}
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
>>>>>>> af6e3709317982f68fcf0c2873540bbc51940d03
    