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

(new Cons<Zombie>(new Zombie(Vector3.zero),(new Empty<Zombie>()).ToList<Zombie>())).ToList<Zombie>()).ToList<Zombie>();
		UnityLandscape = new UnityLandscape();
		Pistols = (

(new Cons<Gun>(new Gun(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
		Landscapes = (

(new Cons<Landscape>(new Landscape(1),(new Empty<Landscape>()).ToList<Landscape>())).ToList<Landscape>()).ToList<Landscape>();
		Jeep = new Truck();
		GUIpanel = new GUI();
		Flashs = (

(new Cons<Light>(new Light(),(new Empty<Light>()).ToList<Light>())).ToList<Light>()).ToList<Light>();
		
}
		public System.Boolean Destroyed{  get { return UnityLandscape.Destroyed; }
  set{UnityLandscape.Destroyed = value; }
 }
	public List<Light> Flashs;
	public GUI GUIpanel;
	public Truck Jeep;
	public List<Landscape> Landscapes;
	public List<Gun> Pistols;
	public UnityLandscape UnityLandscape;
	public List<Zombie> __Zombies;
	public List<Zombie> Zombies{  get { return  __Zombies; }
  set{ __Zombies = value;
 foreach(var e in value){if(e.JustEntered){ e.JustEntered = false;
}
} }
 }
	public System.Boolean enabled{  get { return UnityLandscape.enabled; }
  set{UnityLandscape.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityLandscape.gameObject; }
 }
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
	public List<Zombie> ___zombies_let00;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;

		for(int x0 = 0; x0 < Flashs.Count; x0++) { 
			Flashs[x0].Update(dt, world);
		}
		GUIpanel.Update(dt, world);
		Jeep.Update(dt, world);
		for(int x0 = 0; x0 < Landscapes.Count; x0++) { 
			Landscapes[x0].Update(dt, world);
		}
		for(int x0 = 0; x0 < Pistols.Count; x0++) { 
			Pistols[x0].Update(dt, world);
		}
		for(int x0 = 0; x0 < Zombies.Count; x0++) { 
			Zombies[x0].Update(dt, world);
		}
		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	___zombies_let00 = (

(Zombies).Select(__ContextSymbol4 => new { ___a00 = __ContextSymbol4 })
.Where(__ContextSymbol5 => !(((__ContextSymbol5.___a00.life) == (0f))))
.Select(__ContextSymbol6 => __ContextSymbol6.___a00)
.ToList<Zombie>()).ToList<Zombie>();
	UnityEngine.Debug.Log(("Amount of zombies alive = ") + (___zombies_let00.Count));
	Zombies = ___zombies_let00;
	s0 = -1;
return;	
	default: return;}}
	






}
public class ControllerRazor{
public int frame;
public bool JustEntered = true;
	public int ID;
public ControllerRazor()
	{JustEntered = false;
 frame = World.frame;
		Trigger = false;
		Position = Vector3.zero;
		Forward = Vector3.zero;
		
}
		public UnityEngine.Vector3 Forward;
	public UnityEngine.Vector3 Position;
	public System.Boolean Trigger;
	public void Update(float dt, World world) {
frame = World.frame;

		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	UnityEngine.Debug.Log(("Trigger value = ") + (Trigger));
	Trigger = Trigger;
	s0 = -1;
return;	
	default: return;}}
	






}
public class Gun{
public int frame;
public bool JustEntered = true;
	public int ID;
public Gun()
	{JustEntered = false;
 frame = World.frame;
		Shoot = false;
		Onclick = true;
		GunController = new ControllerRazor();
		Ammo = 80;
		
}
		public System.Int32 Ammo;
	public ControllerRazor GunController;
	public System.Boolean Onclick;
	public System.Boolean Shoot;
	public void Update(float dt, World world) {
frame = World.frame;

		GunController.Update(dt, world);
		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	UnityEngine.Debug.Log(("Ammo left = ") + (Ammo));
	if(((Onclick) && (((Ammo) > (0)))))
	{

	goto case 3;	}else
	{

	s0 = -1;
return;	}
	case 3:
	Ammo = ((Ammo) - (1));
	Shoot = true;
	s0 = 4;
return;
	case 4:
	Ammo = Ammo;
	Shoot = false;
	s0 = -1;
return;	
	default: return;}}
	






}
public class Light{
public int frame;
public bool JustEntered = true;
	public int ID;
public Light()
	{JustEntered = false;
 frame = World.frame;
		LightController = new ControllerRazor();
		Battery = 100f;
		Active = false;
		
}
		public System.Boolean Active;
	public System.Single Battery;
	public ControllerRazor LightController;
	public void Update(float dt, World world) {
frame = World.frame;

		LightController.Update(dt, world);
		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	Active = true;
	s0 = 0;
return;
	case 0:
	if(!(false))
	{

	s0 = 0;
return;	}else
	{

	s0 = -1;
return;	}	
	default: return;}}
	






}
public class GUI{
public int frame;
public bool JustEntered = true;
	public int ID;
public GUI()
	{JustEntered = false;
 frame = World.frame;
		test = false;
		
}
		public System.Boolean test;
	public void Update(float dt, World world) {
frame = World.frame;

		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	test = test;
	s0 = 0;
return;
	case 0:
	if(!(false))
	{

	s0 = 0;
return;	}else
	{

	s0 = -1;
return;	}	
	default: return;}}
	






}
public class Landscape{
public int frame;
public bool JustEntered = true;
private System.Int32 amountofzombies;
	public int ID;
public Landscape(System.Int32 amountofzombies)
	{JustEntered = false;
 frame = World.frame;
		UnityEngine.Vector3 ___pos00;
		___pos00 = Vector3.zero;
		Zombies = (

Enumerable.Empty<Zombie>()).ToList<Zombie>();
		UnityLandscape = UnityLandscape.Instantiate(___pos00);
		Spawnpoints = (

Enumerable.Empty<UnityEngine.Transform>()).ToList<UnityEngine.Transform>();
		
}
		public System.Boolean Destroyed{  get { return UnityLandscape.Destroyed; }
  set{UnityLandscape.Destroyed = value; }
 }
	public List<UnityEngine.Transform> Spawnpoints;
	public UnityLandscape UnityLandscape;
	public List<Zombie> Zombies;
	public System.Boolean enabled{  get { return UnityLandscape.enabled; }
  set{UnityLandscape.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityLandscape.gameObject; }
 }
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
	public void Update(float dt, World world) {
frame = World.frame;



	}











}
public class Truck{
public int frame;
public bool JustEntered = true;
	public int ID;
public Truck()
	{JustEntered = false;
 frame = World.frame;
		TruckScript = new TruckScript();
		DriveEngine = new Engine();
		
}
		public Engine DriveEngine;
	public TruckScript TruckScript;
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
	public UnityEngine.Rigidbody truckRigidBody{  get { return TruckScript.truckRigidBody; }
  set{TruckScript.truckRigidBody = value; }
 }
	public System.Boolean useGUILayout{  get { return TruckScript.useGUILayout; }
  set{TruckScript.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;

		DriveEngine.Update(dt, world);


	}











}
public class Engine{
public int frame;
public bool JustEntered = true;
	public int ID;
public Engine()
	{JustEntered = false;
 frame = World.frame;
		rotation = Vector3.zero;
		active = false;
		accel = 0f;
		BrakeAndReverse = 0f;
		
}
		public System.Single BrakeAndReverse;
	public System.Single accel;
	public System.Boolean active;
	public UnityEngine.Vector3 rotation;
	public void Update(float dt, World world) {
frame = World.frame;



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
		life = 100f;
		UnityZombie = UnityZombie.Instantiate(pos);
		
}
		public System.Boolean Destroyed{  get { return UnityZombie.Destroyed; }
  set{UnityZombie.Destroyed = value; }
 }
	public System.Boolean OnMouseOver{  get { return UnityZombie.OnMouseOver; }
 }
	public UnityZombie UnityZombie;
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
	public System.Single life;
	public System.String name{  get { return UnityZombie.name; }
  set{UnityZombie.name = value; }
 }
	public System.String tag{  get { return UnityZombie.tag; }
  set{UnityZombie.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityZombie.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityZombie.useGUILayout; }
  set{UnityZombie.useGUILayout = value; }
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
	UnityEngine.Debug.Log(("Life left = ") + (life));
	if(((life) > (0.49f)))
	{

	goto case 2;	}else
	{

	goto case 3;	}
	case 2:
	life = ((life) - (1.5f));
	s0 = -1;
return;
	case 3:
	life = 0f;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(!(((life) == (0f))))
	{

	s1 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Destroyed = true;
	s1 = -1;
return;	
	default: return;}}
	





}
}     