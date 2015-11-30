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
		Truck ___truk00;
		___truk00 = new Truck("zpickup",new UnityEngine.Vector3(0f,-6f,0f),false);
		Zombies = (

Enumerable.Empty<Zombie>()).ToList<Zombie>();
		UnityLandscape = new UnityLandscape();
		Pistols = (

Enumerable.Empty<Gun>()).ToList<Gun>();
		Landscapes = (

(new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,-160f),1),(new Cons<Landscape>(new Landscape(Vector3.zero,2),(new Empty<Landscape>()).ToList<Landscape>())).ToList<Landscape>())).ToList<Landscape>()).ToList<Landscape>();
		Jeep = (new Just<Truck>(___truk00));
		Gasstations = (

(new Cons<Gasstation>(new Gasstation(new UnityEngine.Vector3(0f,0f,-80f)),(new Empty<Gasstation>()).ToList<Gasstation>())).ToList<Gasstation>()).ToList<Gasstation>();
		GUIpanel = new GUI();
		Flashs = (

Enumerable.Empty<Light>()).ToList<Light>();
		Counter = 3;
		Controllers = (

Enumerable.Empty<ControllerRazor>()).ToList<ControllerRazor>();
		Bullets = (

Enumerable.Empty<Bullet>()).ToList<Bullet>();
		ActiveBoR = "";
		
}
		public System.String ActiveBoR;
	public List<Bullet> Bullets;
	public UnityCheckpoint Checkpoint{  get { return UnityLandscape.Checkpoint; }
 }
	public List<ControllerRazor> __Controllers;
	public List<ControllerRazor> Controllers{  get { return  __Controllers; }
  set{ __Controllers = value;
 foreach(var e in value){if(e.JustEntered){ e.JustEntered = false;
}
} }
 }
	public System.Int32 Counter;
	public System.Boolean Destroyed{  get { return UnityLandscape.Destroyed; }
  set{UnityLandscape.Destroyed = value; }
 }
	public List<Light> Flashs;
	public GUI GUIpanel;
	public List<Gasstation> Gasstations;
	public Option<Truck> Jeep;
	public List<Landscape> Landscapes;
	public List<Gun> __Pistols;
	public List<Gun> Pistols{  get { return  __Pistols; }
  set{ __Pistols = value;
 foreach(var e in value){if(e.JustEntered){ e.JustEntered = false;
}
} }
 }
	public UnityEngine.Vector3 Position{  get { return UnityLandscape.Position; }
 }
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
	public List<Landscape> ___ls20;
	public List<Gasstation> ___gs20;
	public System.Int32 ___randr20;
	public UnityEngine.Vector3 ___Headpos20;
	public UnityEngine.Vector3 ___Headpos21;
	public List<System.String> ___a32;
	public List<System.String> ___resourcelist40;
	public System.Int32 ___rnd40;
	public List<Zombie> ___zmbies50;
	public List<GroupZombie> ___groups60;
	public List<Zombie> ___zombiegroup60;
	public List<Zombie> ___groupleader60;
	public List<Zombie> ___group60;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;

		for(int x0 = 0; x0 < Bullets.Count; x0++) { 
			Bullets[x0].Update(dt, world);
		}
		for(int x0 = 0; x0 < Controllers.Count; x0++) { 
			Controllers[x0].Update(dt, world);
		}
		for(int x0 = 0; x0 < Flashs.Count; x0++) { 
			Flashs[x0].Update(dt, world);
		}
		GUIpanel.Update(dt, world);
		for(int x0 = 0; x0 < Gasstations.Count; x0++) { 
			Gasstations[x0].Update(dt, world);
		}
if(Jeep.IsSome){ 		Jeep.Value.Update(dt, world);
 } 
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
		this.Rule2(dt, world);
		this.Rule3(dt, world);
		this.Rule4(dt, world);
		this.Rule5(dt, world);
		this.Rule6(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(!(Jeep.Value.Active))
	{

	s0 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	Controllers = (

(new Cons<ControllerRazor>(new ControllerRazor("Hydra1 - Right"),(new Cons<ControllerRazor>(new ControllerRazor("Hydra1 - Left"),(new Empty<ControllerRazor>()).ToList<ControllerRazor>())).ToList<ControllerRazor>())).ToList<ControllerRazor>()).ToList<ControllerRazor>();
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
	if(!(Jeep.Value.Active))
	{

	s1 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	Pistols = (

(new Cons<Gun>(new Gun("MachineGun",0,Controllers[0]),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	Flashs = (

(new Cons<Light>(new Light(Controllers[1]),(new Empty<Light>()).ToList<Light>())).ToList<Light>()).ToList<Light>();
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
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	___ls20 = (

(Landscapes).Select(__ContextSymbol10 => new { ___a20 = __ContextSymbol10 })
.Select(__ContextSymbol11 => __ContextSymbol11.___a20)
.ToList<Landscape>()).ToList<Landscape>();
	___gs20 = (

(Gasstations).Select(__ContextSymbol12 => new { ___b20 = __ContextSymbol12 })
.Select(__ContextSymbol13 => __ContextSymbol13.___b20)
.ToList<Gasstation>()).ToList<Gasstation>();
	if(((___ls20.Count) > (0)))
	{

	goto case 4;	}else
	{

	s2 = -1;
return;	}
	case 4:
	___randr20 = UnityEngine.Random.Range(1,5);
	if(((___gs20.Count) > (0)))
	{

	goto case 5;	}else
	{

	goto case 6;	}
	case 5:
	if(((___gs20.Head().Position.z) > (___ls20.Head().Position.z)))
	{

	___Headpos20 = ___ls20.Head().Position;	}else
	{

	___Headpos20 = ___gs20.Head().Position;	}
	if(((Counter) > (7)))
	{

	goto case 8;	}else
	{

	goto case 9;	}
	case 8:
	Landscapes = Landscapes;
	Counter = 0;
	Gasstations = new Cons<Gasstation>(new Gasstation(new UnityEngine.Vector3(0f,0f,(___Headpos20.z) - (80f))), (Gasstations)).ToList<Gasstation>();
	s2 = 11;
return;
	case 11:
	if(!(((200f) > (UnityEngine.Vector3.Distance(___Headpos20,Jeep.Value.Position)))))
	{

	s2 = 11;
return;	}else
	{

	s2 = -1;
return;	}
	case 9:
	Landscapes = new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,(___Headpos20.z) - (80f)),___randr20), (Landscapes)).ToList<Landscape>();
	Counter = ((Counter) + (1));
	Gasstations = Gasstations;
	s2 = 14;
return;
	case 14:
	Landscapes = Landscapes;
	Counter = Counter;
	Gasstations = Gasstations;
	s2 = 13;
return;
	case 13:
	if(!(((200f) > (UnityEngine.Vector3.Distance(___Headpos20,Jeep.Value.Position)))))
	{

	s2 = 13;
return;	}else
	{

	s2 = -1;
return;	}
	case 6:
	___Headpos21 = ___ls20.Head().Position;
	if(((Counter) > (7)))
	{

	goto case 17;	}else
	{

	goto case 18;	}
	case 17:
	Landscapes = Landscapes;
	Counter = 0;
	Gasstations = new Cons<Gasstation>(new Gasstation(new UnityEngine.Vector3(0f,0f,(___Headpos21.z) - (80f))), (Gasstations)).ToList<Gasstation>();
	s2 = 20;
return;
	case 20:
	if(!(((200f) > (UnityEngine.Vector3.Distance(___Headpos21,Jeep.Value.Position)))))
	{

	s2 = 20;
return;	}else
	{

	s2 = -1;
return;	}
	case 18:
	Landscapes = new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,(___Headpos21.z) - (80f)),___randr20), (Landscapes)).ToList<Landscape>();
	Counter = ((Counter) + (1));
	Gasstations = Gasstations;
	s2 = 23;
return;
	case 23:
	Landscapes = Landscapes;
	Counter = Counter;
	Gasstations = Gasstations;
	s2 = 22;
