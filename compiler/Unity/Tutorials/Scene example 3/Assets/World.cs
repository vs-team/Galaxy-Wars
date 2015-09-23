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
		Landscapes = (

(new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,0f)),(new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,-80f)),(new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,-160f)),(new Empty<Landscape>()).ToList<Landscape>())).ToList<Landscape>())).ToList<Landscape>())).ToList<Landscape>()).ToList<Landscape>();
		Jeep = new Truck();
		
}
		public Truck Jeep;
	public List<Landscape> __Landscapes;
	public List<Landscape> Landscapes{  get { return  __Landscapes; }
  set{ __Landscapes = value;
 foreach(var e in value){if(e.JustEntered){ e.JustEntered = false;
}
} }
 }
	public List<Landscape> ___destroyed_filter00;
	public List<Landscape> ___a10;
	public Landscape ___headOfA10;
	public UnityEngine.Transform ___headOfATransform10;
	public UnityEngine.Vector3 ___headOfAPosition10;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;

		Jeep.Update(dt, world);
		for(int x0 = 0; x0 < Landscapes.Count; x0++) { 
			Landscapes[x0].Update(dt, world);
		}
		this.Rule0(dt, world);
		this.Rule1(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	___destroyed_filter00 = (

(Landscapes).Select(__ContextSymbol1 => new { ___e00 = __ContextSymbol1 })
.Where(__ContextSymbol2 => !(__ContextSymbol2.___e00.Destroyed))
.Select(__ContextSymbol3 => __ContextSymbol3.___e00)
.ToList<Landscape>()).ToList<Landscape>();
	Landscapes = ___destroyed_filter00;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	___a10 = (

(Landscapes).Select(__ContextSymbol4 => new { ___e11 = __ContextSymbol4 })
.Where(__ContextSymbol5 => __ContextSymbol5.___e11.Checkpoint.isEntered)
.Select(__ContextSymbol6 => __ContextSymbol6.___e11)
.ToList<Landscape>()).ToList<Landscape>();
	if(((___a10.Count) > (0)))
	{

	goto case 3;	}else
	{

	s1 = -1;
return;	}
	case 3:
	___headOfA10 = ___a10.Head();
	___headOfATransform10 = ___headOfA10.transform;
	___headOfAPosition10 = ___headOfATransform10.position;
	Landscapes = new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,(___headOfAPosition10.z) - (240f))), (Landscapes)).ToList<Landscape>();
	s1 = -1;
return;	
	default: return;}}
	





}
public class Landscape{
public int frame;
public bool JustEntered = true;
private UnityEngine.Vector3 StartP;
	public int ID;
public Landscape(UnityEngine.Vector3 StartP)
	{JustEntered = false;
 frame = World.frame;
		hasSpawned = false;
		Zombies = (

Enumerable.Empty<Zombie>()).ToList<Zombie>();
		UnityLandscape = UnityLandscape.Instantiate(StartP);
		SP = (

Enumerable.Empty<UnityEngine.Transform>()).ToList<UnityEngine.Transform>();
		DestroyDistance = 500f;
		
}
		public UnityCheckpoint Checkpoint{  get { return UnityLandscape.Checkpoint; }
 }
	public System.Single DestroyDistance;
	public System.Boolean Destroyed{  get { return UnityLandscape.Destroyed; }
  set{UnityLandscape.Destroyed = value; }
 }
	public UnityEngine.Vector3 LocPosition{  get { return UnityLandscape.LocPosition; }
  set{UnityLandscape.LocPosition = value; }
 }
	public UnityEngine.Vector3 Position{  get { return UnityLandscape.Position; }
  set{UnityLandscape.Position = value; }
 }
	public List<UnityEngine.Transform> SP;
	public System.Collections.Generic.List<UnityEngine.Transform> Spawnpoints2{  get { return UnityLandscape.Spawnpoints2; }
 }
	public UnityLandscape UnityLandscape;
	public List<Zombie> Zombies;
	public System.Boolean enabled{  get { return UnityLandscape.enabled; }
  set{UnityLandscape.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityLandscape.gameObject; }
 }
	public System.Boolean hasSpawned;
	public UnityEngine.HideFlags hideFlags{  get { return UnityLandscape.hideFlags; }
  set{UnityLandscape.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityLandscape.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityLandscape.name; }
  set{UnityLandscape.name = value; }
 }
	public System.String tag{  get { return UnityLandscape.tag; }
  set{UnityLandscape.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityLandscape.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityLandscape.useGUILayout; }
  set{UnityLandscape.useGUILayout = value; }
 }
	public UnityEngine.Vector3 ___SPHP20;
	public void Update(float dt, World world) {
frame = World.frame;		this.Rule0(dt, world);
		this.Rule3(dt, world);
		for(int x0 = 0; x0 < Zombies.Count; x0++) { 
			Zombies[x0].Update(dt, world);
		}
		this.Rule1(dt, world);
		this.Rule2(dt, world);
	}

