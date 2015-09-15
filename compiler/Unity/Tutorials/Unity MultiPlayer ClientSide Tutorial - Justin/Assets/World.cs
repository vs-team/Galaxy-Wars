#pragma warning disable 162,108,618
using Casanova.Prelude;
using System.Linq;
using System;
using System.Collections.Generic;
using Lidgren.Network;
using UnityEngine;
namespace Game {public class World : MonoBehaviour{
public static int frame;
void Update () { Update(Time.deltaTime, this); 
 frame++; }
public bool JustEntered = true;


public void Start()
	{
		TestCube = new Cube();
		
}
		public Cube TestCube;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;

		TestCube.Update(dt, world);


	}











}
public class Cube{
public int frame;
public bool JustEntered = true;
	public int ID;
public Cube()
	{JustEntered = false;
 frame = World.frame;
		CubeScriptNetworking = CubeScriptNetworking.Instantiate();
		
}
		public CubeScriptNetworking CubeScriptNetworking;
	public UnityEngine.Vector3 Position{  get { return CubeScriptNetworking.Position; }
  set{CubeScriptNetworking.Position = value; }
 }
	public UnityEngine.Animation animation{  get { return CubeScriptNetworking.animation; }
 }
	public UnityEngine.AudioSource audio{  get { return CubeScriptNetworking.audio; }
 }
	public UnityEngine.Camera camera{  get { return CubeScriptNetworking.camera; }
 }
	public UnityEngine.Collider collider{  get { return CubeScriptNetworking.collider; }
 }
	public UnityEngine.Collider2D collider2D{  get { return CubeScriptNetworking.collider2D; }
 }
	public UnityEngine.ConstantForce constantForce{  get { return CubeScriptNetworking.constantForce; }
 }
	public System.Boolean enabled{  get { return CubeScriptNetworking.enabled; }
  set{CubeScriptNetworking.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return CubeScriptNetworking.gameObject; }
 }
	public UnityEngine.GUIElement guiElement{  get { return CubeScriptNetworking.guiElement; }
 }
	public UnityEngine.GUIText guiText{  get { return CubeScriptNetworking.guiText; }
 }
	public UnityEngine.GUITexture guiTexture{  get { return CubeScriptNetworking.guiTexture; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return CubeScriptNetworking.hideFlags; }
  set{CubeScriptNetworking.hideFlags = value; }
 }
	public UnityEngine.HingeJoint hingeJoint{  get { return CubeScriptNetworking.hingeJoint; }
 }
	public UnityEngine.Light light{  get { return CubeScriptNetworking.light; }
 }
	public System.String name{  get { return CubeScriptNetworking.name; }
  set{CubeScriptNetworking.name = value; }
 }
	public Lidgren.Network.NetClient netcli{  get { return CubeScriptNetworking.netcli; }
  set{CubeScriptNetworking.netcli = value; }
 }
	public UnityEngine.ParticleEmitter particleEmitter{  get { return CubeScriptNetworking.particleEmitter; }
 }
	public UnityEngine.ParticleSystem particleSystem{  get { return CubeScriptNetworking.particleSystem; }
 }
	public UnityEngine.Renderer renderer{  get { return CubeScriptNetworking.renderer; }
 }
	public UnityEngine.Rigidbody rigidbody{  get { return CubeScriptNetworking.rigidbody; }
 }
	public UnityEngine.Rigidbody2D rigidbody2D{  get { return CubeScriptNetworking.rigidbody2D; }
 }
	public System.String tag{  get { return CubeScriptNetworking.tag; }
  set{CubeScriptNetworking.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return CubeScriptNetworking.transform; }
 }
	public System.Boolean useGUILayout{  get { return CubeScriptNetworking.useGUILayout; }
  set{CubeScriptNetworking.useGUILayout = value; }
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
	Position = Position;
	s0 = -1;
return;	
	default: return;}}
	






}
}                                      