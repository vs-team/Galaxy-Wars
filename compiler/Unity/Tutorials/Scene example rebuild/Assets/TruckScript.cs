using UnityEngine;
using System.Collections;

public class TruckScript : MonoBehaviour
{

  public Rigidbody truckRigidBody;
  public WheelCollider FrontLeftWheel;
  public WheelCollider FrontRightWheel;
  public WheelCollider RearLeftWheel;
  public WheelCollider RearRightWheel;
  public Light HeadlightLeft;
  public Light HeadlightRight;
  private float CarHP = 1.0f;
  public Collider shield;
  private TextMesh MagazineBox;

  public static TruckScript Instantiate()
  {
    GameObject jeepGameObject = GameObject.Find("truck");
    TruckScript truck = jeepGameObject.GetComponent<TruckScript>() as TruckScript;

    truck.FrontLeftWheel = GameObject.Find("SUV_wheel_front_left").GetComponent<WheelCollider>() as WheelCollider;
    truck.FrontRightWheel = GameObject.Find("SUV_wheel_front_right").GetComponent<WheelCollider>() as WheelCollider;
    truck.RearLeftWheel = GameObject.Find("SUV_wheel_rear_left").GetComponent<WheelCollider>() as WheelCollider;
    truck.RearRightWheel = GameObject.Find("SUV_wheel_rear_right").GetComponent<WheelCollider>() as WheelCollider;
    truck.HeadlightLeft = GameObject.Find("LeftLight").GetComponent<Light>() as Light;
    truck.HeadlightRight = GameObject.Find("RightLight").GetComponent<Light>() as Light;
    truck.truckRigidBody = jeepGameObject.GetComponent<Rigidbody>() as Rigidbody;
    truck.shield = GameObject.Find("Shield").GetComponent<Collider>() as Collider;
    truck.MagazineBox = GameObject.Find("Bullets").GetComponent<TextMesh>() as TextMesh;
    return truck;
  }
  public Vector3 Position
  {
    get { return this.transform.position; }
  }
  public int InMag;
  public int NotInMag;
  public string MagazineGUI
  {
    get { return MagazineBox.text; }
    set { MagazineBox.text = InMag + "/" + NotInMag; }
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

  public float Steering
  {
    get { return Input.GetAxis("SW_Joy0X"); }
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

  void OnCollisionEnter(Collision collision)
  {
    if(collision.relativeVelocity.magnitude > 15.0f)
    {
      CarHP = CarHP - collision.relativeVelocity.magnitude / 200;
    }
  }

  public float CarHP2
  {
    get { return CarHP; }
    set { CarHP2 = CarHP; }
  }
  void Update()
  { 
    //Physics.IgnoreCollision(shield, UnityPlane.planeBox, true);
  }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        