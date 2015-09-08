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
		Zombies = (

Enumerable.Empty<Zombie>()).ToList<Zombie>();
		Truck = new Jeep();
		
}
		public Jeep Truck;
	public List<Zombie> Zombies;
	public System.Single count_down1;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;		this.Rule1(dt, world);

		Truck.Update(dt, world);
		for(int x0 = 0; x0 < Zombies.Count; x0++) { 
			Zombies[x0].Update(dt, world);
		}
		this.Rule0(dt, world);

	}

	public void Rule1(float dt, World world) 
	{
	Zombies = (

(Zombies).Select(__ContextSymbol1 => new { ___a10 = __ContextSymbol1 })
.Where(__ContextSymbol2 => !(__ContextSymbol2.___a10.Destroyed))
.Select(__ContextSymbol3 => __ContextSymbol3.___a10)
.ToList<Zombie>()).ToList<Zombie>();
	}
	




	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	count_down1 = 2f;
	goto case 2;
	case 2:
	if(((count_down1) > (0f)))
	{

	count_down1 = ((count_down1) - (dt));
	s0 = 2;
return;	}else
	{

	goto case 0;	}
	case 0:
	Zombies = new Cons<Zombie>(new Zombie(Truck.Position), (Zombies)).ToList<Zombie>();
	s0 = -1;
