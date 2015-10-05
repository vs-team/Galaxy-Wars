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
		Flock = (

Enumerable.Empty<GroupZombie>()).ToList<GroupZombie>();
		Flashs = (

(new Cons<Light>(new Light(),(new Empty<Light>()).ToList<Light>())).ToList<Light>()).ToList<Light>();
		
}
		public UnityCheckpoint Checkpoint{  get { return UnityLandscape.Checkpoint; }
 }
	public System.Boolean Destroyed{  get { return UnityLandscape.Destroyed; }
  set{UnityLandscape.Destroyed = value; }
 }
	public List<Light> Flashs;
	public List<GroupZombie> Flock;
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
	public List<Landscape> ___ls00;
	public System.Int32 ___randr00;
	public System.Single count_down1;
	public List<Zombie> ___zmbies20;
	public List<GroupZombie> ___groups30;
	public List<Zombie> ___zombiegroup30;
	public System.Int32 ___amount30;
	public System.Int32 ___amount230;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;

		for(int x0 = 0; x0 < Flashs.Count; x0++) { 
			Flashs[x0].Update(dt, world);
		}
		for(int x0 = 0; x0 < Flock.Count; x0++) { 
			Flock[x0].Update(dt, world);
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
		this.Rule2(dt, world);
		this.Rule3(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	___ls00 = (

(Landscapes).Select(__ContextSymbol5 => new { ___a00 = __ContextSymbol5 })
.Where(__ContextSymbol6 => __ContextSymbol6.___a00.Checkpoint.isEntered)
.Select(__ContextSymbol7 => __ContextSymbol7.___a00)
.ToList<Landscape>()).ToList<Landscape>();
	if(((___ls00.Count) > (0)))
	{

	goto case 1;	}else
	{

	s0 = -1;
return;	}
	case 1:
	___randr00 = UnityEngine.Random.Range(1,5);
	Landscapes = new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,(___ls00.Head().Position.z) - (80f)),___randr00), (Landscapes)).ToList<Landscape>();
	s0 = 2;
return;
	case 2:
	count_down1 = 10f;
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
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	___zmbies20 = (

(Zombies).Select(__ContextSymbol8 => new { ___a21 = __ContextSymbol8 })
.Where(__ContextSymbol9 => ((__ContextSymbol9.___a21.Destroyed) == (false)))
.Select(__ContextSymbol10 => __ContextSymbol10.___a21)
.ToList<Zombie>()).ToList<Zombie>();
	Zombies = ___zmbies20;
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	___groups30 = (

(Landscapes).Select(__ContextSymbol11 => new { ___a32 = __ContextSymbol11 })
.SelectMany(__ContextSymbol12=> (__ContextSymbol12.___a32.Group).Select(__ContextSymbol13 => new { ___b30 = __ContextSymbol13,
                                                      prev = __ContextSymbol12 })
.Select(__ContextSymbol14 => __ContextSymbol14.___b30)
.ToList<GroupZombie>())).ToList<GroupZombie>();
	___zombiegroup30 = (

(___groups30).Select(__ContextSymbol15 => new { ___a33 = __ContextSymbol15 })
.SelectMany(__ContextSymbol16=> (__ContextSymbol16.___a33.ZombieFollowers).Select(__ContextSymbol17 => new { ___c30 = __ContextSymbol17,
                                                      prev = __ContextSymbol16 })
.Select(__ContextSymbol18 => __ContextSymbol18.___c30)
.ToList<Zombie>())).ToList<Zombie>();
	___amount30 = ___groups30.Count;
	___amount230 = ___zombiegroup30.Count;
	UnityEngine.Debug.Log(("groups =  ") + (___amount30));
	UnityEngine.Debug.Log(("zombiegroup = ") + (___amount230));
	if(((___zombiegroup30.Count) > (0)))
	{

	goto case 3;	}else
	{

	s3 = -1;
return;	}
	case 3:
	Zombies = (___zombiegroup30).Concat(Zombies).ToList<Zombie>();
	s3 = -1;
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
	public List<Zombie> ___z00;
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
	___z00 = (

(U_Zombies).Select(__ContextSymbol21 => new { ___a04 = __ContextSymbol21 })
.Select(__ContextSymbol22 => new Zombie(__ContextSymbol22.___a04))
.ToList<Zombie>()).ToList<Zombie>();
	UnityEngine.Debug.Log(("U_Zombies ") + (___z00.Count));
	ZombieFollowers = ___z00;
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
	UnityEngine.Debug.Log(("Followers: ") + (ZombieFollowers.Count));
	___leader10 = new Zombie(U_ZombieLeader);
	ZombieLeader = (new Just<Zombie>(___leader10));
	s1 = 0;
return;
	case 0:
	UnityEngine.Debug.Log(("Leader: ") + (ZombieLeader.Value.name));
	s1 = -1;
