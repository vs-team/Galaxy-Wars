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
		Landscape ___beginningLandscape00;
		___beginningLandscape00 = new Landscape(new UnityEngine.Vector3(0f,0f,0f));
		Landscapes = (

(new Cons<Landscape>(___beginningLandscape00,(new Empty<Landscape>()).ToList<Landscape>())).ToList<Landscape>()).ToList<Landscape>();
		
}
		public List<Landscape> Landscapes;
	public List<Landscape> ___a00;
	public Landscape ___headOfA00;
	public UnityEngine.Transform ___headOfATransform00;
	public UnityEngine.Vector3 ___headOfAPosition00;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;

		for(int x0 = 0; x0 < Landscapes.Count; x0++) { 
			Landscapes[x0].Update(dt, world);
		}
		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	___a00 = (

(Landscapes).Select(__ContextSymbol1 => new { ___e00 = __ContextSymbol1 })
.Where(__ContextSymbol2 => __ContextSymbol2.___e00.check.isEntered)
.Select(__ContextSymbol3 => __ContextSymbol3.___e00)
.ToList<Landscape>()).ToList<Landscape>();
	UnityEngine.Debug.Log(("a.count ") + (___a00.Count));
	if(((___a00.Count) > (0)))
	{

	goto case 1;	}else
	{

	s0 = -1;
return;	}
	case 1:
	___headOfA00 = ___a00.Head();
	___headOfATransform00 = ___headOfA00.transform;
	___headOfAPosition00 = ___headOfATransform00.position;
	Landscapes = new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,(___headOfAPosition00.z) - (80f))), (Landscapes)).ToList<Landscape>();
	s0 = -1;
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
	public UnityCheckpoint check{  get { return UnityLandscape.check; }
  set{UnityLandscape.check = value; }
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



	}











}
}                    