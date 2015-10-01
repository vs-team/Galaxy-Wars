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
		System.Int32 ___randomr00;
		___randomr00 = UnityEngine.Random.Range(2,4);
		Zombies = (

Enumerable.Empty<Zombie>()).ToList<Zombie>();
		UnityLandscape = new UnityLandscape();
		Pistols = (

(new Cons<Gun>(new Gun(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
		Landscapes = (

(new Cons<Landscape>(new Landscape(Vector3.zero,___randomr00),(new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,-80f),(___randomr00) + (1)),(new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,-160f),(___randomr00) - (1)),(new Empty<Landscape>()).ToList<Landscape>())).ToList<Landscape>())).ToList<Landscape>())).ToList<Landscape>()).ToList<Landscape>();
		Jeep = new Truck();
		Health = 10f;
		GUIpanel = new GUI();
		Flashs = (

(new Cons<Light>(new Light(),(new Empty<Light>()).ToList<Light>())).ToList<Light>()).ToList<Light>();
		
}
		public UnityCheckpoint Checkpoint{  get { return UnityLandscape.Checkpoint; }
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
	public List<Landscape> ___ls00;
	public System.Int32 ___randr00;
	public System.Single count_down1;
	public List<Zombie> ___new_zombies30;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;		this.Rule2(dt, world);

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
		this.Rule3(dt, world);
	}

	public void Rule2(float dt, World world) 
	{
	Zombies = (

(Zombies).Select(__ContextSymbol4 => new { ___a21 = __ContextSymbol4 })
.Where(__ContextSymbol5 => !(((__ContextSymbol5.___a21.Life) == (0f))))
.Select(__ContextSymbol6 => __ContextSymbol6.___a21)
.ToList<Zombie>()).ToList<Zombie>();
	}
	




	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	___ls00 = (

(Landscapes).Select(__ContextSymbol7 => new { ___a00 = __ContextSymbol7 })
.Where(__ContextSymbol8 => __ContextSymbol8.___a00.Checkpoint.isEntered)
.Select(__ContextSymbol9 => __ContextSymbol9.___a00)
.ToList<Landscape>()).ToList<Landscape>();
	if(((___ls00.Count) > (0)))
	{

	goto case 1;	}else
	{

	s0 = -1;
return;	}
	case 1:
	___randr00 = UnityEngine.Random.Range(1,5);
	Landscapes = new Cons<Landscape>(new Landscape(Jeep.Position,___randr00), (Landscapes)).ToList<Landscape>();
	s0 = 2;
return;
	case 2:
	count_down1 = 2f;
	goto case 3;
	case 3:
	if(((count_down1) > (0f)))
	{

	count_down1 = ((count_down1) - (dt));
	s0 = 3;
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
	Health = Health;
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
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	___new_zombies30 = (

(Landscapes).Select(__ContextSymbol10 => new { ___a32 = __ContextSymbol10 })
.SelectMany(__ContextSymbol11=> (__ContextSymbol11.___a32.Zombies).Select(__ContextSymbol12 => new { ___b30 = __ContextSymbol12,
                                                      prev = __ContextSymbol11 })
.Select(__ContextSymbol13 => __ContextSymbol13.___b30)
.ToList<Zombie>())).ToList<Zombie>();
	Zombies = ___new_zombies30;
	s3 = -1;
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

	goto case 3;	}else
	{

	s0 = -1;
return;	}
	case 3:
	Trigger = true;
	s0 = 4;
return;
	case 4:
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
	public System.Single count_down2;
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
	if(UnityEngine.Input.GetKey(KeyCode.C))
	{

	goto case 8;	}else
	{

	s0 = -1;
return;	}
	case 8:
	Reloading = false;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(UnityEngine.Input.GetKey(KeyCode.R))
	{

	goto case 11;	}else
	{

	s1 = -1;
return;	}
	case 11:
	Reloading = true;
	Ammo = Ammo;
	s1 = 13;
return;
	case 13:
	count_down2 = ReloadDuration;
	goto case 14;
	case 14:
	if(((count_down2) > (0f)))
	{

	count_down2 = ((count_down2) - (dt));
	s1 = 14;
return;	}else
	{

	goto case 12;	}
	case 12:
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

	goto case 17;	}else
	{

	s2 = -1;
return;	}
	case 17:
	Ammo = ((Ammo) - (1));
	s2 = 18;
return;
	case 18:
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

	goto case 21;	}else
	{

	goto case 22;	}
	case 21:
	Battery = ((Battery) - (0.5f));
	s0 = -1;
return;
	case 22:
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
private UnityEngine.Vector3 pos;
private System.Int32 ps;
	public int ID;
