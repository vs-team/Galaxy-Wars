using UnityEngine;
using System.Collections;

public class UnityBall : MonoBehaviour {
  public GameObject ball;
  public GameObject explosion;
  void Start () {
    ball = GameObject.Find("ball");
    Debug.Log(ball.transform.position);
    Instantiate();
	}
  public static UnityBall Instantiate()
  {
    GameObject ball = GameObject.Find("ball");
    UnityBall a = ball.GetComponent<UnityBall>();
    return a;
  }

  void Update () {
  }
  void OnCollisionEnter(Collision collision)
  {
    Debug.Log(collision.gameObject.name);
    var x = collision.gameObject.transform.position;
    Debug.Log(ball.transform.position);
    GameObject expl = Instantiate(explosion, ball.transform.position, Quaternion.identity) as GameObject;
    Destroy(ball);
    Destroy(expl, 3.0f);
  }

}
                      