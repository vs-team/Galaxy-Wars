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
		UnityLandscape = new UnityLandscape();
		Pistols = (

(new Cons<Gun>(new Gun(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
		Landscapes = (

(new Cons<Landscape>(new Landscape(1),(new Empty<Landscape>()).ToList<Landscape>())).ToList<Landscape>()).ToList<Landscape>();
		Jeep = new Truck();
		Health = 10f;
		GUIpanel = new GUI();
		Flashs = (

(new Cons<Light>(new Light(),(new Empty<Light>()).ToList<Light>())).ToList<Light>()).ToList<Light>();
		
}
		public System.Boolean Destroyed{  get { return UnityLandscape.Destroyed; }
  set{UnityLandscape.Destroyed = value; }
 }
	public List<Light> Flashs;
	public GUI GUIpanel;
	public System.Single Health;
	public Truck Jeep;
	public List<Landscape> __Landscapes;
	public List<Landscape> Landscapes{  get { return  __Landscapes; }
  set{ __Landscapes = value;
 foreach(var e in value){if(e.JustEntered){ e.JustEntered = false;
}
} }
 }
	public List<Gun> Pistols;
	public System.Collections.Generic.List<UnityEngine.Transform> Spawnpoints2{  get { return UnityLandscape.Spawnpoints2; }
 }
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
	public List<Zombie> ___zombies_let10;

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
		this.Rule1(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	Health = Health;
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
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	___zombies_let10 = (

(Zombies).Select(__ContextSymbol4 => new { ___a10 = __ContextSymbol4 })
.Where(__ContextSymbol5 => !(((__ContextSymbol5.___a10.life) == (0f))))
.Select(__ContextSymbol6 => __ContextSymbol6.___a10)
.ToList<Zombie>()).ToList<Zombie>();
	UnityEngine.Debug.Log(("Amount of zombies alive = ") + (___zombies_let10.Count));
	Zombies = ___zombies_let10;
	s1 = -1;
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
	if(UnityEngine.Input.GetMouseButton(0))
	{

	goto case 4;	}else
	{

	s0 = -1;
return;	}
	case 4:
	Trigger = true;
	s0 = 5;
return;
	case 5:
	Trigger = false;
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
		Reloading = false;
		ReloadDuration = 4f;
		GunController = new ControllerRazor();
		Ammo = 80;
		
}
		public System.Int32 Ammo;
	public ControllerRazor GunController;
	public System.Single ReloadDuration;
	public System.Boolean Reloading;
	public System.Single count_down1;
	public void Update(float dt, World world) {
frame = World.frame;

		GunController.Update(dt, world);
		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(UnityEngine.Input.GetButton("C"))
	{

	goto case 9;	}else
	{

	s0 = -1;
return;	}
	case 9:
	Reloading = false;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(UnityEngine.Input.GetButton("R"))
	{

	goto case 12;	}else
	{

	s1 = -1;
return;	}
	case 12:
	Reloading = true;
	Ammo = Ammo;
	s1 = 14;
return;
	case 14:
	count_down1 = ReloadDuration;
	goto case 15;
	case 15:
	if(((count_down1) > (0f)))
	{

	count_down1 = ((count_down1) - (dt));
	s1 = 15;
return;	}else
	{

	goto case 13;	}
	case 13:
	Reloading = false;
	Ammo = 20;
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	UnityEngine.Debug.Log(("Ammo left = ") + (Ammo));
	if(((((GunController.Trigger) && (((Ammo) > (0))))) && (((Reloading) == (false)))))
	{

	goto case 18;	}else
	{

	s2 = -1;
return;	}
	case 18:
	Ammo = ((Ammo) - (1));
	s2 = 19;
return;
	case 19:
	Ammo = Ammo;
	s2 = -1;
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
		Active = true;
		
}
		public System.Boolean Active;
	public System.Single Battery;
	public ControllerRazor LightController;
	public void Update(float dt, World world) {
frame = World.frame;

		LightController.Update(dt, world);
		this.Rule0(dt, world);
		this.Rule1(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(((Active) && (((Battery) > (0.49f)))))
	{

	goto case 22;	}else
	{

	goto case 23;	}
	case 22:
	Battery = ((Battery) - (0.5f));
	s0 = -1;
return;
	case 23:
	Battery = 0f;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	Active = LightController.Trigger;
	s1 = 0;
return;
	case 0:
	if(!(false))
	{

	s1 = 0;
return;	}else
	{

	s1 = -1;
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
	public System.Collections.Generic.List<UnityEngine.Transform> Spawnpoints2{  get { return UnityLandscape.Spawnpoints2; }
 }
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
	public List<System.String> ___sps_name00;
	public List<System.String> ___sps_number00;
	public List<UnityEngine.Transform> ___sps00;
	public UnityEngine.Transform ___sps_head10;
	public UnityEngine.Vector3 ___sps_pos10;
	public List<Zombie> ___zmbies10;
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
	___sps_name00 = (

(Spawnpoints2).Select(__ContextSymbol11 => new { ___a01 = __ContextSymbol11 })
.Select(__ContextSymbol12 => __ContextSymbol12.___a01.name)
.ToList<System.String>()).ToList<System.String>();
	___sps_number00 = (

(___sps_name00).Select(__ContextSymbol13 => new { ___a02 = __ContextSymbol13 })
.Select(__ContextSymbol14 => __ContextSymbol14.___a02.Substring(10,1))
.ToList<System.String>()).ToList<System.String>();
	UnityEngine.Debug.Log(("spsnumberhead = ") + (___sps_number00.Head()));
	___sps00 = (

(Spawnpoints2).Select(__ContextSymbol15 => new { ___a03 = __ContextSymbol15 })
.Select(__ContextSymbol16 => __ContextSymbol16.___a03)
.ToList<UnityEngine.Transform>()).ToList<UnityEngine.Transform>();
	Spawnpoints = ___sps00;
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
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(!(((Spawnpoints.Count) > (0))))
	{

	s1 = -1;
return;	}else
	{

	goto case 4;	}
	case 4:
	___sps_head10 = Spawnpoints.Head();
	___sps_pos10 = ___sps_head10.position;
	___zmbies10 = (

(new Cons<Zombie>(new Zombie(___sps_pos10),(new Empty<Zombie>()).ToList<Zombie>())).ToList<Zombie>()).ToList<Zombie>();
	Zombies = ___zmbies10;
	s1 = 0;
return;
	case 0:
	if(!(false))
	{

	s1 = 0;
return;	}else
	{

	s1 = -1;
return;	}	
	default: return;}}
	





}
public class Truck{
public int frame;
public bool JustEntered = true;
	public int ID;
public Truck()
	{JustEntered = false;
 frame = World.frame;
		fuel = 40f;
		TruckScript = new TruckScript();
		DriveEngine = new Engine();
		
}
		public Engine DriveEngine;
	public TruckScript TruckScript;
	public System.Boolean enabled{  get { return TruckScript.enabled; }
  set{TruckScript.enabled = value; }
 }
	public System.Single fuel;
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
		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	UnityEngine.Debug.Log(("Fuel amount left = ") + (fuel));
	if(((world.Jeep.DriveEngine.active) && (((fuel) > (0.99f)))))
	{

	goto case 6;	}else
	{

	goto case 7;	}
	case 6:
	fuel = ((fuel) - (1f));
	s0 = -1;
return;
	case 7:
	fuel = 0f;
	s0 = -1;
return;	
	default: return;}}
	






}
public class Engine{
public int frame;
public bool JustEntered = true;
	public int ID;
public Engine()
	{JustEntered = false;
 frame = World.frame;
		rotation = Vector3.zero;
		active = true;
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

	goto case 12;	}else
	{

	goto case 13;	}
	case 12:
	life = ((life) - (1.5f));
	s0 = -1;
return;
	case 13:
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