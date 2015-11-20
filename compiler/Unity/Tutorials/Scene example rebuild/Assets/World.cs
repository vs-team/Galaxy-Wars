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
	public List<ControllerRazor> Controllers;
	public System.Int32 Counter;
	public System.Boolean Destroyed{  get { return UnityLandscape.Destroyed; }
  set{UnityLandscape.Destroyed = value; }
 }
	public List<Light> Flashs;
	public GUI GUIpanel;
	public List<Gasstation> __Gasstations;
	public List<Gasstation> Gasstations{  get { return  __Gasstations; }
  set{ __Gasstations = value;
 foreach(var e in value){if(e.JustEntered){ e.JustEntered = false;
}
} }
 }
	public Option<Truck> Jeep;
	public List<Landscape> __Landscapes;
	public List<Landscape> Landscapes{  get { return  __Landscapes; }
  set{ __Landscapes = value;
 foreach(var e in value){if(e.JustEntered){ e.JustEntered = false;
}
} }
 }
	public List<Gun> Pistols;
	public UnityEngine.Vector3 Position{  get { return UnityLandscape.Position; }
 }
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

(new Cons<Gun>(new Gun("Pistol",1,Controllers[0]),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
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
		Updating = false;
		UnityGasstation = UnityGasstation.Instantiate(ps);
		ParkingSpotPositions = (

Enumerable.Empty<UnityEngine.Vector3>()).ToList<UnityEngine.Vector3>();
		ParkedJeep = (new Nothing<Truck>());
		PJpos = Vector3.zero;
		
}
		public System.Collections.Generic.List<System.String> Jeeps{  get { return UnityGasstation.Jeeps; }
 }
	public UnityEngine.Vector3 PJpos;
	public Option<Truck> ParkedJeep;
	public System.Collections.Generic.List<UnityEngine.Transform> ParkingSpotList{  get { return UnityGasstation.ParkingSpotList; }
 }
	public List<UnityEngine.Vector3> ParkingSpotPositions;
	public UnityEngine.Vector3 Position{  get { return UnityGasstation.Position; }
 }
	public UnityGasstation UnityGasstation;
	public System.Boolean Updating;
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
	public List<UnityEngine.Vector3> ___z01;
	public List<System.String> ___z12;
	public UnityEngine.Vector3 ___PSPH10;
	public UnityEngine.Vector3 ___PSPH210;
	public Truck ___p10;
	public System.Single count_down1;
	public UnityEngine.Vector3 ___pos40;
	public Truck ___z43;
	public void Update(float dt, World world) {
frame = World.frame;

if(ParkedJeep.IsSome){ 		ParkedJeep.Value.Update(dt, world);
 } 
		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
		this.Rule3(dt, world);
		this.Rule4(dt, world);
		this.Rule5(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	___z01 = (

(ParkingSpotList).Select(__ContextSymbol39 => new { ___a07 = __ContextSymbol39 })
.Select(__ContextSymbol40 => __ContextSymbol40.___a07.position)
.ToList<UnityEngine.Vector3>()).ToList<UnityEngine.Vector3>();
	ParkingSpotPositions = ___z01;
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
	if(!(((ParkingSpotPositions.Count) > (0))))
	{

	s1 = -1;
return;	}else
	{

	goto case 5;	}
	case 5:
	___z12 = (

(Jeeps).Select(__ContextSymbol41 => new { ___a18 = __ContextSymbol41 })
.Select(__ContextSymbol42 => __ContextSymbol42.___a18)
.ToList<System.String>()).ToList<System.String>();
	___PSPH10 = ParkingSpotPositions.Head();
	___PSPH210 = new UnityEngine.Vector3(___PSPH10.x,___PSPH10.y,(___PSPH10.z) + (32.5f));
	___p10 = new Truck((___z12.Head()) + ("model"),___PSPH210,true);
	ParkedJeep = (new Just<Truck>(___p10));
	ParkingSpotPositions = ParkingSpotPositions;
	PJpos = ___PSPH210;
	s1 = 0;
return;
	case 0:
	ParkedJeep = ParkedJeep;
	ParkingSpotPositions = (

Enumerable.Empty<UnityEngine.Vector3>()).ToList<UnityEngine.Vector3>();
	PJpos = ___PSPH210;
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(world.Jeep.IsSome)
	{

	goto case 8;	}else
	{

	s2 = -1;
return;	}
	case 8:
	count_down1 = 3f;
	goto case 12;
	case 12:
	if(((count_down1) > (0f)))
	{

	count_down1 = ((count_down1) - (dt));
	s2 = 12;
return;	}else
	{

	goto case 10;	}
	case 10:
	if(!(world.Jeep.Value.CollisionWithModel))
	{

	s2 = 10;
return;	}else
	{

	goto case 9;	}
	case 9:
	world.Jeep.Value.Destroyed = true;
	world.Jeep = (new Nothing<Truck>());
	Updating = true;
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	if(world.Jeep.IsNone)
	{

	goto case 14;	}else
	{

	s3 = -1;
return;	}
	case 14:
	ParkedJeep.Value.Destroyed = true;
	ParkedJeep = (new Nothing<Truck>());
	s3 = -1;
return;	
	default: return;}}
	

	int s4=-1;
	public void Rule4(float dt, World world){ 
	switch (s4)
	{

	case -1:
	if(ParkedJeep.IsNone)
	{

	goto case 17;	}else
	{

	s4 = -1;
return;	}
	case 17:
	___pos40 = new UnityEngine.Vector3((PJpos.x) - (5f),PJpos.y,PJpos.z);
	___z43 = new Truck("truck1",___pos40,false);
	world.Jeep = (new Just<Truck>(___z43));
	Updating = true;
	s4 = 19;
return;
	case 19:
	world.Jeep = world.Jeep;
	Updating = false;
	s4 = 18;
return;
	case 18:
	if(!(false))
	{

	s4 = 18;
return;	}else
	{

	s4 = -1;
return;	}	
	default: return;}}
	

	int s5=-1;
	public void Rule5(float dt, World world){ 
	switch (s5)
	{

	case -1:
	if(!(Updating))
	{

	s5 = -1;
return;	}else
	{

	goto case 2;	}
	case 2:
	if(!(!(Updating)))
	{

	s5 = 2;
return;	}else
	{

	goto case 1;	}
	case 1:
	world.Jeep.Value.Active = false;
	s5 = 0;
return;
	case 0:
	world.Jeep.Value.Active = true;
	s5 = -1;
return;	
	default: return;}}
	





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
	public List<Zombie> ___z04;
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
	___z04 = (

(U_Zombies).Select(__ContextSymbol46 => new { ___a09 = __ContextSymbol46 })
.Select(__ContextSymbol47 => new Zombie(__ContextSymbol47.___a09))
.ToList<Zombie>()).ToList<Zombie>();
	ZombieFollowers = ___z04;
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
	public System.Single count_down2;
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
	if(((((world.Pistols.Head().InMagazine) > (0))) && (!(world.Pistols.Head().Reloading))))
	{

	goto case 2;	}else
	{

	s2 = -1;
return;	}
	case 2:
	if(((!(world.Pistols.Head().Automatic)) && (((Trigger) || (UnityEngine.Input.GetMouseButtonDown(0))))))
	{

	goto case 12;	}else
	{

	goto case 3;	}
	case 12:
	Shot = true;
	s2 = 13;
return;
	case 13:
	Shot = false;
	s2 = 3;
return;
	case 3:
	if(((world.Pistols.Head().Automatic) && (((Trigger) || (UnityEngine.Input.GetMouseButton(0))))))
	{

	goto case 4;	}else
	{

	s2 = -1;
return;	}
	case 4:
	if(!(UnityEngine.Input.GetMouseButton(0)))
	{

	s2 = -1;
return;	}else
	{

	goto case 6;	}
	case 6:
	Shot = true;
	s2 = 9;
return;
	case 9:
	Shot = false;
	s2 = 7;
return;
	case 7:
	count_down2 = 0.05f;
	goto case 8;
	case 8:
	if(((count_down2) > (0f)))
	{

	count_down2 = ((count_down2) - (dt));
	s2 = 8;
return;	}else
	{

	s2 = 4;
return;	}	
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

(new Cons<System.Single>(40f,(new Cons<System.Single>(75f,(new Cons<System.Single>(135f,(new Cons<System.Single>(100f,(new Cons<System.Single>(400f,(new Empty<System.Single>()).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>()).ToList<System.Single>();
		UnityGun = UnityGun.Instantiate(st);
		TypeWeapon = st;
		Reloading = false;
		ReloadDuration = ___ReloadDurationList00[ind];
		NotInMagazine = ___NotInMagList00[ind];
		MagazineSize = ___ClipSizeList00[ind];
		InMagazine = ___InMagList00[ind];
		GunController = GC;
		DamagePerBullet = ___DamageList00[ind];
		Automatic = ___autom00;
		
}
		public System.Boolean Automatic;
	public System.Single DamagePerBullet;
	public ControllerRazor GunController;
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
	public UnityEngine.Vector3 Position{  get { return UnityGun.Position; }
 }
	public System.Single ReloadDuration;
	public System.Boolean Reloading;
	public UnityEngine.Vector3 Rotation{  get { return UnityGun.Rotation; }
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
	public System.Single count_down3;
	public System.Int32 ___changed30;
	public void Update(float dt, World world) {
frame = World.frame;

		GunController.Update(dt, world);
		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
		this.Rule3(dt, world);
		this.Rule4(dt, world);
		this.Rule5(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(UnityEngine.Input.GetKey(KeyCode.C))
	{

	goto case 16;	}else
	{

	s0 = -1;
return;	}
	case 16:
	Reloading = false;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(((world.Pistols.Count) > (0)))
	{

	goto case 19;	}else
	{

	s1 = -1;
return;	}
	case 19:
	InMag = InMagazine;
	NotInMag = NotInMagazine;
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

	goto case 22;	}else
	{

	s2 = -1;
return;	}
	case 22:
	MagazineGUI = MagazineGUI;
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	if(((((UnityEngine.Input.GetKey(KeyCode.R)) || (((InMagazine) == (0))))) && (((NotInMagazine) > (0)))))
	{

	goto case 25;	}else
	{

	s3 = -1;
return;	}
	case 25:
	Reloading = true;
	NotInMagazine = NotInMagazine;
	InMagazine = InMagazine;
	s3 = 32;
return;
	case 32:
	count_down3 = ReloadDuration;
	goto case 33;
	case 33:
	if(((count_down3) > (0f)))
	{

	count_down3 = ((count_down3) - (dt));
	s3 = 33;
return;	}else
	{

	goto case 28;	}
	case 28:
	if(((MagazineSize) > (NotInMagazine)))
	{

	goto case 26;	}else
	{

	goto case 27;	}
	case 26:
	Reloading = false;
	NotInMagazine = 0;
	InMagazine = NotInMagazine;
	s3 = -1;
return;
	case 27:
	___changed30 = ((MagazineSize) - (InMagazine));
	Reloading = false;
	NotInMagazine = ((NotInMagazine) - (___changed30));
	InMagazine = MagazineSize;
	s3 = -1;
return;	
	default: return;}}
	

	int s4=-1;
	public void Rule4(float dt, World world){ 
	switch (s4)
	{

	case -1:
	if(((world.ActiveBoR) == ("AmmoBox")))
	{

	goto case 36;	}else
	{

	s4 = -1;
return;	}
	case 36:
	NotInMagazine = ((NotInMagazine) + (50));
	s4 = -1;
return;	
	default: return;}}
	

	int s5=-1;
	public void Rule5(float dt, World world){ 
	switch (s5)
	{

	case -1:
	if(((((GunController.Shot) && (((InMagazine) > (0))))) && (((Reloading) == (false)))))
	{

	goto case 39;	}else
	{

	s5 = -1;
return;	}
	case 39:
	InMagazine = ((InMagazine) - (1));
	s5 = -1;
return;	
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

	goto case 41;	}else
	{

	goto case 42;	}
	case 41:
	Battery = ((Battery) - (0.5f));
	s0 = -1;
return;
	case 42:
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

	goto case 47;	}else
	{

	s1 = -1;
return;	}
	case 47:
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

(Spawnpoints2).Select(__ContextSymbol60 => new { ___a010 = __ContextSymbol60 })
.Select(__ContextSymbol61 => __ContextSymbol61.___a010)
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

(Enumerable.Range(0,(1) + ((3) - (0))).ToList<System.Int32>()).Select(__ContextSymbol72 => new { ___a111 = __ContextSymbol72 })
.Select(__ContextSymbol73 => new BonusAndResource(___plist10[__ContextSymbol73.___a111],___Slist10[__ContextSymbol73.___a111]))
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

(BonusAndResources).Select(__ContextSymbol74 => new { ___a212 = __ContextSymbol74 })
.Where(__ContextSymbol75 => ((__ContextSymbol75.___a212.Destroyed) == (false)))
.Select(__ContextSymbol76 => __ContextSymbol76.___a212)
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
	public System.Single ___z05;
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
	___z05 = world.Jeep.Value.CarHP2;
	if(!(((___z05) == (((Health) / (100f))))))
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
	public List<AxleInfo> ___p01;
	public List<Gasstation> ___z06;
	public List<Gasstation> ___z77;
	public System.Single count_down8;
	public System.Single count_down7;
	public System.Single count_down6;
	public System.Single count_down5;
	public System.Single count_down4;
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
		this.Rule7(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	___p01 = (

(AxleInfos).Select(__ContextSymbol84 => new { ___a013 = __ContextSymbol84 })
.Select(__ContextSymbol85 => __ContextSymbol85.___a013)
.ToList<AxleInfo>()).ToList<AxleInfo>();
	___z06 = (

(world.Gasstations).Select(__ContextSymbol86 => new { ___a014 = __ContextSymbol86 })
.Where(__ContextSymbol87 => __ContextSymbol87.___a014.Updating)
.Select(__ContextSymbol88 => __ContextSymbol88.___a014)
.ToList<Gasstation>()).ToList<Gasstation>();
	if(((___z06.Count) > (0)))
	{

	goto case 18;	}else
	{

	s0 = -1;
return;	}
	case 18:
	AxleInfos = (

Enumerable.Empty<AxleInfo>()).ToList<AxleInfo>();
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(isModel)
	{

	goto case 22;	}else
	{

	goto case 23;	}
	case 22:
	AxleInfos = (

Enumerable.Empty<AxleInfo>()).ToList<AxleInfo>();
	s1 = 25;
return;
	case 25:
	if(!(false))
	{

	s1 = 25;
return;	}else
	{

	s1 = -1;
return;	}
	case 23:
	AxleInfos = (

(new Cons<AxleInfo>(new AxleInfo(FrontLeftWheel,FrontRightWheel,true,true),(new Cons<AxleInfo>(new AxleInfo(RearLeftWheel,RearRightWheel,true,false),(new Empty<AxleInfo>()).ToList<AxleInfo>())).ToList<AxleInfo>())).ToList<AxleInfo>()).ToList<AxleInfo>();
	s1 = 27;
return;
	case 27:
	if(!(false))
	{

	s1 = 27;
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
	Active = true;
	s2 = 0;
return;
	case 0:
	if(!(false))
	{

	s2 = 0;
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
	if(!(isModel))
	{

	goto case 3;	}else
	{

	s3 = -1;
return;	}
	case 3:
	if(((world.ActiveBoR) == ("Jerry Can Green")))
	{

	goto case 5;	}else
	{

	s3 = -1;
return;	}
	case 5:
	UnityEngine.Debug.Log(("Fuel = ") + (Fuel));
	Fuel = ((Fuel) + (2000f));
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

	goto case 8;	}else
	{

	goto case 9;	}
	case 8:
	JRotation = UnityEngine.Input.GetAxis("Horizontal");
	s4 = -1;
return;
	case 9:
	JRotation = Steering;
	s4 = -1;
return;	
	default: return;}}
	

	int s5=-1;
	public void Rule5(float dt, World world){ 
	switch (s5)
	{

	case -1:
	if(Keyboard)
	{

	goto case 13;	}else
	{

	goto case 14;	}
	case 13:
	cnvAccel = UnityEngine.Input.GetAxis("Vertical");
	s5 = -1;
return;
	case 14:
	if(!(((Acceleration) == (0f))))
	{

	goto case 17;	}else
	{

	goto case 18;	}
	case 17:
	cnvAccel = Acceleration;
	s5 = -1;
return;
	case 18:
	cnvAccel = ((BrakeAndReverse) * (-1f));
	s5 = -1;
return;	
	default: return;}}
	

	int s6=-1;
	public void Rule6(float dt, World world){ 
	switch (s6)
	{

	case -1:
	if(!(UnityEngine.Input.GetKeyDown(KeyCode.P)))
	{

	s6 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Keyboard = !(Keyboard);
	s6 = -1;
return;	
	default: return;}}
	

	int s7=-1;
	public void Rule7(float dt, World world){ 
	switch (s7)
	{

	case -1:
	___z77 = (

(world.Gasstations).Select(__ContextSymbol92 => new { ___a715 = __ContextSymbol92 })
.Where(__ContextSymbol93 => __ContextSymbol93.___a715.Updating)
.Select(__ContextSymbol94 => __ContextSymbol94.___a715)
.ToList<Gasstation>()).ToList<Gasstation>();
	if(((___z77.Count) == (0)))
	{

	goto case 3;	}else
	{

	s7 = -1;
return;	}
	case 3:
	if(((world.ActiveBoR) == ("Lightning Blue")))
	{

	goto case 5;	}else
	{

	s7 = -1;
return;	}
	case 5:
	HeadlightLeftOn = true;
	HeadlightRightOn = true;
	s7 = 19;
return;
	case 19:
	count_down8 = 5f;
	goto case 20;
	case 20:
	if(((count_down8) > (0f)))
	{

	count_down8 = ((count_down8) - (dt));
	s7 = 20;
return;	}else
	{

	goto case 18;	}
	case 18:
	HeadlightLeftOn = false;
	HeadlightRightOn = false;
	s7 = 16;
return;
	case 16:
	count_down7 = 0.2f;
	goto case 17;
	case 17:
	if(((count_down7) > (0f)))
	{

	count_down7 = ((count_down7) - (dt));
	s7 = 17;
return;	}else
	{

	goto case 15;	}
	case 15:
	HeadlightLeftOn = true;
	HeadlightRightOn = true;
	s7 = 13;
return;
	case 13:
	count_down6 = 0.1f;
	goto case 14;
	case 14:
	if(((count_down6) > (0f)))
	{

	count_down6 = ((count_down6) - (dt));
	s7 = 14;
return;	}else
	{

	goto case 12;	}
	case 12:
	HeadlightLeftOn = false;
	HeadlightRightOn = false;
	s7 = 10;
return;
	case 10:
	count_down5 = 0.3f;
	goto case 11;
	case 11:
	if(((count_down5) > (0f)))
	{

	count_down5 = ((count_down5) - (dt));
	s7 = 11;
return;	}else
	{

	goto case 9;	}
	case 9:
	HeadlightLeftOn = true;
	HeadlightRightOn = true;
	s7 = 7;
return;
	case 7:
	count_down4 = 0.1f;
	goto case 8;
	case 8:
	if(((count_down4) > (0f)))
	{

	count_down4 = ((count_down4) - (dt));
	s7 = 8;
return;	}else
	{

	goto case 6;	}
	case 6:
	HeadlightLeftOn = false;
	HeadlightRightOn = false;
	s7 = -1;
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
	public List<Gasstation> ___z08;
	public System.Single ___dir00;
	public System.Single ___speed00;
	public System.Single count_down9;
	public List<Gasstation> ___z19;
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
	___z08 = (

(world.Gasstations).Select(__ContextSymbol95 => new { ___a016 = __ContextSymbol95 })
.Where(__ContextSymbol96 => __ContextSymbol96.___a016.Updating)
.Select(__ContextSymbol97 => __ContextSymbol97.___a016)
.ToList<Gasstation>()).ToList<Gasstation>();
	if(((((___z08.Count) == (0))) && (!(world.Jeep.Value.isModel))))
	{

	goto case 24;	}else
	{

	s0 = -1;
return;	}
	case 24:
	if(((world.Jeep.Value.Fuel) > (0.99f)))
	{

	goto case 25;	}else
	{

	goto case 26;	}
	case 25:
	if(((!(((world.Jeep.Value.cnvAccel) == (0f)))) && (((leftWheel.isGrounded) || (rightWheel.isGrounded)))))
	{

	goto case 28;	}else
	{

	goto case 29;	}
	case 28:
	___dir00 = world.Jeep.Value.cnvAccel;
	___speed00 = ((((world.Jeep.Value.maxMotorTorque) * (world.Jeep.Value.cnvAccel))) * (-1f));
	if(((world.ActiveBoR) == ("Arrows Green")))
	{

	goto case 31;	}else
	{

	goto case 32;	}
	case 31:
	leftWheel.motorTorque = leftWheel.motorTorque;
	rightWheel.motorTorque = rightWheel.motorTorque;
	world.Jeep.Value.Fuel = world.Jeep.Value.Fuel;
	s0 = 35;
return;
	case 35:
	if(!(((!(((world.Jeep.Value.cnvAccel) == (___dir00)))) || (true))))
	{

	s0 = 35;
return;	}else
	{

	goto case 34;	}
	case 34:
	if(!(((world.Jeep.Value.cnvAccel) == (___dir00))))
	{

	goto case 36;	}else
	{

	if(true)
	{

	goto case 37;	}else
	{

	s0 = 34;
return;	}	}
	case 36:
	leftWheel.motorTorque = ___speed00;
	rightWheel.motorTorque = ___speed00;
	world.Jeep.Value.Fuel = ((world.Jeep.Value.Fuel) - (1f));
	s0 = -1;
return;
	case 37:
	leftWheel.motorTorque = ((___speed00) * (10f));
	rightWheel.motorTorque = ((___speed00) * (10f));
	world.Jeep.Value.Fuel = world.Jeep.Value.Fuel;
	s0 = 39;
return;
	case 39:
	count_down9 = 2f;
	goto case 40;
	case 40:
	if(((count_down9) > (0f)))
	{

	count_down9 = ((count_down9) - (dt));
	s0 = 40;
return;	}else
	{

	s0 = -1;
return;	}
	case 32:
	leftWheel.motorTorque = ___speed00;
	rightWheel.motorTorque = ___speed00;
	world.Jeep.Value.Fuel = ((world.Jeep.Value.Fuel) - (1f));
	s0 = -1;
return;
	case 29:
	leftWheel.motorTorque = 0f;
	rightWheel.motorTorque = 0f;
	world.Jeep.Value.Fuel = world.Jeep.Value.Fuel;
	s0 = -1;
return;
	case 26:
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

	goto case 17;	}
	case 17:
	___z19 = (

(world.Gasstations).Select(__ContextSymbol98 => new { ___a117 = __ContextSymbol98 })
.Where(__ContextSymbol99 => __ContextSymbol99.___a117.Updating)
.Select(__ContextSymbol100 => __ContextSymbol100.___a117)
.ToList<Gasstation>()).ToList<Gasstation>();
	if(((((___z19.Count) == (0))) && (!(world.Jeep.Value.isModel))))
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
		public System.Single CollisionDamage{  get { return UnityZombie2.CollisionDamage; }
  set{UnityZombie2.CollisionDamage = value; }
 }
	public System.Boolean Dead{  get { return UnityZombie2.Dead; }
  set{UnityZombie2.Dead = value; }
 }
	public System.Boolean Destroyed{  get { return UnityZombie2.Destroyed; }
  set{UnityZombie2.Destroyed = value; }
 }
	public System.Boolean HasCollided{  get { return UnityZombie2.HasCollided; }
  set{UnityZombie2.HasCollided = value; }
 }
	public System.Boolean IsHit{  get { return UnityZombie2.IsHit; }
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
	public System.Boolean isActiveAndEnabled{  get { return UnityZombie2.isActiveAndEnabled; }
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
	if(((0f) > (Life)))
	{

	goto case 2;	}else
	{

	s0 = -1;
return;	}
	case 2:
	UnityEngine.Debug.Log("Zombie is dead");
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
	if(!(world.Jeep.IsSome))
	{

	s1 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	if(world.Jeep.Value.Active)
	{

	goto case 1;	}else
	{

	s1 = -1;
return;	}
	case 1:
	if(OnMouseOver)
	{

	goto case 3;	}else
	{

	s1 = -1;
return;	}
	case 3:
	UnityEngine.Debug.Log("OnMouseOver = true");
	if(!(world.Pistols.Head().Automatic))
	{

	goto case 4;	}else
	{

	goto case 5;	}
	case 4:
	if(((world.Pistols.Head().GunController.Trigger) || (UnityEngine.Input.GetMouseButtonDown(0))))
	{

	goto case 8;	}else
	{

	s1 = -1;
return;	}
	case 8:
	UnityEngine.Debug.Log(world.Pistols.Head().DamagePerBullet);
	if(((Life) > (0.49f)))
	{

	goto case 9;	}else
	{

	goto case 10;	}
	case 9:
	Life = ((Life) - (world.Pistols.Head().DamagePerBullet));
	s1 = -1;
return;
	case 10:
	Life = 0f;
	s1 = -1;
return;
	case 5:
	if(world.Pistols.Head().GunController.Shot)
	{

	goto case 16;	}else
	{

	s1 = -1;
return;	}
	case 16:
	if(((Life) > (0.49f)))
	{

	goto case 17;	}else
	{

	goto case 18;	}
	case 17:
	Life = ((Life) - (world.Pistols.Head().DamagePerBullet));
	s1 = -1;
return;
	case 18:
	Life = 0f;
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(!(((world.Pistols.Head().TypeWeapon) == ("Bazooka"))))
	{

	s2 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Life = Life;
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
	Life = ((Life) - (((CollisionDamage) * (4f))));
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