return;	
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
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(!(Bumper))
	{

	s0 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	if(!(!(Bumper)))
	{

	s0 = 1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Bumper = Bumper;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(!(Trigger))
	{

	s1 = -1;
return;	}else
	{

	goto case 2;	}
	case 2:
	UnityEngine.Debug.Log("Booom!");
	goto case 1;
	case 1:
	if(!(!(Trigger)))
	{

	s1 = 1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Trigger = Trigger;
	s1 = -1;
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
		NotInMagazine = 200;
		MagazineSize = 80;
		InMagazine = 20;
		GunController = new ControllerRazor("Hydra1 - Right");
		
}
		public ControllerRazor GunController;
	public System.Int32 InMagazine;
	public System.Int32 MagazineSize;
	public System.Int32 NotInMagazine;
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

	goto case 5;	}else
	{

	s0 = -1;
return;	}
	case 5:
	Reloading = false;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(((UnityEngine.Input.GetKey(KeyCode.R)) && (((NotInMagazine) > (0)))))
	{

	goto case 8;	}else
	{

	s1 = -1;
return;	}
	case 8:
	Reloading = true;
	InMagazine = InMagazine;
	NotInMagazine = NotInMagazine;
	s1 = 14;
return;
	case 14:
	count_down2 = ReloadDuration;
	goto case 15;
	case 15:
	if(((count_down2) > (0f)))
	{

	count_down2 = ((count_down2) - (dt));
	s1 = 15;
return;	}else
	{

	goto case 11;	}
	case 11:
	if(((MagazineSize) > (NotInMagazine)))
	{

	goto case 9;	}else
	{

	goto case 10;	}
	case 9:
	Reloading = false;
	InMagazine = NotInMagazine;
	NotInMagazine = 0;
	s1 = -1;
return;
	case 10:
	Reloading = false;
	InMagazine = MagazineSize;
	NotInMagazine = ((NotInMagazine) - (MagazineSize));
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(((((GunController.Trigger) && (((InMagazine) > (0))))) && (((Reloading) == (false)))))
	{

	goto case 18;	}else
	{

	s2 = -1;
return;	}
	case 18:
	InMagazine = ((InMagazine) - (1));
	s2 = 19;
return;
	case 19:
	InMagazine = InMagazine;
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
		LightController = new ControllerRazor("Hydra1 - Left");
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
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	UnityEngine.Debug.Log(("Battery: ") + (Battery));
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
	Battery = Battery;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	Active = LightController.Trigger;
	s1 = -1;
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
		UnityLandscape = UnityLandscape.Instantiate(pos,ps);
		Spawnpoints = (

Enumerable.Empty<UnityEngine.Transform>()).ToList<UnityEngine.Transform>();
		Group = (

Enumerable.Empty<GroupZombie>()).ToList<GroupZombie>();
		
}
		public UnityCheckpoint Checkpoint{  get { return UnityLandscape.Checkpoint; }
 }
	public System.Boolean Destroyed{  get { return UnityLandscape.Destroyed; }
  set{UnityLandscape.Destroyed = value; }
 }
	public List<GroupZombie> Group;
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
	public UnityEngine.Transform ___sps11;
	public UnityEngine.Vector3 ___sps_pos10;
	public void Update(float dt, World world) {
frame = World.frame;

		for(int x0 = 0; x0 < Group.Count; x0++) { 
			Group[x0].Update(dt, world);
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

(Spawnpoints2).Select(__ContextSymbol27 => new { ___a05 = __ContextSymbol27 })
.Select(__ContextSymbol28 => __ContextSymbol28.___a05)
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

	goto case 3;	}
	case 3:
	___random_spawnp10 = UnityEngine.Random.Range(0,4);
	___sps11 = (Spawnpoints)[___random_spawnp10];
	___sps_pos10 = ___sps11.position;
	Group = (

(new Cons<GroupZombie>(new GroupZombie(___sps_pos10),(new Empty<GroupZombie>()).ToList<GroupZombie>())).ToList<GroupZombie>()).ToList<GroupZombie>();
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
		maxSteeringAngle = 50f;
		maxMotorTorque = 250f;
		TruckScript = TruckScript.Instantiate();
		Fuel = 4000f;
		DriveEngine = new Engine();
		AxleInfos = (

(new Cons<AxleInfo>(new AxleInfo(FrontLeftWheel,FrontRightWheel,true,true),(new Cons<AxleInfo>(new AxleInfo(RearLeftWheel,RearRightWheel,true,false),(new Empty<AxleInfo>()).ToList<AxleInfo>())).ToList<AxleInfo>())).ToList<AxleInfo>()).ToList<AxleInfo>();
		
}
		public List<AxleInfo> AxleInfos;
	public UnityEngine.Vector3 CenterOfMass{  get { return TruckScript.CenterOfMass; }
  set{TruckScript.CenterOfMass = value; }
 }
	public Engine DriveEngine;
	public System.Single Frce{  set{TruckScript.Frce = value; }
 }
	public UnityEngine.WheelCollider FrontLeftWheel{  get { return TruckScript.FrontLeftWheel; }
  set{TruckScript.FrontLeftWheel = value; }
 }
	public UnityEngine.WheelCollider FrontRightWheel{  get { return TruckScript.FrontRightWheel; }
  set{TruckScript.FrontRightWheel = value; }
 }
	public System.Single Fuel;
	public UnityEngine.Vector3 Position{  get { return TruckScript.Position; }
 }
	public UnityEngine.WheelCollider RearLeftWheel{  get { return TruckScript.RearLeftWheel; }
  set{TruckScript.RearLeftWheel = value; }
 }
	public UnityEngine.WheelCollider RearRightWheel{  get { return TruckScript.RearRightWheel; }
  set{TruckScript.RearRightWheel = value; }
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
	public System.Single maxMotorTorque;
	public System.Single maxSteeringAngle;
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

		for(int x0 = 0; x0 < AxleInfos.Count; x0++) { 
			AxleInfos[x0].Update(dt, world);
		}
		DriveEngine.Update(dt, world);
		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	CenterOfMass = new UnityEngine.Vector3(1f,0f,-1.5f);
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
	public System.Single ___speed00;
	public System.Single ___steeringAngle10;
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
	if(((world.Jeep.Fuel) > (0.99f)))
	{

	goto case 2;	}else
	{

	goto case 3;	}
	case 2:
	if(((((world.Jeep.DriveEngine.Active) && (!(((UnityEngine.Input.GetAxis("Vertical")) == (0f)))))) && (((leftWheel.isGrounded) || (rightWheel.isGrounded)))))
	{

	goto case 5;	}else
	{

	goto case 6;	}
	case 5:
	if(!(motor))
	{

	s0 = 5;
return;	}else
	{

	goto case 9;	}
	case 9:
	___speed00 = ((((world.Jeep.maxMotorTorque) * (UnityEngine.Input.GetAxis("Vertical")))) * (-1f));
	leftWheel.motorTorque = ___speed00;
	rightWheel.motorTorque = ___speed00;
	world.Jeep.Fuel = ((world.Jeep.Fuel) - (1f));
	s0 = -1;
return;
	case 6:
	leftWheel.motorTorque = 0f;
	rightWheel.motorTorque = 0f;
	world.Jeep.Fuel = world.Jeep.Fuel;
	s0 = -1;
return;
	case 3:
	leftWheel.motorTorque = 0f;
	rightWheel.motorTorque = 0f;
	world.Jeep.Fuel = 0f;
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

	goto case 1;	}
	case 1:
	___steeringAngle10 = ((world.Jeep.maxSteeringAngle) * (UnityEngine.Input.GetAxis("Horizontal")));
	leftWheel.steerAngle = ___steeringAngle10;
	rightWheel.steerAngle = ___steeringAngle10;
	s1 = -1;
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
		Rotation = 0f;
		BrakeAndReverse = 0f;
		Active = true;
		Accel = 0f;
		
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
private UnityEngine.Transform trans;
	public int ID;
