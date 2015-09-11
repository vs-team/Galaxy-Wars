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
.Where(__ContextSymbol5 => ((__ContextSymbol5.___e11.Checkpoint.isEntered) && (!(__ContextSymbol5.___e11.Destroyed))))
.Select(__ContextSymbol6 => __ContextSymbol6.___e11)
.ToList<Landscape>()).ToList<Landscape>();
	if(((___a10.Count) > (0)))
	{

	goto case 3;	}else
	{

	s1 = -1;
return;	}
	case 3:
	Landscapes = new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,(___a10.Head().transform.position.z) - (240f))), (Landscapes)).ToList<Landscape>();
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
		UnityLandscape = UnityLandscape.Instantiate(StartP);
		DestroyDistance = 500f;
		
}
		public UnityCheckpoint Checkpoint{  get { return UnityLandscape.Checkpoint; }
 }
	public System.Single DestroyDistance;
	public System.Boolean Destroyed{  get { return UnityLandscape.Destroyed; }
  set{UnityLandscape.Destroyed = value; }
 }
	public UnityEngine.Vector3 Position{  get { return UnityLandscape.Position; }
  set{UnityLandscape.Position = value; }
 }
	public UnityLandscape UnityLandscape;
	public UnityEngine.Animation animation{  get { return UnityLandscape.animation; }
 }
	public UnityEngine.AudioSource audio{  get { return UnityLandscape.audio; }
 }
	public UnityEngine.Camera camera{  get { return UnityLandscape.camera; }
 }
	public UnityEngine.Collider collider{  get { return UnityLandscape.collider; }
 }
	public UnityEngine.Collider2D collider2D{  get { return UnityLandscape.collider2D; }
 }
	public UnityEngine.ConstantForce constantForce{  get { return UnityLandscape.constantForce; }
 }
	public System.Boolean enabled{  get { return UnityLandscape.enabled; }
  set{UnityLandscape.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityLandscape.gameObject; }
 }
	public UnityEngine.GUIElement guiElement{  get { return UnityLandscape.guiElement; }
 }
	public UnityEngine.GUIText guiText{  get { return UnityLandscape.guiText; }
 }
	public UnityEngine.GUITexture guiTexture{  get { return UnityLandscape.guiTexture; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityLandscape.hideFlags; }
  set{UnityLandscape.hideFlags = value; }
 }
	public UnityEngine.HingeJoint hingeJoint{  get { return UnityLandscape.hingeJoint; }
 }
	public UnityEngine.Light light{  get { return UnityLandscape.light; }
 }
	public System.String name{  get { return UnityLandscape.name; }
  set{UnityLandscape.name = value; }
 }
	public UnityEngine.ParticleEmitter particleEmitter{  get { return UnityLandscape.particleEmitter; }
 }
	public UnityEngine.ParticleSystem particleSystem{  get { return UnityLandscape.particleSystem; }
 }
	public UnityEngine.Renderer renderer{  get { return UnityLandscape.renderer; }
 }
	public UnityEngine.Rigidbody rigidbody{  get { return UnityLandscape.rigidbody; }
 }
	public UnityEngine.Rigidbody2D rigidbody2D{  get { return UnityLandscape.rigidbody2D; }
 }
	public System.String tag{  get { return UnityLandscape.tag; }
  set{UnityLandscape.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityLandscape.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityLandscape.useGUILayout; }
  set{UnityLandscape.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;

		this.Rule0(dt, world);
		this.Rule1(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(!(((UnityEngine.Vector3.Distance(Position,world.Jeep.Position)) > (DestroyDistance))))
	{

	s0 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Destroyed = true;
	s0 = -1;
return;	
	default: return;}}
	

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
frame = World.frame;

		this.Rule0(dt, world);
		this.Rule1(dt, world);
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
	Rotation = Rotation;
	Velocity.x = 0f;
	s1 = -1;
return;	
	default: return;}}
	





}
}      