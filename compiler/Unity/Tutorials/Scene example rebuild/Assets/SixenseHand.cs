
//
// Copyright (C) 2013 Sixense Entertainment Inc.
// All Rights Reserved
//

using UnityEngine;
using System.Collections;

public class SixenseHand : MonoBehaviour
{
	public SixenseHands	m_hand;
	public Controller m_controller = null;

	Animator 	m_animator;
	float 		m_fLastTriggerVal;
	Vector3		m_initialPosition;
	Quaternion 	m_initialRotation;

  public static SixenseHand Instantiate(string joystickName)
  {
    GameObject Razer = GameObject.Find(joystickName);
    SixenseHand handScript = Razer.GetComponent<SixenseHand>();
    return handScript;
  }


	protected void Start() 
	{
		// get the Animator
		m_animator = gameObject.GetComponent<Animator>();
		m_initialRotation = transform.localRotation;
		m_initialPosition = transform.localPosition;
	}
  public Quaternion m_initialRot
  {
    get { return m_initialRotation; }
    set { m_initialRotation = value; }
  }

	protected void Update()
	{
		if ( m_controller == null)
		{
			m_controller = SixenseInput.GetController( m_hand );
		}

		else if ( m_animator != null )
		{
      CheckHands();
		}
	}

  public void CheckHands()
  {
    if ( m_controller.GetButtonDown(SixenseButtons.ONE))
    {
      Debug.Log(RaycastBool);
    }
  }
  bool shot;
  public bool Shot
  {
    get { return shot; }
    set
    {
      shot = value;
    }
  }
  
  public bool Trigger {
    get {
      if (m_controller == null) return false;
      return m_controller.Trigger > 0; }
    set { }
  }

  public bool Bumper
  {
    get {
      if (m_controller == null) return false;
      return m_controller.GetButton(SixenseButtons.BUMPER); }
    set { }
  }
  public bool Drie
  {
    get
    {
      if(m_controller != null)
      {
        return m_controller.GetButton(SixenseButtons.THREE);
      }
      else
      {
        return false;
      }
    }
  }
  public bool Vier
  {
    get
    {
      if (m_controller != null)
      {
        return m_controller.GetButton(SixenseButtons.FOUR);
      }
      else
      {
        return false;
      }
    }
  }
  public bool Twee
  {
    get
    {
      if (m_controller != null)
      {
        return m_controller.GetButton(SixenseButtons.TWO);
      }
      else
      {
        return false;
      }
    }
  }

  public SixenseHands Hand { get { return m_controller.Hand; } }

  public Vector3 Position { get { return m_controller.Position; } }

  public Vector3 Forward { get { return transform.forward; } }

  public bool RaycastBool { get { return Physics.Raycast(transform.localPosition, transform.forward); } }

  public Quaternion InitialRotation { get { return m_initialRotation; } }
	
	public Vector3 InitialPosition { get { return m_initialPosition; } }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    