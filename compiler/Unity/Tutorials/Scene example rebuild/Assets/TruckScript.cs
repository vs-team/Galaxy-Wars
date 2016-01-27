using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Casanova.Prelude;
using System.Linq;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TruckScript : MonoBehaviour
{
  public Rigidbody truckRigidBody;
  public WheelCollider FrontLeftWheel;
  public WheelCollider FrontRightWheel;
  public WheelCollider RearLeftWheel;
  public WheelCollider RearRightWheel;
  private List<WheelCollider> wheels;
  public Light HeadlightLeft;
  public Light HeadlightRight;
  private float CarHP = 1.0f;
  //public Collider shield;
  private List<UnityZombie2> collidedWithThisFrame;
  private TextMesh score;
  private TextMesh multiplier;
  private bool destroyed;
  private Vector3 prevVelocity;
  public AudioClip Audio_Driving;
  public AudioClip Audio_DamageSmall;
  public AudioClip Audio_DamageBig;
  private AudioSource AudioS;

  public static TruckScript Instantiate(string nm, Vector3 pos)
  {
    GameObject jeepGameObject = GameObject.Instantiate(Resources.Load("Jeeps/" + nm), pos, Quaternion.identity) as GameObject;
    TruckScript truck = jeepGameObject.GetComponent<TruckScript>() as TruckScript;
    truck.AudioS = jeepGameObject.GetComponent<AudioSource>() as AudioSource;
    truck.truckRigidBody = jeepGameObject.GetComponent<Rigidbody>() as Rigidbody;

    truck.FrontLeftWheel = truck.transform.Find("SUV_wheel_front_left").GetComponent<WheelCollider>() as WheelCollider;
    truck.FrontRightWheel = truck.transform.Find("SUV_wheel_front_right").GetComponent<WheelCollider>() as WheelCollider;
    truck.RearLeftWheel = truck.transform.Find("SUV_wheel_rear_left").GetComponent<WheelCollider>() as WheelCollider;
    truck.RearRightWheel = truck.transform.Find("SUV_wheel_rear_right").GetComponent<WheelCollider>() as WheelCollider;

    truck.HeadlightLeft = truck.transform.Find("LeftLight").GetComponent<Light>() as Light;
    truck.HeadlightRight = truck.transform.Find("RightLight").GetComponent<Light>() as Light;

    //truck.shield = truck.transform.Find("Shield").GetComponent<Collider>() as Collider;
    truck.collidedWithThisFrame = new List<UnityZombie2>();
    truck.score = truck.transform.Find("Main Camera/Score").GetComponent<TextMesh>() as TextMesh;
    truck.t = truck.transform.Find("Main Camera/Text").GetComponent<TextMesh>() as TextMesh;
    truck.multiplier = truck.transform.Find("Main Camera/Multiplier").GetComponent<TextMesh>() as TextMesh;

    return truck;
  }
  private TextMesh t;
  void Start()
  {

    PlayerPrefs.DeleteKey("ReachedByPlayer");
    PlayerPrefs.Save();
    multiplier.gameObject.SetActive(false);
    MultiplierBonus = 1.0f;
    /*
    PlayerPrefs.DeleteAll();
    string[] names = { "Piet", "Klaas", "Henk" };
    for (int i = TopScoreSize; i > 0; i--)
    {
      var score = 400 - i * 30;
      PlayerPrefs.SetInt("score: " + i, score); //score
      int j = Random.Range(0, (names.Length));
      PlayerPrefs.SetString("posit: " + i, names[j]);
    }
    //*/
  }
  public float Rotz
  {
    get { return this.gameObject.transform.rotation.z; }
  }
  private bool rotate;
  public bool flip
  {
    get { return rotate; }
    set
    {
      rotate = value;
      if (value)
      {
        truckRigidBody.velocity = Vector3.zero;
        this.gameObject.transform.position = new Vector3(0, -6.94f, Position.z);
        this.gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
      }
    }
  }

  public Vector3 InputPosition
  {
    get { return transform.Find("InputPosition").position; }
  }
  public string Score
  {
    get { return score.text; }
    set { score.text = "Score: " + value; }
  }
  public bool Invullen;

  private int counter = 0;
  private int added = 0;
  private int TopScoreSize = 8;
  public float MultiplierBonus;
  public float Multip
  {
    get { return float.Parse(multiplier.text.Substring(2)); }
    set
    {
      if (value > 1.0f)
      {
        multiplier.gameObject.SetActive(true);
        MultiplierBonus = value;
        multiplier.text = "x " + (value);
      }
      else
      {
        multiplier.gameObject.SetActive(false);
      }
    }
  }
  private int GameOver_p;
  public int GameOver
  {
    get { return GameOver_p; }
    set
    {
      GameOver_p = value;
      if (value == 5)
      {

        //score
        var scorString = Score.Substring(7);
        int scoreInt = int.Parse(scorString);
        int ad = Random.Range(100, 1150);
        int totscore = scoreInt;

        //Top TopScoreSize players with their scores
        List<Tuple<string, int>> Topscores = new List<Tuple<string, int>>();
        for (int i = 1; i <= TopScoreSize; i++)
        {
          string key = i.ToString();
          var j = new Casanova.Prelude.Tuple<string, int>(PlayerPrefs.GetString("posit: " + i), PlayerPrefs.GetInt("score: " + i));
          Topscores.Add(j); // Tuple<name, score>
        }
        foreach (Tuple<string, int> a in Topscores)
        {
          if ((counter) == Topscores.Length()) // after toplist, stop
          {
            break;
          }

          counter++;
          if (a.Item2 < totscore && added == 0)
          {
            PlayerPrefs.SetString("pos" + counter.ToString(), "NameNotSetYet"); // pos1 + NameNotSetUet
            PlayerPrefs.SetInt("scor" + counter, totscore);
            added = counter;
            counter++;
          }
          PlayerPrefs.SetString("posit: " + counter, a.Item1);
          PlayerPrefs.SetInt("score: " + counter, a.Item2);

        }
        Debug.Log("totscore" + totscore);
        PlayerPrefs.Save();
        if (added != 0)
        {
          Application.LoadLevel(4);
        }
        else
        {
          PlayerPrefs.SetInt("ReachedByPlayer", totscore);
          Debug.Log("ts = " + PlayerPrefs.GetInt("ReachedByPlayer"));
          PlayerPrefs.Save();
          Application.LoadLevel(2);
        }
      }
      else
      {
        if (value == 1)
        {
          t.text = "1";
        }
        if (value == 2)
        {
          t.text = "2";
        }
        if (value == 3)
        {
          t.text = "3";
        }
        if (value == 4)
        {
          t.text = "Out of Fuel";
        }

      }
    }
  }
  public Vector3 PrevVelocity
  {
    get { return prevVelocity; }
    set { prevVelocity = value; }
  }

  public bool Destroyed
  {
    get { return destroyed; }
    set
    {
      destroyed = value;
      if (destroyed)
        GameObject.Destroy(gameObject);
    }
  }

  public Vector3 Position
  {
    get { return this.transform.position; }
  }

  public Quaternion Rotation
  {
    get { return this.transform.localRotation; }
  }
  public float RotationY
  {
    get
    {
      return this.transform.eulerAngles.y;
    }
  }
  public Vector3 COM
  {
    get { return COM; }
    set { truckRigidBody.centerOfMass = value; }
  }

  public Vector3 CenterOfMass
  {
    get { return truckRigidBody.centerOfMass; }
    set { truckRigidBody.centerOfMass = value; }
  }

  public float Frce
  {
    set
    {
      truckRigidBody.MovePosition(transform.position + transform.forward * value * -1.0f);
    }
  }
  public Vector3 Trque
  {
    set
    {
      Quaternion deltaRotation = Quaternion.Euler(value * Time.deltaTime);
      truckRigidBody.MoveRotation(truckRigidBody.rotation * deltaRotation);
    }
  }
  public bool HeadlightRightOn
  {
    get { return HeadlightRight.enabled; }
    set { HeadlightRight.enabled = value; }
  }

  public bool HeadlightLeftOn
  {
    get { return HeadlightLeft.enabled; }
    set { HeadlightLeft.enabled = value; }
  }
  public float BrakeAndReverse
  {
    get
    {
      if (Input.GetAxisRaw("SW_Joy0Y") >= 0.0f)
      {
        return 0.0f;
      }
      else
      {
        return (Input.GetAxisRaw("SW_Joy0Y") * -1.0f);
      }
    }
  }

  public float Acceleration
  {
    get
    {
      if (Input.GetAxisRaw("SW_Joy0Y") < 0.0f)
      {
        return 0.0f;
      }
      else
      {
        return Input.GetAxis("SW_Joy0Y");
      }
    }
  }
  private bool CollWithModel;
  public bool CollisionWithModel
  {
    get { return CollWithModel; }
    set { CollWithModel = value; }
  }
  void OnCollisionEnter(Collision collision)
  {
    Debug.Log(collision.gameObject.name);
    if (collision.gameObject.tag == "TruckModel")
    {
      CollWithModel = true;
    }
    else if (collision.transform.root.tag == "Zombiegroup")
    {
      truckRigidBody.velocity = prevVelocity;
      UnityZombie2 hitZombie = collision.transform.GetComponentInParent<UnityZombie2>();
      if (!collidedWithThisFrame.Contains(hitZombie) && !hitZombie.CollidedWithCar)
      {
        collidedWithThisFrame.Add(hitZombie);
        if (collision.relativeVelocity.magnitude > 10.0f)
        {
          hitZombie.GetHit(-collision.relativeVelocity.normalized, collision.transform, collision.rigidbody,
                           collision.collider, collision.relativeVelocity.magnitude / 30.0f, true, 2);

          if (!hitZombie.Dead)
          {
            CarHP -= collision.relativeVelocity.magnitude / 100;
          }
        }
      }
    }
    else if (collision.relativeVelocity.magnitude > 10.0f && collision.transform.tag != "Bullets")
    {
      CarHP -= collision.relativeVelocity.magnitude / 100;
      CarHPChanged = collision.relativeVelocity.magnitude;
    }
  }
  public float tim;
  public float Dama
  {
    get { return CarHPChanged; }
    set
    {
      if (CarHPChanged > 3.0f)
      {
        AudioS.clip = Audio_DamageBig;
        tim = AudioS.clip.length;
        CarHPChanged = 0.0f;
        AudioS.Play();
      }
      else if (CarHPChanged > 1.0f)
      {
        AudioS.clip = Audio_DamageSmall;
        tim = AudioS.clip.length;
        CarHPChanged = 0.0f;
        AudioS.Play();
      }
    }
  }
  public float driv
  {
    get { return tim; }
    set
    {
      if (value == 0.0f)
      {
        AudioS.Stop();
      }
      else if (value == 0.5f)
      {
        return;
      }
      else
      {
        AudioS.clip = Audio_Driving;
        tim = AudioS.clip.length;
        AudioS.Play();
      }
    }
  }
  public float CarHP2
  {
    get { return CarHP; }
    set
    {
      CarHP = value;
    }
  }

  public float CarHPChanged;

  void LateUpdate()
  {
    if (collidedWithThisFrame.Count > 0)
      collidedWithThisFrame.Clear();
  }
}                                                                