return;	
	default: return;}}
	






}
public class Jeep{
public int frame;
public bool JustEntered = true;
	public int ID;
public Jeep()
	{JustEntered = false;
 frame = World.frame;
		test = 0;
		UnityJeep = UnityJeep.Instantiate();
		
}
		public System.Boolean Destroyed{  get { return UnityJeep.Destroyed; }
  set{UnityJeep.Destroyed = value; }
 }
	public UnityEngine.Vector3 Position{  get { return UnityJeep.Position; }
  set{UnityJeep.Position = value; }
 }
	public UnityJeep UnityJeep;
	public UnityEngine.Animation animation{  get { return UnityJeep.animation; }
 }
	public UnityEngine.AudioSource audio{  get { return UnityJeep.audio; }
 }
	public UnityEngine.Camera camera{  get { return UnityJeep.camera; }
 }
	public UnityEngine.Collider collider{  get { return UnityJeep.collider; }
 }
	public UnityEngine.Collider2D collider2D{  get { return UnityJeep.collider2D; }
 }
	public UnityEngine.ConstantForce constantForce{  get { return UnityJeep.constantForce; }
 }
	public System.Boolean enabled{  get { return UnityJeep.enabled; }
  set{UnityJeep.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityJeep.gameObject; }
 }
	public UnityEngine.GUIElement guiElement{  get { return UnityJeep.guiElement; }
 }
	public UnityEngine.GUIText guiText{  get { return UnityJeep.guiText; }
 }
	public UnityEngine.GUITexture guiTexture{  get { return UnityJeep.guiTexture; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityJeep.hideFlags; }
  set{UnityJeep.hideFlags = value; }
 }
	public UnityEngine.HingeJoint hingeJoint{  get { return UnityJeep.hingeJoint; }
 }
	public UnityEngine.Light light{  get { return UnityJeep.light; }
 }
	public System.String name{  get { return UnityJeep.name; }
  set{UnityJeep.name = value; }
 }
	public UnityEngine.ParticleEmitter particleEmitter{  get { return UnityJeep.particleEmitter; }
 }
	public UnityEngine.ParticleSystem particleSystem{  get { return UnityJeep.particleSystem; }
 }
	public UnityEngine.Renderer renderer{  get { return UnityJeep.renderer; }
 }
	public UnityEngine.Rigidbody rigidbody{  get { return UnityJeep.rigidbody; }
 }
	public UnityEngine.Rigidbody2D rigidbody2D{  get { return UnityJeep.rigidbody2D; }
 }
	public System.String tag{  get { return UnityJeep.tag; }
  set{UnityJeep.tag = value; }
 }
	public System.Int32 test;
	public UnityEngine.Transform transform{  get { return UnityJeep.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityJeep.useGUILayout; }
  set{UnityJeep.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;		this.Rule0(dt, world);



	}

	public void Rule0(float dt, World world) 
	{
	test = (test) + (1);
	}
	










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
		TruckPos = pos;
		
}
		public System.Boolean Destroyed{  get { return UnityZombie.Destroyed; }
  set{UnityZombie.Destroyed = value; }
 }
	public UnityEngine.Vector3 Position{  get { return UnityZombie.Position; }
  set{UnityZombie.Position = value; }
 }
	public UnityEngine.Quaternion Rotation{  get { return UnityZombie.Rotation; }
  set{UnityZombie.Rotation = value; }
 }
	public UnityEngine.Vector3 TruckPos;
	public UnityZombie UnityZombie;
	public UnityEngine.Animation animation{  get { return UnityZombie.animation; }
 }
	public UnityEngine.AudioSource audio{  get { return UnityZombie.audio; }
 }
	public UnityEngine.Camera camera{  get { return UnityZombie.camera; }
 }
	public UnityEngine.Collider collider{  get { return UnityZombie.collider; }
 }
	public UnityEngine.Collider2D collider2D{  get { return UnityZombie.collider2D; }
 }
	public UnityEngine.ConstantForce constantForce{  get { return UnityZombie.constantForce; }
 }
	public UnityEngine.Vector3 currenta{  get { return UnityZombie.currenta; }
  set{UnityZombie.currenta = value; }
 }
	public System.Boolean enabled{  get { return UnityZombie.enabled; }
  set{UnityZombie.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityZombie.gameObject; }
 }
	public UnityEngine.GUIElement guiElement{  get { return UnityZombie.guiElement; }
 }
	public UnityEngine.GUIText guiText{  get { return UnityZombie.guiText; }
 }
	public UnityEngine.GUITexture guiTexture{  get { return UnityZombie.guiTexture; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityZombie.hideFlags; }
  set{UnityZombie.hideFlags = value; }
 }
	public UnityEngine.HingeJoint hingeJoint{  get { return UnityZombie.hingeJoint; }
 }
	public UnityEngine.Light light{  get { return UnityZombie.light; }
 }
	public System.String name{  get { return UnityZombie.name; }
  set{UnityZombie.name = value; }
 }
	public UnityEngine.ParticleEmitter particleEmitter{  get { return UnityZombie.particleEmitter; }
 }
	public UnityEngine.ParticleSystem particleSystem{  get { return UnityZombie.particleSystem; }
 }
	public UnityEngine.Renderer renderer{  get { return UnityZombie.renderer; }
 }
	public UnityEngine.Rigidbody rigidbody{  get { return UnityZombie.rigidbody; }
 }
	public UnityEngine.Rigidbody2D rigidbody2D{  get { return UnityZombie.rigidbody2D; }
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
	public void Update(float dt, World world) {
frame = World.frame;		this.Rule1(dt, world);

		this.Rule0(dt, world);
		this.Rule2(dt, world);
	}

	public void Rule1(float dt, World world) 
	{
		currenta = Position;
	targeta = TruckPos;
	}
	




	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(((Position) == (TruckPos)))
	{

	goto case 3;	}else
	{

	goto case 4;	}
	case 3:
	Rotation = new UnityEngine.Quaternion(0f,0f,0f,0f);
	Destroyed = true;
	s0 = -1;
return;
	case 4:
	Rotation = Rotation;
	Destroyed = false;
	s0 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(((Position) == (TruckPos)))
	{

	goto case 8;	}else
	{

	goto case 9;	}
	case 8:
	Position = new UnityEngine.Vector3(0f,0f,0f);
	speed = 0f;
	Destroyed = true;
	s2 = -1;
return;
	case 9:
	Position = Position;
	speed = ((1f) * (dt));
	Destroyed = false;
	s2 = -1;
return;	
	default: return;}}
	





}
}  