return;
	case 22:
	if(!(((200f) > (UnityEngine.Vector3.Distance(___Headpos21,Jeep.Value.Position)))))
	{

	s2 = 22;
return;	}else
	{

	s2 = -1;
return;	}	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	___a32 = (

(Landscapes).Select(__ContextSymbol14 => new { ___a31 = __ContextSymbol14 })
.SelectMany(__ContextSymbol15=> (__ContextSymbol15.___a31.PickUps).Select(__ContextSymbol16 => new { ___b31 = __ContextSymbol16,
                                                      prev = __ContextSymbol15 })
.SelectMany(__ContextSymbol17=> (__ContextSymbol17.___b31.BonusAndResources).Select(__ContextSymbol18 => new { ___c30 = __ContextSymbol18,
                                                      prev = __ContextSymbol17 })
.Where(__ContextSymbol19 => __ContextSymbol19.___c30.Active)
.Select(__ContextSymbol20 => __ContextSymbol20.___c30.NameOfBoR)
.ToList<System.String>()))).ToList<System.String>();
	if(((___a32.Count) > (0)))
	{

	goto case 30;	}else
	{

	s3 = -1;
return;	}
	case 30:
	UnityEngine.Debug.Log(___a32.Head());
	ActiveBoR = ___a32.Head();
	s3 = 31;
return;
	case 31:
	ActiveBoR = "";
	s3 = -1;
