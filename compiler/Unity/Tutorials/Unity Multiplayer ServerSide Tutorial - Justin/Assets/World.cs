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
		Count = new Kubus();
		
}
		public Kubus Count;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;

		Count.Update(dt, world);


	}











}
public class Kubus{
public int frame;
public bool JustEntered = true;
	public int ID;
public Kubus()
	{JustEntered = false;
 frame = World.frame;
		CubeScript = CubeScript.Instantiate();
		
}
		public CubeScript CubeScript;
	public UnityEngine.Vector3 Position{  get { return CubeScript.Position; }
  set{CubeScript.Position = value; }
 }
	public UnityEngine.Animation animation{  get { return CubeScript.animation; }
 }
	public UnityEngine.AudioSource audio{  get { return CubeScript.audio; }
 }
	public UnityEngine.Camera camera{  get { return CubeScript.camera; }
 }
	public UnityEngine.Collider collider{  get { return CubeScript.collider; }
 }
	public UnityEngine.Collider2D collider2D{  get { return CubeScript.collider2D; }
 }
	public UnityEngine.ConstantForce constantForce{  get { return CubeScript.constantForce; }
 }
	public System.Boolean enabled{  get { return CubeScript.enabled; }
  set{CubeScript.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return CubeScript.gameObject; }
 }
	public UnityEngine.GUIElement guiElement{  get { return CubeScript.guiElement; }
 }
	public UnityEngine.GUIText guiText{  get { return CubeScript.guiText; }
 }
	public UnityEngine.GUITexture guiTexture{  get { return CubeScript.guiTexture; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return CubeScript.hideFlags; }
  set{CubeScript.hideFlags = value; }
 }
	public UnityEngine.HingeJoint hingeJoint{  get { return CubeScript.hingeJoint; }
 }
	public UnityEngine.Light light{  get { return CubeScript.light; }
 }
	public System.String name{  get { return CubeScript.name; }
  set{CubeScript.name = value; }
 }
	public UnityEngine.ParticleEmitter particleEmitter{  get { return CubeScript.particleEmitter; }
 }
	public UnityEngine.ParticleSystem particleSystem{  get { return CubeScript.particleSystem; }
 }
	public UnityEngine.Renderer renderer{  get { return CubeScript.renderer; }
 }
	public UnityEngine.Rigidbody rigidbody{  get { return CubeScript.rigidbody; }
 }
	public UnityEngine.Rigidbody2D rigidbody2D{  get { return CubeScript.rigidbody2D; }
 }
	public System.String tag{  get { return CubeScript.tag; }
  set{CubeScript.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return CubeScript.transform; }
 }
	public System.Boolean useGUILayout{  get { return CubeScript.useGUILayout; }
  set{CubeScript.useGUILayout = value; }
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

	goto case 7;	}else
	{

	goto case 3;	}
	case 7:
	Position = ((Position) + (new UnityEngine.Vector3(0f,-2f,0f)));
	s0 = 3;
return;
	case 3:
	if(UnityEngine.Input.GetKeyDown(KeyCode.D))
	{

	goto case 4;	}else
	{

	goto case 0;	}
	case 4:
	Position = ((Position) + (new UnityEngine.Vector3(0f,2f,0f)));
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
	Position = ((Position) + (new UnityEngine.Vector3(2f,0f,0f)));
	s0 = -1;
return;	
	default: return;}}
	






}
}                                    