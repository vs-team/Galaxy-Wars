#pragma warning disable 162,108,618
using Casanova.Prelude;
using System.Linq;
using System;
using System.Collections.Generic;
using UnityEngine;
namespace Game {public class World : MonoBehaviour{
public static int frame;
void Update () { Update(Time.deltaTime, this); 
 frame++; }
public bool JustEntered = true;


public void Start()
	{
		Jeep = new Truck();
		
}
		public Truck Jeep;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;

		Jeep.Update(dt, world);


	}











}
public class Truck{
public int frame;
public bool JustEntered = true;
	public int ID;
public Truck()
	{JustEntered = false;
 frame = World.frame;
		Velocity = 0f;
		TruckScript = TruckScript.Instantiate();
		
}
		public UnityEngine.Vector3 Position{  get { return TruckScript.Position; }
  set{TruckScript.Position = value; }
 }
	public UnityEngine.Vector3 Rotation{  get { return TruckScript.Rotation; }
  set{TruckScript.Rotation = value; }
 }
	public TruckScript TruckScript;
	public System.Single Velocity;
	public UnityEngine.Animation animation{  get { return TruckScript.animation; }
 }
	public UnityEngine.AudioSource audio{  get { return TruckScript.audio; }
 }
	public UnityEngine.Camera camera{  get { return TruckScript.camera; }
 }
	public UnityEngine.Collider collider{  get { return TruckScript.collider; }
 }
	public UnityEngine.Collider2D collider2D{  get { return TruckScript.collider2D; }
 }
	public UnityEngine.ConstantForce constantForce{  get { return TruckScript.constantForce; }
 }
	public System.Boolean enabled{  get { return TruckScript.enabled; }
  set{TruckScript.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return TruckScript.gameObject; }
 }
	public UnityEngine.GUIElement guiElement{  get { return TruckScript.guiElement; }
 }
	public UnityEngine.GUIText guiText{  get { return TruckScript.guiText; }
 }
	public UnityEngine.GUITexture guiTexture{  get { return TruckScript.guiTexture; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return TruckScript.hideFlags; }
  set{TruckScript.hideFlags = value; }
 }
	public UnityEngine.HingeJoint hingeJoint{  get { return TruckScript.hingeJoint; }
 }
	public UnityEngine.Light light{  get { return TruckScript.light; }
 }
	public System.String name{  get { return TruckScript.name; }
  set{TruckScript.name = value; }
 }
	public UnityEngine.ParticleEmitter particleEmitter{  get { return TruckScript.particleEmitter; }
 }
	public UnityEngine.ParticleSystem particleSystem{  get { return TruckScript.particleSystem; }
 }
	public UnityEngine.Renderer renderer{  get { return TruckScript.renderer; }
 }
	public UnityEngine.Rigidbody rigidbody{  get { return TruckScript.rigidbody; }
 }
	public UnityEngine.Rigidbody2D rigidbody2D{  get { return TruckScript.rigidbody2D; }
 }
	public System.String tag{  get { return TruckScript.tag; }
  set{TruckScript.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return TruckScript.transform; }
 }
	public System.Boolean useGUILayout{  get { return TruckScript.useGUILayout; }
  set{TruckScript.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;		this.Rule1(dt, world);

		this.Rule0(dt, world);
		this.Rule2(dt, world);
	}

	public void Rule1(float dt, World world) 
	{
	Position = new UnityEngine.Vector3(0f,0f,(Position.z) + ((Velocity) * (dt)));
	}
	




	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(UnityEngine.Input.GetKey(KeyCode.W))
	{

	goto case 7;	}else
	{

	goto case 3;	}
	case 7:
	Velocity = ((Velocity) + (1f));
	s0 = 3;
return;
	case 3:
	if(((UnityEngine.Input.GetKey(KeyCode.Space)) && (((Velocity) > (0f)))))
	{

	goto case 4;	}else
	{

	goto case 0;	}
	case 4:
	Velocity = ((Velocity) - (0.9f));
	s0 = 0;
return;
	case 0:
	if(((!(UnityEngine.Input.GetKey(KeyCode.W))) && (((Velocity) > (0f)))))
	{

	goto case 1;	}else
	{

	s0 = -1;
return;	}
	case 1:
	Velocity = ((Velocity) - (0.2f));
	s0 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(((UnityEngine.Input.GetKey(KeyCode.A)) && (((((Rotation.y) > (135f))) || (((45f) > (Rotation.y)))))))
	{

	goto case 14;	}else
	{

	goto case 9;	}
	case 14:
	UnityEngine.Debug.Log(Rotation);
	Rotation = ((Rotation) + (new UnityEngine.Vector3(0f,-0.2f,0f)));
	s2 = 9;
return;
	case 9:
	if(((UnityEngine.Input.GetKey(KeyCode.D)) && (((((Rotation.y) > (135f))) || (((45f) > (Rotation.y)))))))
	{

	goto case 10;	}else
	{

	s2 = -1;
return;	}
	case 10:
	UnityEngine.Debug.Log(Rotation);
	Rotation = ((Rotation) + (new UnityEngine.Vector3(0f,0.2f,0f)));
	s2 = -1;
return;	
	default: return;}}
	





}
}       