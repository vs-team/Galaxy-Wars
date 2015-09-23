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
		Blokje = new Cube();
		
}
		public Cube Blokje;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;

		Blokje.Update(dt, world);


	}











}
public class Cube{
public int frame;
public bool JustEntered = true;
	public int ID;
public Cube()
	{JustEntered = false;
 frame = World.frame;
		UnityCube = UnityCube.Find();
		
}
		public UnityEngine.Vector3 Rotation{  get { return UnityCube.Rotation; }
  set{UnityCube.Rotation = value; }
 }
	public UnityCube UnityCube;
	public System.Boolean enabled{  get { return UnityCube.enabled; }
  set{UnityCube.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityCube.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityCube.hideFlags; }
  set{UnityCube.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityCube.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityCube.name; }
  set{UnityCube.name = value; }
 }
	public System.String tag{  get { return UnityCube.tag; }
  set{UnityCube.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityCube.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityCube.useGUILayout; }
  set{UnityCube.useGUILayout = value; }
 }
	public UnityEngine.Vector3 ___vectorRotation00;
	public void Update(float dt, World world) {
frame = World.frame;

		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	___vectorRotation00 = new UnityEngine.Vector3(0f,(UnityEngine.Input.GetAxis("SW_Joy0X")) * (180f),0f);
	UnityEngine.Debug.Log(___vectorRotation00);
	Rotation = ___vectorRotation00;
	s0 = -1;
return;	
	default: return;}}
	






}
}                             