public Landscape(UnityEngine.Vector3 pos, System.Int32 ps)
	{JustEntered = false;
 frame = World.frame;
		Zombies = (

Enumerable.Empty<Zombie>()).ToList<Zombie>();
		UnityLandscape = UnityLandscape.Instantiate(pos,ps);
		Spawnpoints = (

Enumerable.Empty<UnityEngine.Transform>()).ToList<UnityEngine.Transform>();
		
}
		public UnityCheckpoint Checkpoint{  get { return UnityLandscape.Checkpoint; }
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
	public List<UnityEngine.Transform> ___sps00;
	public System.Int32 ___random_spawnp10;
	public UnityEngine.Transform ___sps11;
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
	___sps00 = (

(Spawnpoints2).Select(__ContextSymbol18 => new { ___a03 = __ContextSymbol18 })
.Select(__ContextSymbol19 => __ContextSymbol19.___a03)
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

	goto case 5;	}
	case 5:
	___random_spawnp10 = UnityEngine.Random.Range(0,4);
	___sps11 = (Spawnpoints)[___random_spawnp10];
	___sps_pos10 = ___sps11.position;
	___zmbies10 = (

(new Cons<Zombie>(new Zombie(___sps_pos10),(new Empty<Zombie>()).ToList<Zombie>())).ToList<Zombie>()).ToList<Zombie>();
	Zombies = ___zmbies10;
	Spawnpoints = (

Enumerable.Empty<UnityEngine.Transform>()).ToList<UnityEngine.Transform>();
	s1 = 0;
return;
	case 0:
	Zombies = (

Enumerable.Empty<Zombie>()).ToList<Zombie>();
	Spawnpoints = (

Enumerable.Empty<UnityEngine.Transform>()).ToList<UnityEngine.Transform>();
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
		TruckScript = TruckScript.Instantiate();
		Fuel = 40f;
		DriveEngine = new Engine();
		
}
		public Engine DriveEngine;
	public UnityEngine.Vector3 Frce{  get { return TruckScript.Frce; }
  set{TruckScript.Frce = value; }
 }
	public System.Single Fuel;
	public UnityEngine.Vector3 Position{  get { return TruckScript.Position; }
 }
	public UnityEngine.Vector3 Trque{  set{TruckScript.Trque = value; }
 }
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
		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	UnityEngine.Debug.Log(("Fuel amount left = ") + (Fuel));
	if(((world.Jeep.DriveEngine.Active) && (((Fuel) > (0.99f)))))
	{

	goto case 7;	}else
	{

	goto case 8;	}
	case 7:
	Fuel = ((Fuel) - (1f));
	s0 = -1;
return;
	case 8:
	Fuel = 0f;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	Trque = new UnityEngine.Vector3(0f,(40f) * (DriveEngine.Rotation),0f);
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(((((DriveEngine.Accel) > (0f))) && (((DriveEngine.BrakeAndReverse) > (0f)))))
	{

	goto case 1;	}else
	{

	goto case 2;	}
	case 1:
	Frce = Vector3.zero;
	s2 = -1;
return;
	case 2:
	if(((DriveEngine.Accel) > (0f)))
	{

	goto case 9;	}else
	{

	goto case 5;	}
	case 9:
	Frce = new UnityEngine.Vector3(0f,0f,(-180f) * (DriveEngine.Accel));
	s2 = 5;
return;
	case 5:
	if(((DriveEngine.BrakeAndReverse) > (0f)))
	{

	goto case 6;	}else
	{

	s2 = -1;
return;	}
	case 6:
	Frce = new UnityEngine.Vector3(0f,0f,(300f) * (DriveEngine.BrakeAndReverse));
	s2 = -1;
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
		Rotation = 0.8f;
		BrakeAndReverse = 0f;
		Active = true;
		Accel = 0.9f;
		
}
		public System.Single Accel;
	public System.Boolean Active;
	public System.Single BrakeAndReverse;
	public System.Single Rotation;
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
		UnityZombie = UnityZombie.Instantiate(pos);
		Life = 100f;
		
}
		public System.Boolean Destroyed{  get { return UnityZombie.Destroyed; }
  set{UnityZombie.Destroyed = value; }
 }
	public System.Single Life;
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
	UnityEngine.Debug.Log(("Life left = ") + (Life));
	if(((Life) > (0.49f)))
	{

	goto case 11;	}else
	{

	goto case 12;	}
	case 11:
	Life = ((Life) - (1.5f));
	s0 = -1;
return;
	case 12:
	Life = 0f;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(!(((Life) == (0f))))
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