public Zombie(UnityEngine.Transform trans)
	{JustEntered = false;
 frame = World.frame;
		UnityZombie = UnityZombie.Find(trans);
		Life = 100f;
		
}
		public System.Boolean Destroyed{  get { return UnityZombie.Destroyed; }
  set{UnityZombie.Destroyed = value; }
 }
	public System.Single Life;
	public System.Boolean OnMouseOver{  get { return UnityZombie.OnMouseOver; }
 }
	public UnityEngine.Vector3 Position{  get { return UnityZombie.Position; }
 }
	public UnityZombie UnityZombie;
	public System.Boolean dead2{  get { return UnityZombie.dead2; }
  set{UnityZombie.dead2 = value; }
 }
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
	public System.Boolean shot{  get { return UnityZombie.shot; }
  set{UnityZombie.shot = value; }
 }
	public System.String tag{  get { return UnityZombie.tag; }
  set{UnityZombie.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityZombie.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityZombie.useGUILayout; }
  set{UnityZombie.useGUILayout = value; }
 }
	public System.Single count_down3;
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
	if(((0f) > (Life)))
	{

	goto case 4;	}else
	{

	s0 = -1;
return;	}
	case 4:
	shot = true;
	dead2 = true;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(((OnMouseOver) && (world.Pistols.Head().GunController.Trigger)))
	{

	goto case 7;	}else
	{

	s1 = -1;
return;	}
	case 7:
	if(((Life) > (0.49f)))
	{

	goto case 8;	}else
	{

	goto case 9;	}
	case 8:
	Life = ((Life) - (40f));
	s1 = -1;
return;
	case 9:
	Life = 0f;
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(!(dead2))
	{

	s2 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	count_down3 = 3f;
	goto case 2;
	case 2:
	if(((count_down3) > (0f)))
	{

	count_down3 = ((count_down3) - (dt));
	s2 = 2;
return;	}else
	{

	goto case 0;	}
	case 0:
	Destroyed = true;
	s2 = -1;
return;	
	default: return;}}
	





}
}              