return;	
	default: return;}}
	

	int s4=-1;
	public void Rule4(float dt, World world){ 
	switch (s4)
	{

	case -1:
	if(((ActiveBoR) == ("Crossed Wrenches Red")))
	{

	goto case 36;	}else
	{

	s4 = -1;
return;	}
	case 36:
	___resourcelist40 = (

(new Cons<System.String>("Medipack Red",(new Cons<System.String>("Battery Black",(new Cons<System.String>("Jerry Can Green",(new Empty<System.String>()).ToList<System.String>())).ToList<System.String>())).ToList<System.String>())).ToList<System.String>()).ToList<System.String>();
	___rnd40 = UnityEngine.Random.Range(0,3);
	ActiveBoR = (___resourcelist40)[___rnd40];
	s4 = -1;
return;	
	default: return;}}
	

	int s5=-1;
	public void Rule5(float dt, World world){ 
	switch (s5)
	{

	case -1:
	___zmbies50 = (

(Zombies).Select(__ContextSymbol22 => new { ___a53 = __ContextSymbol22 })
.Where(__ContextSymbol23 => ((__ContextSymbol23.___a53.Destroyed) == (false)))
.Select(__ContextSymbol24 => __ContextSymbol24.___a53)
.ToList<Zombie>()).ToList<Zombie>();
	Zombies = ___zmbies50;
	s5 = -1;
return;	
	default: return;}}
	

	int s6=-1;
	public void Rule6(float dt, World world){ 
	switch (s6)
	{

	case -1:
	___groups60 = (

(Landscapes).Select(__ContextSymbol25 => new { ___a64 = __ContextSymbol25 })
.SelectMany(__ContextSymbol26=> (__ContextSymbol26.___a64.Group).Select(__ContextSymbol27 => new { ___b62 = __ContextSymbol27,
                                                      prev = __ContextSymbol26 })
.Select(__ContextSymbol28 => __ContextSymbol28.___b62)
.ToList<GroupZombie>())).ToList<GroupZombie>();
	___zombiegroup60 = (

(___groups60).Select(__ContextSymbol29 => new { ___a65 = __ContextSymbol29 })
.SelectMany(__ContextSymbol30=> (__ContextSymbol30.___a65.ZombieFollowers).Select(__ContextSymbol31 => new { ___c61 = __ContextSymbol31,
                                                      prev = __ContextSymbol30 })
.Select(__ContextSymbol32 => __ContextSymbol32.___c61)
.ToList<Zombie>())).ToList<Zombie>();
	___groupleader60 = (

(___groups60).Select(__ContextSymbol33 => new { ___a66 = __ContextSymbol33 })
.Where(__ContextSymbol34 => __ContextSymbol34.___a66.ZombieLeader.IsSome)
.Select(__ContextSymbol35 => new {___z60 = __ContextSymbol35.___a66.ZombieLeader.Value, prev = __ContextSymbol35 })
.Select(__ContextSymbol36 => __ContextSymbol36.___z60)
.ToList<Zombie>()).ToList<Zombie>();
	___group60 = (___groupleader60).Concat(___zombiegroup60).ToList<Zombie>();
	if(((___group60.Count) > (0)))
	{

	goto case 3;	}else
	{

	s6 = -1;
return;	}
	case 3:
	Zombies = (___group60).Concat(Zombies).ToList<Zombie>();
	s6 = -1;
return;	
	default: return;}}
	





}
public class Bullet{
public int frame;
public bool JustEntered = true;
private UnityEngine.Vector3 pos;
private UnityEngine.Vector3 dir;
	public int ID;
public Bullet(UnityEngine.Vector3 pos, UnityEngine.Vector3 dir)
	{JustEntered = false;
 frame = World.frame;
		cnt = 0f;
		UnityBullet = UnityBullet.Instantiate(pos,"bullet");
		Dir = dir;
		
}
		public UnityEngine.Vector3 Dir;
	public System.Single Frce{  set{UnityBullet.Frce = value; }
 }
	public UnityEngine.Rigidbody Rbody{  get { return UnityBullet.Rbody; }
  set{UnityBullet.Rbody = value; }
 }
	public UnityEngine.Vector3 Rotat{  get { return UnityBullet.Rotat; }
  set{UnityBullet.Rotat = value; }
 }
	public UnityBullet UnityBullet;
	public System.Single cnt;
	public System.Boolean enabled{  get { return UnityBullet.enabled; }
  set{UnityBullet.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityBullet.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityBullet.hideFlags; }
  set{UnityBullet.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityBullet.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityBullet.name; }
  set{UnityBullet.name = value; }
 }
	public System.String tag{  get { return UnityBullet.tag; }
  set{UnityBullet.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityBullet.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityBullet.useGUILayout; }
  set{UnityBullet.useGUILayout = value; }
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
	Rotat = Dir;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(!(((40f) > (cnt))))
	{

	goto case 0;	}else
	{

	goto case 2;	}
	case 2:
	Frce = 1f;
	cnt = ((cnt) + (10f));
	s1 = -1;
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
public class Gasstation{
public int frame;
public bool JustEntered = true;
private UnityEngine.Vector3 ps;
	public int ID;
public Gasstation(UnityEngine.Vector3 ps)
	{JustEntered = false;
 frame = World.frame;
		UnityGasstation = UnityGasstation.Instantiate(ps);
		
}
		public System.Collections.Generic.List<System.String> Jeeps{  get { return UnityGasstation.Jeeps; }
 }
	public System.Collections.Generic.List<UnityEngine.Transform> ParkingSpotList{  get { return UnityGasstation.ParkingSpotList; }
 }
	public UnityEngine.Vector3 Position{  get { return UnityGasstation.Position; }
 }
	public UnityGasstation UnityGasstation;
	public System.Boolean enabled{  get { return UnityGasstation.enabled; }
  set{UnityGasstation.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityGasstation.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityGasstation.hideFlags; }
  set{UnityGasstation.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityGasstation.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityGasstation.name; }
  set{UnityGasstation.name = value; }
 }
	public System.String tag{  get { return UnityGasstation.tag; }
  set{UnityGasstation.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityGasstation.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityGasstation.useGUILayout; }
  set{UnityGasstation.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;



	}











}
public class GroupZombie{
public int frame;
public bool JustEntered = true;
private UnityEngine.Vector3 sps;
	public int ID;
public GroupZombie(UnityEngine.Vector3 sps)
	{JustEntered = false;
 frame = World.frame;
		ZombieLeader = (new Nothing<Zombie>());
		ZombieFollowers = (

Enumerable.Empty<Zombie>()).ToList<Zombie>();
		UnityGroup = UnityGroup.Instantiate(sps);
		
}
		public UnityEngine.Transform U_ZombieLeader{  get { return UnityGroup.U_ZombieLeader; }
 }
	public System.Collections.Generic.List<UnityEngine.Transform> U_Zombies{  get { return UnityGroup.U_Zombies; }
 }
	public UnityGroup UnityGroup;
	public List<Zombie> ZombieFollowers;
	public Option<Zombie> ZombieLeader;
	public System.Boolean enabled{  get { return UnityGroup.enabled; }
  set{UnityGroup.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityGroup.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityGroup.hideFlags; }
  set{UnityGroup.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityGroup.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityGroup.name; }
  set{UnityGroup.name = value; }
 }
	public System.String tag{  get { return UnityGroup.tag; }
  set{UnityGroup.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityGroup.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityGroup.useGUILayout; }
  set{UnityGroup.useGUILayout = value; }
 }
	public List<Zombie> ___z01;
	public Zombie ___leader10;
	public void Update(float dt, World world) {
frame = World.frame;

		for(int x0 = 0; x0 < ZombieFollowers.Count; x0++) { 
			ZombieFollowers[x0].Update(dt, world);
		}
if(ZombieLeader.IsSome){ 		ZombieLeader.Value.Update(dt, world);
 } 
		this.Rule0(dt, world);
		this.Rule1(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	___z01 = (

(U_Zombies).Select(__ContextSymbol39 => new { ___a07 = __ContextSymbol39 })
.Select(__ContextSymbol40 => new Zombie(__ContextSymbol40.___a07))
.ToList<Zombie>()).ToList<Zombie>();
	ZombieFollowers = ___z01;
	s0 = 1;
return;
	case 1:
	ZombieFollowers = (

Enumerable.Empty<Zombie>()).ToList<Zombie>();
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
	___leader10 = new Zombie(U_ZombieLeader);
	ZombieLeader = (new Just<Zombie>(___leader10));
	s1 = 1;
return;
	case 1:
	ZombieLeader = (new Nothing<Zombie>());
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
public class ControllerRazor{
public int frame;
public bool JustEntered = true;
private System.String joystickName;
	public int ID;
public ControllerRazor(System.String joystickName)
	{JustEntered = false;
 frame = World.frame;
		SixenseHand = SixenseHand.Instantiate(joystickName);
		
}
		public System.Boolean Bumper{  get { return SixenseHand.Bumper; }
  set{SixenseHand.Bumper = value; }
 }
	public UnityEngine.Vector3 Forward{  get { return SixenseHand.Forward; }
 }
	public SixenseHands Hand{  get { return SixenseHand.Hand; }
 }
	public UnityEngine.Vector3 InitialPosition{  get { return SixenseHand.InitialPosition; }
 }
	public UnityEngine.Quaternion InitialRotation{  get { return SixenseHand.InitialRotation; }
 }
	public UnityEngine.Vector3 Position{  get { return SixenseHand.Position; }
 }
	public System.Boolean RaycastBool{  get { return SixenseHand.RaycastBool; }
 }
	public System.Boolean Shot{  get { return SixenseHand.Shot; }
  set{SixenseHand.Shot = value; }
 }
	public SixenseHand SixenseHand;
	public System.Boolean Trigger{  get { return SixenseHand.Trigger; }
  set{SixenseHand.Trigger = value; }
 }
	public System.Boolean enabled{  get { return SixenseHand.enabled; }
  set{SixenseHand.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return SixenseHand.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return SixenseHand.hideFlags; }
  set{SixenseHand.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return SixenseHand.isActiveAndEnabled; }
 }
	public Controller m_controller{  get { return SixenseHand.m_controller; }
  set{SixenseHand.m_controller = value; }
 }
	public SixenseHands m_hand{  get { return SixenseHand.m_hand; }
  set{SixenseHand.m_hand = value; }
 }
	public System.String name{  get { return SixenseHand.name; }
  set{SixenseHand.name = value; }
 }
	public System.String tag{  get { return SixenseHand.tag; }
  set{SixenseHand.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return SixenseHand.transform; }
 }
	public System.Boolean useGUILayout{  get { return SixenseHand.useGUILayout; }
  set{SixenseHand.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;

		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	Bumper = Bumper;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	Trigger = Trigger;
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(((Trigger) || (UnityEngine.Input.GetMouseButtonDown(0))))
	{

	goto case 1;	}else
	{

	goto case 2;	}
	case 1:
	Shot = true;
	s2 = -1;
return;
	case 2:
	Shot = false;
	s2 = -1;
return;	
	default: return;}}
	





}
public class Gun{
public int frame;
public bool JustEntered = true;
private System.String st;
private System.Int32 ind;
private ControllerRazor GC;
	public int ID;
public Gun(System.String st, System.Int32 ind, ControllerRazor GC)
	{JustEntered = false;
 frame = World.frame;
		System.Boolean ___autom00;
		if(!(((st) == ("MachineGun"))))
			{
			___autom00 = false;
			}else
			{
			___autom00 = true;
			}
		List<System.Int32> ___InMagList00;
		___InMagList00 = (

(new Cons<System.Int32>(50,(new Cons<System.Int32>(20,(new Cons<System.Int32>(5,(new Cons<System.Int32>(6,(new Cons<System.Int32>(0,(new Empty<System.Int32>()).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>()).ToList<System.Int32>();
		List<System.Int32> ___NotInMagList00;
		___NotInMagList00 = (

(new Cons<System.Int32>(850,(new Cons<System.Int32>(200,(new Cons<System.Int32>(60,(new Cons<System.Int32>(90,(new Cons<System.Int32>(16,(new Empty<System.Int32>()).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>()).ToList<System.Int32>();
		List<System.Int32> ___ClipSizeList00;
		___ClipSizeList00 = (

(new Cons<System.Int32>(150,(new Cons<System.Int32>(20,(new Cons<System.Int32>(5,(new Cons<System.Int32>(6,(new Cons<System.Int32>(1,(new Empty<System.Int32>()).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>()).ToList<System.Int32>();
		List<System.Single> ___ReloadDurationList00;
		___ReloadDurationList00 = (

(new Cons<System.Single>(7f,(new Cons<System.Single>(3f,(new Cons<System.Single>(4f,(new Cons<System.Single>(2f,(new Cons<System.Single>(5f,(new Empty<System.Single>()).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>()).ToList<System.Single>();
		List<System.Single> ___DamageList00;
		___DamageList00 = (

(new Cons<System.Single>(40f,(new Cons<System.Single>(40f,(new Cons<System.Single>(135f,(new Cons<System.Single>(100f,(new Cons<System.Single>(400f,(new Empty<System.Single>()).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>()).ToList<System.Single>();
		List<System.Single> ___GunPowerList00;
		___GunPowerList00 = (

(new Cons<System.Single>(2.4f,(new Cons<System.Single>(0.8f,(new Cons<System.Single>(2.4f,(new Cons<System.Single>(1.8f,(new Cons<System.Single>(5f,(new Empty<System.Single>()).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>()).ToList<System.Single>();
		UnityGun = UnityGun.Instantiate(st);
		TypeWeapon = st;
		Reloading = false;
		ReloadDuration = ___ReloadDurationList00[ind];
		NotInMagazine = ___NotInMagList00[ind];
		MagazineSize = ___ClipSizeList00[ind];
		InMagazine = ___InMagList00[ind];
		GunPower = ___GunPowerList00[ind];
		GunController = GC;
		DamagePerBullet = ___DamageList00[ind];
		Automatic = ___autom00;
		
}
		public System.Boolean Automatic;
	public System.Single DamagePerBullet;
	public ControllerRazor GunController;
	public System.Single GunForce{  get { return UnityGun.GunForce; }
  set{UnityGun.GunForce = value; }
 }
	public System.Single GunPower;
	public System.Int32 InMag{  get { return UnityGun.InMag; }
  set{UnityGun.InMag = value; }
 }
	public System.Int32 InMagazine;
	public UnityEngine.TextMesh MagazineBox{  get { return UnityGun.MagazineBox; }
  set{UnityGun.MagazineBox = value; }
 }
	public System.String MagazineGUI{  get { return UnityGun.MagazineGUI; }
  set{UnityGun.MagazineGUI = value; }
 }
	public System.Int32 MagazineSize;
	public System.Int32 NotInMag{  get { return UnityGun.NotInMag; }
  set{UnityGun.NotInMag = value; }
 }
	public System.Int32 NotInMagazine;
	public System.Single ReloadDuration;
	public System.Boolean Reloading;
	public System.Boolean Shoot{  get { return UnityGun.Shoot; }
  set{UnityGun.Shoot = value; }
 }
	public System.String TypeWeapon;
	public UnityGun UnityGun;
	public System.Boolean enabled{  get { return UnityGun.enabled; }
  set{UnityGun.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityGun.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityGun.hideFlags; }
  set{UnityGun.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityGun.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityGun.name; }
  set{UnityGun.name = value; }
 }
	public System.String tag{  get { return UnityGun.tag; }
  set{UnityGun.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityGun.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityGun.useGUILayout; }
  set{UnityGun.useGUILayout = value; }
 }
	public System.Single count_down1;
	public System.Int32 ___changed40;
	public System.Single count_down2;
	public void Update(float dt, World world) {
frame = World.frame;

		GunController.Update(dt, world);
		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
		this.Rule3(dt, world);
		this.Rule4(dt, world);
		this.Rule5(dt, world);
		this.Rule6(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	UnityEngine.Debug.Log(GunForce);
	GunForce = GunPower;
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
	if(UnityEngine.Input.GetKey(KeyCode.C))
	{

	goto case 4;	}else
	{

	s1 = -1;
return;	}
	case 4:
	Reloading = false;
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(((world.Pistols.Count) > (0)))
	{

	goto case 7;	}else
	{

	s2 = -1;
return;	}
	case 7:
	InMag = InMagazine;
	NotInMag = NotInMagazine;
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	if(((world.Pistols.Count) > (0)))
	{

	goto case 10;	}else
	{

	s3 = -1;
return;	}
	case 10:
	MagazineGUI = MagazineGUI;
	s3 = -1;
return;	
	default: return;}}
	

	int s4=-1;
	public void Rule4(float dt, World world){ 
	switch (s4)
	{

	case -1:
	if(((((UnityEngine.Input.GetKey(KeyCode.R)) || (((InMagazine) == (0))))) && (((NotInMagazine) > (0)))))
	{

	goto case 13;	}else
	{

	s4 = -1;
return;	}
	case 13:
	Reloading = true;
	NotInMagazine = NotInMagazine;
	InMagazine = InMagazine;
	s4 = 20;
return;
	case 20:
	count_down1 = ReloadDuration;
	goto case 21;
	case 21:
	if(((count_down1) > (0f)))
	{

	count_down1 = ((count_down1) - (dt));
	s4 = 21;
return;	}else
	{

	goto case 16;	}
	case 16:
	if(((MagazineSize) > (NotInMagazine)))
	{

	goto case 14;	}else
	{

	goto case 15;	}
	case 14:
	Reloading = false;
	NotInMagazine = 0;
	InMagazine = NotInMagazine;
	s4 = -1;
return;
	case 15:
	___changed40 = ((MagazineSize) - (InMagazine));
	Reloading = false;
	NotInMagazine = ((NotInMagazine) - (___changed40));
	InMagazine = MagazineSize;
	s4 = -1;
return;	
	default: return;}}
	

	int s5=-1;
	public void Rule5(float dt, World world){ 
	switch (s5)
	{

	case -1:
	if(((world.ActiveBoR) == ("AmmoBox")))
	{

	goto case 24;	}else
	{

	s5 = -1;
return;	}
	case 24:
	NotInMagazine = ((NotInMagazine) + (50));
	s5 = -1;
return;	
	default: return;}}
	

	int s6=-1;
	public void Rule6(float dt, World world){ 
	switch (s6)
	{

	case -1:
	if(!(GunController.Shot))
	{

	s6 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	if(((((InMagazine) > (0))) && (!(Reloading))))
	{

	goto case 1;	}else
	{

	s6 = -1;
return;	}
	case 1:
	if(!(Automatic))
	{

	goto case 2;	}else
	{

	goto case 3;	}
	case 2:
	Shoot = true;
	InMagazine = ((InMagazine) - (1));
	s6 = 5;
return;
	case 5:
	Shoot = false;
	InMagazine = InMagazine;
	s6 = -1;
return;
	case 3:
	if(!(((GunController.Shot) && (((InMagazine) > (0))))))
	{

	s6 = -1;
return;	}else
	{

	goto case 8;	}
	case 8:
	Shoot = true;
	InMagazine = ((InMagazine) - (1));
	s6 = 11;
return;
	case 11:
	Shoot = false;
	InMagazine = InMagazine;
	s6 = 9;
return;
	case 9:
	count_down2 = 0.05f;
	goto case 10;
	case 10:
	if(((count_down2) > (0f)))
	{

	count_down2 = ((count_down2) - (dt));
	s6 = 10;
return;	}else
	{

	s6 = 3;
return;	}	
	default: return;}}
	





}
public class Light{
public int frame;
public bool JustEntered = true;
private ControllerRazor LC;
	public int ID;
public Light(ControllerRazor LC)
	{JustEntered = false;
 frame = World.frame;
		LightController = LC;
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
		this.Rule1(dt, world);
		this.Rule2(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(((Active) && (((Battery) > (0.49f)))))
	{

	goto case 14;	}else
	{

	goto case 15;	}
	case 14:
	Battery = ((Battery) - (0.5f));
	s0 = -1;
return;
	case 15:
	Battery = Battery;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(((world.ActiveBoR) == ("Battery Black")))
	{

	goto case 20;	}else
	{

	s1 = -1;
return;	}
	case 20:
	UnityEngine.Debug.Log(("Battery = ") + (Battery));
	Battery = ((Battery) + (50f));
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	Active = LightController.Trigger;
	s2 = -1;
return;	
	default: return;}}
	





}
public class GUI{
public int frame;
public bool JustEntered = true;
	public int ID;
public GUI()
	{JustEntered = false;
 frame = World.frame;
		GUIBarScript = GUIBarScript.Find();
		
}
		public UnityEngine.Texture2D Background{  get { return GUIBarScript.Background; }
  set{GUIBarScript.Background = value; }
 }
	public System.Boolean DisplayText{  get { return GUIBarScript.DisplayText; }
  set{GUIBarScript.DisplayText = value; }
 }
	public System.Single FadeFactor{  get { return GUIBarScript.FadeFactor; }
  set{GUIBarScript.FadeFactor = value; }
 }
	public UnityEngine.Texture2D Foreground{  get { return GUIBarScript.Foreground; }
  set{GUIBarScript.Foreground = value; }
 }
	public GUIBarScript GUIBarScript;
	public System.Collections.Generic.List<UnityEngine.Color> GradientColors{  get { return GUIBarScript.GradientColors; }
  set{GUIBarScript.GradientColors = value; }
 }
	public System.Single HPValue{  get { return GUIBarScript.HPValue; }
  set{GUIBarScript.HPValue = value; }
 }
	public UnityEngine.Texture2D Mask{  get { return GUIBarScript.Mask; }
  set{GUIBarScript.Mask = value; }
 }
	public System.Boolean OverRideTextColorWithGradient{  get { return GUIBarScript.OverRideTextColorWithGradient; }
  set{GUIBarScript.OverRideTextColorWithGradient = value; }
 }
	public UnityEngine.Vector2 Position{  get { return GUIBarScript.Position; }
  set{GUIBarScript.Position = value; }
 }
	public System.Single ScaleSize{  get { return GUIBarScript.ScaleSize; }
  set{GUIBarScript.ScaleSize = value; }
 }
	public UnityEngine.Color TextColor{  get { return GUIBarScript.TextColor; }
  set{GUIBarScript.TextColor = value; }
 }
	public UnityEngine.Font TextFont{  get { return GUIBarScript.TextFont; }
  set{GUIBarScript.TextFont = value; }
 }
	public UnityEngine.Vector2 TextOffset{  get { return GUIBarScript.TextOffset; }
  set{GUIBarScript.TextOffset = value; }
 }
	public System.Single TextSize{  get { return GUIBarScript.TextSize; }
  set{GUIBarScript.TextSize = value; }
 }
	public System.String TextString{  get { return GUIBarScript.TextString; }
  set{GUIBarScript.TextString = value; }
 }
	public UnityEngine.Texture2D ValueBar{  get { return GUIBarScript.ValueBar; }
  set{GUIBarScript.ValueBar = value; }
 }
	public System.Boolean enabled{  get { return GUIBarScript.enabled; }
  set{GUIBarScript.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return GUIBarScript.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return GUIBarScript.hideFlags; }
  set{GUIBarScript.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return GUIBarScript.isActiveAndEnabled; }
 }
	public System.String name{  get { return GUIBarScript.name; }
  set{GUIBarScript.name = value; }
 }
	public System.String tag{  get { return GUIBarScript.tag; }
  set{GUIBarScript.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return GUIBarScript.transform; }
 }
	public System.Boolean useGUILayout{  get { return GUIBarScript.useGUILayout; }
  set{GUIBarScript.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;



	}











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
		UnityLandscape = UnityLandscape.Instantiate(pos,ps);
		Spawnpoints = (

Enumerable.Empty<UnityEngine.Transform>()).ToList<UnityEngine.Transform>();
		PickUps = (

Enumerable.Empty<PickUp>()).ToList<PickUp>();
		Group = (

Enumerable.Empty<GroupZombie>()).ToList<GroupZombie>();
		
}
		public UnityCheckpoint Checkpoint{  get { return UnityLandscape.Checkpoint; }
 }
	public System.Boolean Destroyed{  get { return UnityLandscape.Destroyed; }
  set{UnityLandscape.Destroyed = value; }
 }
	public List<GroupZombie> Group;
	public List<PickUp> PickUps;
	public UnityEngine.Vector3 Position{  get { return UnityLandscape.Position; }
 }
	public List<UnityEngine.Transform> Spawnpoints;
	public System.Collections.Generic.List<UnityEngine.Transform> Spawnpoints2{  get { return UnityLandscape.Spawnpoints2; }
 }
	public UnityLandscape UnityLandscape;
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
	public System.Int32 ___random_pickup10;
	public UnityEngine.Transform ___sps11;
	public UnityEngine.Vector3 ___sps_pos10;
	public UnityEngine.Transform ___rpu10;
	public UnityEngine.Vector3 ___rpu_pos10;
	public UnityEngine.Transform ___sps110;
	public UnityEngine.Vector3 ___sps_pos110;
	public UnityEngine.Transform ___rpu110;
	public UnityEngine.Vector3 ___rpu_pos110;
	public void Update(float dt, World world) {
frame = World.frame;

		for(int x0 = 0; x0 < Group.Count; x0++) { 
			Group[x0].Update(dt, world);
		}
		for(int x0 = 0; x0 < PickUps.Count; x0++) { 
			PickUps[x0].Update(dt, world);
		}
		this.Rule0(dt, world);
		this.Rule1(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	___sps00 = (

(Spawnpoints2).Select(__ContextSymbol54 => new { ___a08 = __ContextSymbol54 })
.Select(__ContextSymbol55 => __ContextSymbol55.___a08)
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
	if(!(((((Spawnpoints.Count) > (0))) && (((world.Pistols.Count) > (0))))))
	{

	s1 = -1;
return;	}else
	{

	goto case 16;	}
	case 16:
	___random_spawnp10 = UnityEngine.Random.Range(0,4);
	___random_pickup10 = UnityEngine.Random.Range(0,4);
	if(!(((___random_spawnp10) == (___random_pickup10))))
	{

	goto case 0;	}else
	{

	goto case 1;	}
	case 0:
	___sps11 = (Spawnpoints)[___random_spawnp10];
	___sps_pos10 = ___sps11.position;
	___rpu10 = (Spawnpoints)[___random_pickup10];
	___rpu_pos10 = ___rpu10.position;
	Group = (

(new Cons<GroupZombie>(new GroupZombie(___sps_pos10),(new Empty<GroupZombie>()).ToList<GroupZombie>())).ToList<GroupZombie>()).ToList<GroupZombie>();
	PickUps = (

(new Cons<PickUp>(new PickUp(___rpu_pos10),(new Empty<PickUp>()).ToList<PickUp>())).ToList<PickUp>()).ToList<PickUp>();
	Spawnpoints = (

Enumerable.Empty<UnityEngine.Transform>()).ToList<UnityEngine.Transform>();
	s1 = 3;
return;
	case 3:
	if(!(false))
	{

	s1 = 3;
return;	}else
	{

	s1 = -1;
return;	}
	case 1:
	___sps110 = (Spawnpoints)[1];
	___sps_pos110 = ___sps110.position;
	___rpu110 = (Spawnpoints)[2];
	___rpu_pos110 = ___rpu110.position;
	Group = (

(new Cons<GroupZombie>(new GroupZombie(___sps_pos110),(new Empty<GroupZombie>()).ToList<GroupZombie>())).ToList<GroupZombie>()).ToList<GroupZombie>();
	PickUps = (

(new Cons<PickUp>(new PickUp(___rpu_pos110),(new Empty<PickUp>()).ToList<PickUp>())).ToList<PickUp>()).ToList<PickUp>();
	Spawnpoints = (

Enumerable.Empty<UnityEngine.Transform>()).ToList<UnityEngine.Transform>();
	s1 = 9;
return;
	case 9:
	if(!(false))
	{

	s1 = 9;
return;	}else
	{

	s1 = -1;
return;	}	
	default: return;}}
	





}
public class PickUp{
public int frame;
public bool JustEntered = true;
private UnityEngine.Vector3 pos;
	public int ID;
public PickUp(UnityEngine.Vector3 pos)
	{JustEntered = false;
 frame = World.frame;
		UnityPickUp = new UnityPickUp();
		BonusAndResources = (

Enumerable.Empty<BonusAndResource>()).ToList<BonusAndResource>();
		BARpos = pos;
		
}
		public UnityEngine.Vector3 BARpos;
	public List<BonusAndResource> BonusAndResources;
	public System.Collections.Generic.List<System.String> Shuffled{  get { return UnityPickUp.Shuffled; }
  set{UnityPickUp.Shuffled = value; }
 }
	public UnityPickUp UnityPickUp;
	public System.Boolean enabled{  get { return UnityPickUp.enabled; }
  set{UnityPickUp.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityPickUp.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityPickUp.hideFlags; }
  set{UnityPickUp.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityPickUp.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityPickUp.name; }
  set{UnityPickUp.name = value; }
 }
	public System.String tag{  get { return UnityPickUp.tag; }
  set{UnityPickUp.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityPickUp.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityPickUp.useGUILayout; }
  set{UnityPickUp.useGUILayout = value; }
 }
	public List<System.String> ___BARlist00;
	public UnityEngine.Vector3 ___p010;
	public UnityEngine.Vector3 ___p110;
	public UnityEngine.Vector3 ___p210;
	public UnityEngine.Vector3 ___p310;
	public List<UnityEngine.Vector3> ___plist10;
	public System.Collections.Generic.List<System.String> ___Slist10;
	public List<BonusAndResource> ___BAR10;
	public List<BonusAndResource> ___amount20;
	public void Update(float dt, World world) {
frame = World.frame;

		for(int x0 = 0; x0 < BonusAndResources.Count; x0++) { 
			BonusAndResources[x0].Update(dt, world);
		}
		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	___BARlist00 = (

(new Cons<System.String>("AmmoBox",(new Cons<System.String>("Crossed Wrenches Red",(new Cons<System.String>("Medipack Red",(new Cons<System.String>("Battery Black",(new Cons<System.String>("Jerry Can Green",(new Cons<System.String>("Lightning Blue",(new Cons<System.String>("Arrows Green",(new Cons<System.String>("Bomb Red",(new Cons<System.String>("Shield Metal",(new Cons<System.String>("Star Red",(new Empty<System.String>()).ToList<System.String>())).ToList<System.String>())).ToList<System.String>())).ToList<System.String>())).ToList<System.String>())).ToList<System.String>())).ToList<System.String>())).ToList<System.String>())).ToList<System.String>())).ToList<System.String>())).ToList<System.String>()).ToList<System.String>();
	Shuffled = ___BARlist00;
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
	if(!(((Shuffled.Count) > (0))))
	{

	s1 = -1;
return;	}else
	{

	goto case 8;	}
	case 8:
	___p010 = BARpos;
	___p110 = ((BARpos) - (new UnityEngine.Vector3(2f,0f,0f)));
	___p210 = ((BARpos) + (new UnityEngine.Vector3(2f,0f,0f)));
	___p310 = ((BARpos) - (new UnityEngine.Vector3(4f,0f,0f)));
	___plist10 = (

(new Cons<UnityEngine.Vector3>(___p010,(new Cons<UnityEngine.Vector3>(___p110,(new Cons<UnityEngine.Vector3>(___p210,(new Cons<UnityEngine.Vector3>(___p310,(new Empty<UnityEngine.Vector3>()).ToList<UnityEngine.Vector3>())).ToList<UnityEngine.Vector3>())).ToList<UnityEngine.Vector3>())).ToList<UnityEngine.Vector3>())).ToList<UnityEngine.Vector3>()).ToList<UnityEngine.Vector3>();
	___Slist10 = Shuffled;
	___BAR10 = (

(Enumerable.Range(0,(1) + ((3) - (0))).ToList<System.Int32>()).Select(__ContextSymbol66 => new { ___a19 = __ContextSymbol66 })
.Select(__ContextSymbol67 => new BonusAndResource(___plist10[__ContextSymbol67.___a19],___Slist10[__ContextSymbol67.___a19]))
.ToList<BonusAndResource>()).ToList<BonusAndResource>();
	BonusAndResources = ___BAR10;
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
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	___amount20 = (

(BonusAndResources).Select(__ContextSymbol68 => new { ___a210 = __ContextSymbol68 })
.Where(__ContextSymbol69 => ((__ContextSymbol69.___a210.Destroyed) == (false)))
.Select(__ContextSymbol70 => __ContextSymbol70.___a210)
.ToList<BonusAndResource>()).ToList<BonusAndResource>();
	BonusAndResources = ___amount20;
	s2 = -1;
return;	
	default: return;}}
	





}
public class BonusAndResource{
public int frame;
public bool JustEntered = true;
private UnityEngine.Vector3 pos;
private System.String bonus;
	public int ID;
public BonusAndResource(UnityEngine.Vector3 pos, System.String bonus)
	{JustEntered = false;
 frame = World.frame;
		UnityBonusResource = UnityBonusResource.Instantiate(pos,bonus);
		NameOfBoR = bonus;
		Active = false;
		
}
		public System.Boolean Active;
	public System.Boolean Destroyed{  get { return UnityBonusResource.Destroyed; }
  set{UnityBonusResource.Destroyed = value; }
 }
	public System.String NameOfBoR;
	public UnityBonusResource UnityBonusResource;
	public System.Boolean collids{  get { return UnityBonusResource.collids; }
  set{UnityBonusResource.collids = value; }
 }
	public System.Boolean enabled{  get { return UnityBonusResource.enabled; }
  set{UnityBonusResource.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityBonusResource.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityBonusResource.hideFlags; }
  set{UnityBonusResource.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityBonusResource.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityBonusResource.name; }
  set{UnityBonusResource.name = value; }
 }
	public System.String tag{  get { return UnityBonusResource.tag; }
  set{UnityBonusResource.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityBonusResource.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityBonusResource.useGUILayout; }
  set{UnityBonusResource.useGUILayout = value; }
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
	if(collids)
	{

	goto case 3;	}else
	{

	s0 = -1;
return;	}
	case 3:
	Active = true;
	Destroyed = false;
	s0 = 4;
return;
	case 4:
	Active = true;
	Destroyed = true;
	s0 = -1;
return;	
	default: return;}}
	






}
public class TruckStats{
public int frame;
public bool JustEntered = true;
private System.Boolean bs;
	public int ID;
public TruckStats(System.Boolean bs)
	{JustEntered = false;
 frame = World.frame;
		System.Int32 ___rnd01;
		___rnd01 = UnityEngine.Random.Range(0,5);
		List<System.Single> ___HealthList00;
		___HealthList00 = (

(new Cons<System.Single>(50f,(new Cons<System.Single>(60f,(new Cons<System.Single>(75f,(new Cons<System.Single>(80f,(new Cons<System.Single>(100f,(new Empty<System.Single>()).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>()).ToList<System.Single>();
		List<System.Single> ___MaxSpeedList00;
		___MaxSpeedList00 = (

(new Cons<System.Single>(10f,(new Cons<System.Single>(10f,(new Cons<System.Single>(10f,(new Cons<System.Single>(15f,(new Cons<System.Single>(20f,(new Empty<System.Single>()).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>()).ToList<System.Single>();
		List<System.Single> ___MaxSteeringList00;
		___MaxSteeringList00 = (

(new Cons<System.Single>(5f,(new Cons<System.Single>(10f,(new Cons<System.Single>(10f,(new Cons<System.Single>(20f,(new Cons<System.Single>(15f,(new Empty<System.Single>()).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>()).ToList<System.Single>();
		List<System.Single> ___HullList00;
		___HullList00 = (

(new Cons<System.Single>(8f,(new Cons<System.Single>(5f,(new Cons<System.Single>(3f,(new Cons<System.Single>(4f,(new Cons<System.Single>(2f,(new Empty<System.Single>()).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>()).ToList<System.Single>();
		List<System.Single> ___FuelList00;
		___FuelList00 = (

(new Cons<System.Single>(12000f,(new Cons<System.Single>(8000f,(new Cons<System.Single>(15000f,(new Cons<System.Single>(6000f,(new Cons<System.Single>(10000f,(new Empty<System.Single>()).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>()).ToList<System.Single>();
		isModel = bs;
		MaxSteering = ___MaxSteeringList00[___rnd01];
		MaxSpeed = ___MaxSpeedList00[___rnd01];
		Hull = ___HullList00[___rnd01];
		Health = ___HealthList00[___rnd01];
		Fuel = ___FuelList00[___rnd01];
		
}
		public System.Single Fuel;
	public System.Single Health;
	public System.Single Hull;
	public System.Single MaxSpeed;
	public System.Single MaxSteering;
	public System.Boolean isModel;
	public System.Single ___z02;
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
	if(!(((isModel) == (true))))
	{

	goto case 7;	}else
	{

	s0 = -1;
return;	}
	case 7:
	___z02 = world.Jeep.Value.CarHP2;
	if(!(((___z02) == (((Health) / (100f))))))
	{

	goto case 8;	}else
	{

	goto case 9;	}
	case 8:
	world.Jeep.Value.CarHP2 = world.Jeep.Value.CarHP2;
	Health = ((world.Jeep.Value.CarHP2) * (100f));
	world.GUIpanel.HPValue = world.Jeep.Value.CarHP2;
	s0 = -1;
return;
	case 9:
	world.Jeep.Value.CarHP2 = ((Health) / (100f));
	Health = ((world.Jeep.Value.CarHP2) * (100f));
	world.GUIpanel.HPValue = world.Jeep.Value.CarHP2;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(((((world.ActiveBoR) == ("Medipack Red"))) && (!(((isModel) == (true))))))
	{

	goto case 15;	}else
	{

	s1 = -1;
return;	}
	case 15:
	Health = ((Health) + (20f));
	world.Jeep.Value.CarHP2 = ((Health) / (100f));
	s1 = -1;
return;	
	default: return;}}
	





}
public class Truck{
public int frame;
public bool JustEntered = true;
private System.String nm;
private UnityEngine.Vector3 pos;
private System.Boolean ModelIs;
	public int ID;
public Truck(System.String nm, UnityEngine.Vector3 pos, System.Boolean ModelIs)
	{JustEntered = false;
 frame = World.frame;
		maxSteeringAngle = 50f;
		maxMotorTorque = 250f;
		isModel = ModelIs;
		cnvAccel = 0f;
		TruckScript = TruckScript.Instantiate(nm,pos);
		Stats = new TruckStats(ModelIs);
		Keyboard = false;
		JRotation = 0f;
		Fuel = 80000f;
		AxleInfos = (

Enumerable.Empty<AxleInfo>()).ToList<AxleInfo>();
		Active = false;
		
}
		public System.Single Acceleration{  get { return TruckScript.Acceleration; }
 }
	public System.Boolean Active;
	public List<AxleInfo> AxleInfos;
	public System.Single BrakeAndReverse{  get { return TruckScript.BrakeAndReverse; }
 }
	public UnityEngine.Vector3 COM{  get { return TruckScript.COM; }
  set{TruckScript.COM = value; }
 }
	public System.Single CarHP2{  get { return TruckScript.CarHP2; }
  set{TruckScript.CarHP2 = value; }
 }
	public UnityEngine.Vector3 CenterOfMass{  get { return TruckScript.CenterOfMass; }
  set{TruckScript.CenterOfMass = value; }
 }
	public System.Boolean CollisionWithModel{  get { return TruckScript.CollisionWithModel; }
  set{TruckScript.CollisionWithModel = value; }
 }
	public System.Boolean Destroyed{  get { return TruckScript.Destroyed; }
  set{TruckScript.Destroyed = value; }
 }
	public System.Single Frce{  set{TruckScript.Frce = value; }
 }
	public UnityEngine.WheelCollider FrontLeftWheel{  get { return TruckScript.FrontLeftWheel; }
  set{TruckScript.FrontLeftWheel = value; }
 }
	public UnityEngine.WheelCollider FrontRightWheel{  get { return TruckScript.FrontRightWheel; }
  set{TruckScript.FrontRightWheel = value; }
 }
	public System.Single Fuel;
	public UnityEngine.Light HeadlightLeft{  get { return TruckScript.HeadlightLeft; }
  set{TruckScript.HeadlightLeft = value; }
 }
	public System.Boolean HeadlightLeftOn{  get { return TruckScript.HeadlightLeftOn; }
  set{TruckScript.HeadlightLeftOn = value; }
 }
	public UnityEngine.Light HeadlightRight{  get { return TruckScript.HeadlightRight; }
  set{TruckScript.HeadlightRight = value; }
 }
	public System.Boolean HeadlightRightOn{  get { return TruckScript.HeadlightRightOn; }
  set{TruckScript.HeadlightRightOn = value; }
 }
	public System.Single JRotation;
	public System.Boolean Keyboard;
	public UnityEngine.Vector3 Position{  get { return TruckScript.Position; }
 }
	public UnityEngine.WheelCollider RearLeftWheel{  get { return TruckScript.RearLeftWheel; }
  set{TruckScript.RearLeftWheel = value; }
 }
	public UnityEngine.WheelCollider RearRightWheel{  get { return TruckScript.RearRightWheel; }
  set{TruckScript.RearRightWheel = value; }
 }
	public System.Single RotationY{  get { return TruckScript.RotationY; }
 }
	public TruckStats Stats;
	public System.Single Steering{  get { return TruckScript.Steering; }
 }
	public UnityEngine.Vector3 Trque{  set{TruckScript.Trque = value; }
 }
	public TruckScript TruckScript;
	public System.Single cnvAccel;
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
	public System.Boolean isModel;
	public System.Single maxMotorTorque;
	public System.Single maxSteeringAngle;
	public System.String name{  get { return TruckScript.name; }
  set{TruckScript.name = value; }
 }
	public UnityEngine.Collider shield{  get { return TruckScript.shield; }
  set{TruckScript.shield = value; }
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
	public System.Single count_down7;
	public System.Single count_down6;
	public System.Single count_down5;
	public System.Single count_down4;
	public System.Single count_down3;
	public void Update(float dt, World world) {
frame = World.frame;

		for(int x0 = 0; x0 < AxleInfos.Count; x0++) { 
			AxleInfos[x0].Update(dt, world);
		}
		Stats.Update(dt, world);
		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
		this.Rule3(dt, world);
		this.Rule4(dt, world);
		this.Rule5(dt, world);
		this.Rule6(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	AxleInfos = (

(new Cons<AxleInfo>(new AxleInfo(FrontLeftWheel,FrontRightWheel,true,true),(new Cons<AxleInfo>(new AxleInfo(RearLeftWheel,RearRightWheel,true,false),(new Empty<AxleInfo>()).ToList<AxleInfo>())).ToList<AxleInfo>())).ToList<AxleInfo>()).ToList<AxleInfo>();
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	Active = true;
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
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(!(isModel))
	{

	goto case 3;	}else
	{

	s2 = -1;
return;	}
	case 3:
	if(((world.ActiveBoR) == ("Jerry Can Green")))
	{

	goto case 5;	}else
	{

	s2 = -1;
return;	}
	case 5:
	UnityEngine.Debug.Log(("Fuel = ") + (Fuel));
	Fuel = ((Fuel) + (2000f));
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	if(Keyboard)
	{

	goto case 8;	}else
	{

	goto case 9;	}
	case 8:
	JRotation = UnityEngine.Input.GetAxis("Horizontal");
	s3 = -1;
return;
	case 9:
	JRotation = Steering;
	s3 = -1;
return;	
	default: return;}}
	

	int s4=-1;
	public void Rule4(float dt, World world){ 
	switch (s4)
	{

	case -1:
	if(Keyboard)
	{

	goto case 13;	}else
	{

	goto case 14;	}
	case 13:
	cnvAccel = UnityEngine.Input.GetAxis("Vertical");
	s4 = -1;
return;
	case 14:
	if(!(((Acceleration) == (0f))))
	{

	goto case 17;	}else
	{

	goto case 18;	}
	case 17:
	cnvAccel = Acceleration;
	s4 = -1;
return;
	case 18:
	cnvAccel = ((BrakeAndReverse) * (-1f));
	s4 = -1;
return;	
	default: return;}}
	

	int s5=-1;
	public void Rule5(float dt, World world){ 
	switch (s5)
	{

	case -1:
	if(!(UnityEngine.Input.GetKeyDown(KeyCode.P)))
	{

	s5 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Keyboard = !(Keyboard);
	s5 = -1;
return;	
	default: return;}}
	

	int s6=-1;
	public void Rule6(float dt, World world){ 
	switch (s6)
	{

	case -1:
	if(((world.ActiveBoR) == ("Lightning Blue")))
	{

	goto case 3;	}else
	{

	s6 = -1;
return;	}
	case 3:
	HeadlightLeftOn = true;
	HeadlightRightOn = true;
	s6 = 17;
return;
	case 17:
	count_down7 = 5f;
	goto case 18;
	case 18:
	if(((count_down7) > (0f)))
	{

	count_down7 = ((count_down7) - (dt));
	s6 = 18;
return;	}else
	{

	goto case 16;	}
	case 16:
	HeadlightLeftOn = false;
	HeadlightRightOn = false;
	s6 = 14;
return;
	case 14:
	count_down6 = 0.2f;
	goto case 15;
	case 15:
	if(((count_down6) > (0f)))
	{

	count_down6 = ((count_down6) - (dt));
	s6 = 15;
return;	}else
	{

	goto case 13;	}
	case 13:
	HeadlightLeftOn = true;
	HeadlightRightOn = true;
	s6 = 11;
return;
	case 11:
	count_down5 = 0.1f;
	goto case 12;
	case 12:
	if(((count_down5) > (0f)))
	{

	count_down5 = ((count_down5) - (dt));
	s6 = 12;
return;	}else
	{

	goto case 10;	}
	case 10:
	HeadlightLeftOn = false;
	HeadlightRightOn = false;
	s6 = 8;
return;
	case 8:
	count_down4 = 0.3f;
	goto case 9;
	case 9:
	if(((count_down4) > (0f)))
	{

	count_down4 = ((count_down4) - (dt));
	s6 = 9;
return;	}else
	{

	goto case 7;	}
	case 7:
	HeadlightLeftOn = true;
	HeadlightRightOn = true;
	s6 = 5;
return;
	case 5:
	count_down3 = 0.1f;
	goto case 6;
	case 6:
	if(((count_down3) > (0f)))
	{

	count_down3 = ((count_down3) - (dt));
	s6 = 6;
return;	}else
	{

	goto case 4;	}
	case 4:
	HeadlightLeftOn = false;
	HeadlightRightOn = false;
	s6 = -1;
return;	
	default: return;}}
	





}
public class AxleInfo{
public int frame;
public bool JustEntered = true;
private UnityEngine.WheelCollider lW;
private UnityEngine.WheelCollider rW;
private System.Boolean m;
private System.Boolean s;
	public int ID;
public AxleInfo(UnityEngine.WheelCollider lW, UnityEngine.WheelCollider rW, System.Boolean m, System.Boolean s)
	{JustEntered = false;
 frame = World.frame;
		steering = s;
		rightWheel = rW;
		motor = m;
		leftWheel = lW;
		
}
		public UnityEngine.WheelCollider leftWheel;
	public System.Boolean motor;
	public UnityEngine.WheelCollider rightWheel;
	public System.Boolean steering;
	public System.Single ___dir00;
	public System.Single ___speed00;
	public System.Single count_down8;
	public System.Single ___steeringAngle10;
	public void Update(float dt, World world) {
frame = World.frame;

		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(!(world.Jeep.Value.isModel))
	{

	goto case 21;	}else
	{

	s0 = -1;
return;	}
	case 21:
	if(((world.Jeep.Value.Fuel) > (0.99f)))
	{

	goto case 22;	}else
	{

	goto case 23;	}
	case 22:
	if(((!(((world.Jeep.Value.cnvAccel) == (0f)))) && (((leftWheel.isGrounded) || (rightWheel.isGrounded)))))
	{

	goto case 25;	}else
	{

	goto case 26;	}
	case 25:
	___dir00 = world.Jeep.Value.cnvAccel;
	___speed00 = ((((world.Jeep.Value.maxMotorTorque) * (world.Jeep.Value.cnvAccel))) * (-1f));
	if(((world.ActiveBoR) == ("Arrows Green")))
	{

	goto case 28;	}else
	{

	goto case 29;	}
	case 28:
	leftWheel.motorTorque = leftWheel.motorTorque;
	rightWheel.motorTorque = rightWheel.motorTorque;
	world.Jeep.Value.Fuel = world.Jeep.Value.Fuel;
	s0 = 32;
return;
	case 32:
	if(!(((!(((world.Jeep.Value.cnvAccel) == (___dir00)))) || (true))))
	{

	s0 = 32;
return;	}else
	{

	goto case 31;	}
	case 31:
	if(!(((world.Jeep.Value.cnvAccel) == (___dir00))))
	{

	goto case 33;	}else
	{

	if(true)
	{

	goto case 34;	}else
	{

	s0 = 31;
return;	}	}
	case 33:
	leftWheel.motorTorque = ___speed00;
	rightWheel.motorTorque = ___speed00;
	world.Jeep.Value.Fuel = ((world.Jeep.Value.Fuel) - (1f));
	s0 = -1;
return;
	case 34:
	leftWheel.motorTorque = ((___speed00) * (10f));
	rightWheel.motorTorque = ((___speed00) * (10f));
	world.Jeep.Value.Fuel = world.Jeep.Value.Fuel;
	s0 = 36;
return;
	case 36:
	count_down8 = 2f;
	goto case 37;
	case 37:
	if(((count_down8) > (0f)))
	{

	count_down8 = ((count_down8) - (dt));
	s0 = 37;
return;	}else
	{

	s0 = -1;
return;	}
	case 29:
	leftWheel.motorTorque = ___speed00;
	rightWheel.motorTorque = ___speed00;
	world.Jeep.Value.Fuel = ((world.Jeep.Value.Fuel) - (1f));
	s0 = -1;
return;
	case 26:
	leftWheel.motorTorque = 0f;
	rightWheel.motorTorque = 0f;
	world.Jeep.Value.Fuel = world.Jeep.Value.Fuel;
	s0 = -1;
return;
	case 23:
	leftWheel.motorTorque = 0f;
	rightWheel.motorTorque = 0f;
	world.Jeep.Value.Fuel = 0f;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(!(steering))
	{

	s1 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	if(!(world.Jeep.Value.isModel))
	{

	goto case 1;	}else
	{

	s1 = -1;
return;	}
	case 1:
	___steeringAngle10 = ((world.Jeep.Value.maxSteeringAngle) * (world.Jeep.Value.JRotation));
	if(((world.Jeep.Value.cnvAccel) > (0f)))
	{

	goto case 10;	}else
	{

	goto case 2;	}
	case 10:
	if(((((((___steeringAngle10) > (0.001f))) && (((((world.Jeep.Value.RotationY) > (30f))) && (((120f) > (world.Jeep.Value.RotationY))))))) || (((((-0.001f) > (___steeringAngle10))) && (((((world.Jeep.Value.RotationY) > (200f))) && (((330f) > (world.Jeep.Value.RotationY)))))))))
	{

	goto case 11;	}else
	{

	goto case 12;	}
	case 11:
	leftWheel.steerAngle = 0f;
	rightWheel.steerAngle = 0f;
	s1 = 2;
return;
	case 12:
	leftWheel.steerAngle = ___steeringAngle10;
	rightWheel.steerAngle = ___steeringAngle10;
	s1 = 2;
return;
	case 2:
	if(((0f) > (world.Jeep.Value.cnvAccel)))
	{

	goto case 3;	}else
	{

	s1 = -1;
return;	}
	case 3:
	if(((((((___steeringAngle10) > (0.001f))) && (((((world.Jeep.Value.RotationY) > (200f))) && (((330f) > (world.Jeep.Value.RotationY))))))) || (((((-0.001f) > (___steeringAngle10))) && (((((world.Jeep.Value.RotationY) > (30f))) && (((120f) > (world.Jeep.Value.RotationY)))))))))
	{

	goto case 4;	}else
	{

	goto case 5;	}
	case 4:
	leftWheel.steerAngle = 0f;
	rightWheel.steerAngle = 0f;
	s1 = -1;
return;
	case 5:
	leftWheel.steerAngle = ___steeringAngle10;
	rightWheel.steerAngle = ___steeringAngle10;
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	steering = steering;
	s2 = -1;
return;	
	default: return;}}
	





}
public class Zombie{
public int frame;
public bool JustEntered = true;
private UnityEngine.Transform trans;
	public int ID;
public Zombie(UnityEngine.Transform trans)
	{JustEntered = false;
 frame = World.frame;
		UnityZombie2 = UnityZombie2.Find(trans);
		Life = 100f;
		
}
		public System.Single BodyPartMultiplier{  get { return UnityZombie2.BodyPartMultiplier; }
  set{UnityZombie2.BodyPartMultiplier = value; }
 }
	public System.Single CollisionDamage{  get { return UnityZombie2.CollisionDamage; }
  set{UnityZombie2.CollisionDamage = value; }
 }
	public System.Boolean Dead{  get { return UnityZombie2.Dead; }
  set{UnityZombie2.Dead = value; }
 }
	public System.Boolean Destroyed{  get { return UnityZombie2.Destroyed; }
  set{UnityZombie2.Destroyed = value; }
 }
	public System.Boolean IsHitByBullet{  get { return UnityZombie2.IsHitByBullet; }
  set{UnityZombie2.IsHitByBullet = value; }
 }
	public System.Single Life;
	public System.Boolean OnMouseOver{  get { return UnityZombie2.OnMouseOver; }
 }
	public UnityEngine.Vector3 Position{  get { return UnityZombie2.Position; }
 }
	public UnityZombie2 UnityZombie2;
	public System.Boolean enabled{  get { return UnityZombie2.enabled; }
  set{UnityZombie2.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityZombie2.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityZombie2.hideFlags; }
  set{UnityZombie2.hideFlags = value; }
 }
	public System.Collections.Generic.List<System.Single> impactEndTimes{  get { return UnityZombie2.impactEndTimes; }
  set{UnityZombie2.impactEndTimes = value; }
 }
	public System.Collections.Generic.List<UnityEngine.Rigidbody> impactTargets{  get { return UnityZombie2.impactTargets; }
  set{UnityZombie2.impactTargets = value; }
 }
	public System.Collections.Generic.List<UnityEngine.Vector3> impacts{  get { return UnityZombie2.impacts; }
  set{UnityZombie2.impacts = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityZombie2.isActiveAndEnabled; }
 }
	public System.Boolean isHitByBullet{  get { return UnityZombie2.isHitByBullet; }
  set{UnityZombie2.isHitByBullet = value; }
 }
	public System.String name{  get { return UnityZombie2.name; }
  set{UnityZombie2.name = value; }
 }
	public System.String tag{  get { return UnityZombie2.tag; }
  set{UnityZombie2.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityZombie2.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityZombie2.useGUILayout; }
  set{UnityZombie2.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;

		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
		this.Rule3(dt, world);
		this.Rule4(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(!(((Life) > (0f))))
	{

	goto case 2;	}else
	{

	s0 = -1;
return;	}
	case 2:
	Dead = true;
	s0 = 3;
return;
	case 3:
	if(!(false))
	{

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
	if(!(IsHitByBullet))
	{

	s1 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Life = ((Life) - (((world.Pistols.Head().DamagePerBullet) * (BodyPartMultiplier))));
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(!(world.Jeep.IsSome))
	{

	s2 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	if(world.Jeep.Value.Active)
	{

	goto case 1;	}else
	{

	s2 = -1;
return;	}
	case 1:
	if(OnMouseOver)
	{

	goto case 3;	}else
	{

	s2 = -1;
return;	}
	case 3:
	if(world.Pistols.Head().Shoot)
	{

	goto case 5;	}else
	{

	s2 = -1;
return;	}
	case 5:
	IsHitByBullet = true;
	s2 = 6;
return;
	case 6:
	IsHitByBullet = false;
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	CollisionDamage = CollisionDamage;
	s3 = -1;
return;	
	default: return;}}
	

	int s4=-1;
	public void Rule4(float dt, World world){ 
	switch (s4)
	{

	case -1:
	if(!(((CollisionDamage) == (0f))))
	{

	goto case 2;	}else
	{

	s4 = -1;
return;	}
	case 2:
	UnityEngine.Debug.Log(("Collided zombie HP before:") + (Life));
	Life = ((Life) - (((CollisionDamage) * (6f))));
	CollisionDamage = 0f;
	s4 = 3;
return;
	case 3:
	UnityEngine.Debug.Log(("Collided zombie HP after:") + (Life));
	s4 = -1;
return;	
	default: return;}}
	





}
}                   