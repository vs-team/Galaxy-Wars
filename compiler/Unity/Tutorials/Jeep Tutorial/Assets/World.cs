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
		Velocity = new UnityEngine.Vector3(0f,0f,0f);
		TruckScript = TruckScript.Instantiate();
		
}
		public UnityEngine.Vector3 Position{  get { return TruckScript.Position; }
  set{TruckScript.Position = value; }
 }
	public UnityEngine.Vector3 Rotation{  get { return TruckScript.Rotation; }
  set{TruckScript.Rotation = value; }
 }
	public TruckScript TruckScript;
	public UnityEngine.Vector3 Velocity;
	public System.Boolean enabled{  get { return TruckScript.enabled; }
  set{TruckScript.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return TruckScript.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return TruckScript.hideFlags; }
  set{TruckScript.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return TruckScript.isActiveAndEnabled; }
 }
	public System.String name{  get { return TruckScript.name; }
  set{TruckScript.name = value; }
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
frame = World.frame;

		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	Position = ((Position) + (((Velocity) * (dt))));
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(UnityEngine.Input.GetKey(KeyCode.W))
	{

	goto case 14;	}else
	{

	goto case 10;	}
	case 14:
	Velocity = ((Velocity) + (new UnityEngine.Vector3(0f,0f,1f)));
	s1 = 10;
return;
	case 10:
	if(((UnityEngine.Input.GetKey(KeyCode.A)) && (((Velocity.z) > (0f)))))
	{

	goto case 11;	}else
	{

	goto case 7;	}
	case 11:
	Velocity = ((Velocity) + (new UnityEngine.Vector3(-0.2f,0f,0f)));
	s1 = 7;
return;
	case 7:
	if(((UnityEngine.Input.GetKey(KeyCode.D)) && (((Velocity.z) > (0f)))))
	{

	goto case 8;	}else
	{

	goto case 4;	}
	case 8:
	Velocity = ((Velocity) + (new UnityEngine.Vector3(0.2f,0f,0f)));
	s1 = 4;
return;
	case 4:
	if(UnityEngine.Input.GetKey(KeyCode.Space))
	{

	goto case 5;	}else
	{

	goto case 1;	}
	case 5:
	Velocity = ((Velocity) + (new UnityEngine.Vector3(0f,0f,-0.8f)));
	s1 = 1;
return;
	case 1:
	if(((Velocity.z) > (0)))
	{

	goto case 2;	}else
	{

	s1 = -1;
return;	}
	case 2:
	Velocity = ((Velocity) + (new UnityEngine.Vector3(0f,0f,-0.2f)));
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	Rotation = ((Rotation) + (new UnityEngine.Vector3(0f,(Velocity.x) * (dt),0f)));
	s2 = -1;
return;	
	default: return;}}
	





}
}        