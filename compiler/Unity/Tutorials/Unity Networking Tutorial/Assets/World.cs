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
		Netcube = new Cube();
		
}
		public Cube Netcube;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;

		Netcube.Update(dt, world);


	}











}
public class Cube{
public int frame;
public bool JustEntered = true;
	public int ID;
public Cube()
	{JustEntered = false;
 frame = World.frame;
		UnityNetworkCube = UnityNetworkCube.Instantiate();
		
}
		public UnityEngine.Color Color{  get { return UnityNetworkCube.Color; }
  set{UnityNetworkCube.Color = value; }
 }
	public UnityNetworkCube UnityNetworkCube;
	public UnityEngine.Animation animation{  get { return UnityNetworkCube.animation; }
 }
	public UnityEngine.AudioSource audio{  get { return UnityNetworkCube.audio; }
 }
	public UnityEngine.Camera camera{  get { return UnityNetworkCube.camera; }
 }
	public UnityEngine.Collider collider{  get { return UnityNetworkCube.collider; }
 }
	public UnityEngine.Collider2D collider2D{  get { return UnityNetworkCube.collider2D; }
 }
	public UnityEngine.ConstantForce constantForce{  get { return UnityNetworkCube.constantForce; }
 }
	public System.Boolean enabled{  get { return UnityNetworkCube.enabled; }
  set{UnityNetworkCube.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityNetworkCube.gameObject; }
 }
	public UnityEngine.GUIElement guiElement{  get { return UnityNetworkCube.guiElement; }
 }
	public UnityEngine.GUIText guiText{  get { return UnityNetworkCube.guiText; }
 }
	public UnityEngine.GUITexture guiTexture{  get { return UnityNetworkCube.guiTexture; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityNetworkCube.hideFlags; }
  set{UnityNetworkCube.hideFlags = value; }
 }
	public UnityEngine.HingeJoint hingeJoint{  get { return UnityNetworkCube.hingeJoint; }
 }
	public UnityEngine.Light light{  get { return UnityNetworkCube.light; }
 }
	public System.String name{  get { return UnityNetworkCube.name; }
  set{UnityNetworkCube.name = value; }
 }
	public UnityEngine.ParticleEmitter particleEmitter{  get { return UnityNetworkCube.particleEmitter; }
 }
	public UnityEngine.ParticleSystem particleSystem{  get { return UnityNetworkCube.particleSystem; }
 }
	public UnityEngine.Renderer renderer{  get { return UnityNetworkCube.renderer; }
 }
	public UnityEngine.Rigidbody rigidbody{  get { return UnityNetworkCube.rigidbody; }
 }
	public UnityEngine.Rigidbody2D rigidbody2D{  get { return UnityNetworkCube.rigidbody2D; }
 }
	public System.String tag{  get { return UnityNetworkCube.tag; }
  set{UnityNetworkCube.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityNetworkCube.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityNetworkCube.useGUILayout; }
  set{UnityNetworkCube.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;

		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(UnityEngine.Input.GetKeyDown(KeyCode.A))
	{

	goto case 4;	}else
	{

	goto case 0;	}
	case 4:
	Color = Color.black;
	s0 = 0;
return;
	case 0:
	if(UnityEngine.Input.GetKeyDown(KeyCode.W))
	{

	goto case 1;	}else
	{

	s0 = -1;
return;	}
	case 1:
	Color = Color.red;
	s0 = -1;
return;	
	default: return;}}
	






}
}                                                                                           