	public void Rule0(float dt, World world) 
	{
	SP = (

(Spawnpoints2).Select(__ContextSymbol11 => new { ___a01 = __ContextSymbol11 })
.Select(__ContextSymbol12 => __ContextSymbol12.___a01)
.ToList<UnityEngine.Transform>()).ToList<UnityEngine.Transform>();
	}
	

	public void Rule3(float dt, World world) 
	{
	Zombies = (

(Zombies).Select(__ContextSymbol13 => new { ___a32 = __ContextSymbol13 })
.Where(__ContextSymbol14 => !(__ContextSymbol14.___a32.Destroyed))
.Select(__ContextSymbol15 => __ContextSymbol15.___a32)
.ToList<Zombie>()).ToList<Zombie>();
	}
	



	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(!(Checkpoint.isEntered))
	{

	s1 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	Checkpoint.isEntered = Checkpoint.isEntered;
	s1 = 0;
return;
	case 0:
	Checkpoint.isEntered = false;
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(!(!(hasSpawned)))
	{

	s2 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	___SPHP20 = SP.Head().position;
	Zombies = new Cons<Zombie>(new Zombie(___SPHP20), (Zombies)).ToList<Zombie>();
	hasSpawned = true;
	s2 = -1;
return;	
	default: return;}}
	





}
public class Truck{
public int frame;
public bool JustEntered = true;
	public int ID;
public Truck()
	{JustEntered = false;
 frame = World.frame;
		steering = 0f;
		motor = 0f;
		maxSteeringAngle = 50f;
		maxMotorTorque = 250f;
		Velocity = new UnityEngine.Vector3(0f,0f,0f);
		TruckScript = TruckScript.Instantiate();
		AxleInfos = (

(new Cons<AxleInfo>(new AxleInfo(leftFrontWheel,rightFrontWheel,true,true),(new Cons<AxleInfo>(new AxleInfo(leftRearWheel,rightRearWheel,true,false),(new Empty<AxleInfo>()).ToList<AxleInfo>())).ToList<AxleInfo>())).ToList<AxleInfo>()).ToList<AxleInfo>();
		
}
		public List<AxleInfo> AxleInfos;
	public UnityEngine.Vector3 CenterOfMass{  get { return TruckScript.CenterOfMass; }
  set{TruckScript.CenterOfMass = value; }
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
	public UnityEngine.WheelCollider leftFrontWheel{  get { return TruckScript.leftFrontWheel; }
  set{TruckScript.leftFrontWheel = value; }
 }
	public UnityEngine.WheelCollider leftRearWheel{  get { return TruckScript.leftRearWheel; }
  set{TruckScript.leftRearWheel = value; }
 }
	public System.Single maxMotorTorque;
	public System.Single maxSteeringAngle;
	public System.Single motor;
	public System.String name{  get { return TruckScript.name; }
  set{TruckScript.name = value; }
 }
	public UnityEngine.WheelCollider rightFrontWheel{  get { return TruckScript.rightFrontWheel; }
  set{TruckScript.rightFrontWheel = value; }
 }
	public UnityEngine.WheelCollider rightRearWheel{  get { return TruckScript.rightRearWheel; }
  set{TruckScript.rightRearWheel = value; }
 }
	public System.Single steering;
	public System.String tag{  get { return TruckScript.tag; }
  set{TruckScript.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return TruckScript.transform; }
 }
	public UnityEngine.Rigidbody truckRigidBody{  get { return TruckScript.truckRigidBody; }
  set{TruckScript.truckRigidBody = value; }
 }
	public System.Boolean useGUILayout{  get { return TruckScript.useGUILayout; }
  set{TruckScript.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;

		for(int x0 = 0; x0 < AxleInfos.Count; x0++) { 
			AxleInfos[x0].Update(dt, world);
		}
		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	CenterOfMass = new UnityEngine.Vector3(0.2f,0f,-1f);
	s0 = -1;
return;	
	default: return;}}
	






}
public class AxleInfo{
public int frame;
public bool JustEntered = true;
private UnityEngine.WheelCollider lW;
private UnityEngine.WheelCollider rW;
private System.Boolean m;
private System.Boolean s;
	public int ID;
public AxleInfo(UnityEngine.WheelCollider lW, UnityEngine.WheelCollider rW, System.Boolean m, System.Boolean s)
	{JustEntered = false;
 frame = World.frame;
		steering = s;
		rightWheel = rW;
		motor = m;
		leftWheel = lW;
		
}
		public UnityEngine.WheelCollider leftWheel;
	public System.Boolean motor;
	public UnityEngine.WheelCollider rightWheel;
	public System.Boolean steering;
	public System.Single ___speed00;
	public System.Single ___speed11;
	public System.Single ___steeringAngle20;
	public System.Single ___steeringAngle31;
	public void Update(float dt, World world) {
frame = World.frame;

		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
		this.Rule3(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(!(motor))
	{

	s0 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	___speed00 = ((((world.Jeep.maxMotorTorque) * (UnityEngine.Input.GetAxis("Vertical")))) * (-1f));
	rightWheel.motorTorque = ___speed00;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(!(motor))
	{

	s1 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	___speed11 = ((((world.Jeep.maxMotorTorque) * (UnityEngine.Input.GetAxis("Vertical")))) * (-1f));
	leftWheel.motorTorque = ___speed11;
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(!(steering))
	{

	s2 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	___steeringAngle20 = ((world.Jeep.maxSteeringAngle) * (UnityEngine.Input.GetAxis("Horizontal")));
	rightWheel.steerAngle = ___steeringAngle20;
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	if(!(steering))
	{

	s3 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	___steeringAngle31 = ((world.Jeep.maxSteeringAngle) * (UnityEngine.Input.GetAxis("Horizontal")));
	leftWheel.steerAngle = ___steeringAngle31;
	s3 = -1;
return;	
	default: return;}}
	





}
public class Zombie{
public int frame;
public bool JustEntered = true;
private UnityEngine.Vector3 pos;
	public int ID;
public Zombie(UnityEngine.Vector3 pos)
	{JustEntered = false;
 frame = World.frame;
		UnityZombie = UnityZombie.Instantiate(pos);
		JeepPos = pos;
		
}
		public System.Boolean Destroyed{  get { return UnityZombie.Destroyed; }
  set{UnityZombie.Destroyed = value; }
 }
	public UnityEngine.Vector3 JeepPos;
	public System.Boolean OnMouseOver{  get { return UnityZombie.OnMouseOver; }
 }
	public UnityEngine.Vector3 Position{  get { return UnityZombie.Position; }
  set{UnityZombie.Position = value; }
 }
	public UnityEngine.Quaternion Rotation{  get { return UnityZombie.Rotation; }
  set{UnityZombie.Rotation = value; }
 }
	public UnityZombie UnityZombie;
	public System.Boolean collision{  get { return UnityZombie.collision; }
  set{UnityZombie.collision = value; }
 }
	public UnityEngine.Vector3 currenta{  get { return UnityZombie.currenta; }
  set{UnityZombie.currenta = value; }
 }
	public System.Boolean enabled{  get { return UnityZombie.enabled; }
  set{UnityZombie.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityZombie.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityZombie.hideFlags; }
  set{UnityZombie.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityZombie.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityZombie.name; }
  set{UnityZombie.name = value; }
 }
	public System.Boolean shot{  get { return UnityZombie.shot; }
  set{UnityZombie.shot = value; }
 }
	public System.Single speed{  get { return UnityZombie.speed; }
  set{UnityZombie.speed = value; }
 }
	public System.String tag{  get { return UnityZombie.tag; }
  set{UnityZombie.tag = value; }
 }
	public UnityEngine.Vector3 targeta{  get { return UnityZombie.targeta; }
  set{UnityZombie.targeta = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityZombie.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityZombie.useGUILayout; }
  set{UnityZombie.useGUILayout = value; }
 }
	public System.Single count_down1;
	public void Update(float dt, World world) {
frame = World.frame;		this.Rule2(dt, world);

		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule3(dt, world);
	}

	public void Rule2(float dt, World world) 
	{
		currenta = Position;
	targeta = JeepPos;
	}
	




	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(OnMouseOver)
	{

	goto case 4;	}else
	{

	s0 = -1;
return;	}
	case 4:
	if(UnityEngine.Input.GetMouseButtonDown(0))
	{

	goto case 6;	}else
	{

	s0 = -1;
return;	}
	case 6:
	shot = true;
	Destroyed = false;
	s0 = 8;
return;
	case 8:
	count_down1 = 2f;
	goto case 9;
	case 9:
	if(((count_down1) > (0f)))
	{

	count_down1 = ((count_down1) - (dt));
	s0 = 9;
return;	}else
	{

	goto case 7;	}
	case 7:
	shot = false;
	Destroyed = true;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(((Destroyed) == (false)))
	{

	goto case 12;	}else
	{

	s1 = -1;
return;	}
	case 12:
	if(((Position) == (JeepPos)))
	{

	goto case 13;	}else
	{

	goto case 14;	}
	case 13:
	Rotation = new UnityEngine.Quaternion(0f,0f,0f,0f);
	Destroyed = false;
	s1 = -1;
return;
	case 14:
	Rotation = Rotation;
	Destroyed = false;
	s1 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	if(((Destroyed) == (false)))
	{

	goto case 19;	}else
	{

	s3 = -1;
return;	}
	case 19:
	if(((Position) == (JeepPos)))
	{

	goto case 20;	}else
	{

	goto case 21;	}
	case 20:
	Position = new UnityEngine.Vector3(0f,0f,0f);
	speed = 0f;
	Destroyed = false;
	s3 = -1;
return;
	case 21:
	Position = Position;
	speed = ((((1f) * (dt))) * (0));
	Destroyed = false;
	s3 = -1;
return;	
	default: return;}}
	





}
}                                                                                                                                               