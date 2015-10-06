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
		___randomr00 = UnityEngine.Random.Range(1,5);
		Zombies = (

Enumerable.Empty<Zombie>()).ToList<Zombie>();
		UnityLandscape = new UnityLandscape();
		Pistols = (

(new Cons<Gun>(new Gun(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
		Landscapes = (

(new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,-160f),1),(new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,-80f),2),(new Cons<Landscape>(new Landscape(Vector3.zero,___randomr00),(new Empty<Landscape>()).ToList<Landscape>())).ToList<Landscape>())).ToList<Landscape>())).ToList<Landscape>()).ToList<Landscape>();
		Jeep = new Truck();
		Health = 100f;
		GUIpanel = new GUI();
		Flashs = (

(new Cons<Light>(new Light(),(new Empty<Light>()).ToList<Light>())).ToList<Light>()).ToList<Light>();
		
}
		public UnityCheckpoint Checkpoint{  get { return UnityLandscape.Checkpoint; }
 }
	public System.Boolean Destroyed{  get { return UnityLandscape.Destroyed; }
  set{UnityLandscape.Destroyed = value; }
 }
	public List<Light> __Flashs;
	public List<Light> Flashs{  get { return  __Flashs; }
  set{ __Flashs = value;
 foreach(var e in value){if(e.JustEntered){ e.JustEntered = false;
}
} }
 }
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
	public UnityEngine.Vector3 ___Headpos00;
	public List<Zombie> ___zmbies20;
	public List<GroupZombie> ___groups30;
	public List<Zombie> ___zombiegroup30;
	public List<Zombie> ___groupleader30;
	public List<Zombie> ___group30;

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
		this.Rule2(dt, world);
		this.Rule3(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	___ls00 = (

(Landscapes).Select(__ContextSymbol4 => new { ___a00 = __ContextSymbol4 })
.Select(__ContextSymbol5 => __ContextSymbol5.___a00)
.ToList<Landscape>()).ToList<Landscape>();
	if(((___ls00.Count) > (0)))
	{

	goto case 1;	}else
	{

	s0 = -1;
return;	}
	case 1:
	___randr00 = UnityEngine.Random.Range(1,5);
	___Headpos00 = ___ls00.Head().Position;
	UnityEngine.Debug.Log(("Headpos = ") + (___Headpos00));
	Landscapes = new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,(___ls00.Head().Position.z) - (80f)),___randr00), (Landscapes)).ToList<Landscape>();
	s0 = 2;
return;
	case 2:
	if(!(((200f) > (UnityEngine.Vector3.Distance(Jeep.Position,___Headpos00)))))
	{

	s0 = 2;
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

(Zombies).Select(__ContextSymbol6 => new { ___a21 = __ContextSymbol6 })
.Where(__ContextSymbol7 => ((__ContextSymbol7.___a21.Destroyed) == (false)))
.Select(__ContextSymbol8 => __ContextSymbol8.___a21)
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

(Landscapes).Select(__ContextSymbol9 => new { ___a32 = __ContextSymbol9 })
.SelectMany(__ContextSymbol10=> (__ContextSymbol10.___a32.Group).Select(__ContextSymbol11 => new { ___b30 = __ContextSymbol11,
                                                      prev = __ContextSymbol10 })
.Select(__ContextSymbol12 => __ContextSymbol12.___b30)
.ToList<GroupZombie>())).ToList<GroupZombie>();
	___zombiegroup30 = (

(___groups30).Select(__ContextSymbol13 => new { ___a33 = __ContextSymbol13 })
.SelectMany(__ContextSymbol14=> (__ContextSymbol14.___a33.ZombieFollowers).Select(__ContextSymbol15 => new { ___c30 = __ContextSymbol15,
                                                      prev = __ContextSymbol14 })
.Select(__ContextSymbol16 => __ContextSymbol16.___c30)
.ToList<Zombie>())).ToList<Zombie>();
	___groupleader30 = (

(___groups30).Select(__ContextSymbol17 => new { ___a34 = __ContextSymbol17 })
.Where(__ContextSymbol18 => __ContextSymbol18.___a34.ZombieLeader.IsSome)
.Select(__ContextSymbol19 => new {___z30 = __ContextSymbol19.___a34.ZombieLeader.Value, prev = __ContextSymbol19 })
.Select(__ContextSymbol20 => __ContextSymbol20.___z30)
.ToList<Zombie>()).ToList<Zombie>();
	___group30 = (___groupleader30).Concat(___zombiegroup30).ToList<Zombie>();
	UnityEngine.Debug.Log(("group.Count = ") + (___group30.Count));
	if(((___group30.Count) > (0)))
	{

	goto case 3;	}else
	{

	s3 = -1;
return;	}
	case 3:
	Zombies = (___group30).Concat(Zombies).ToList<Zombie>();
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

(U_Zombies).Select(__ContextSymbol23 => new { ___a05 = __ContextSymbol23 })
.Select(__ContextSymbol24 => new Zombie(__ContextSymbol24.___a05))
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
	if(UnityEngine.Input.GetKey(KeyCode.C))
	{

	goto case 2;	}else
	{

	s0 = -1;
return;	}
	case 2:
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

	goto case 5;	}else
	{

	s1 = -1;
return;	}
	case 5:
	Reloading = true;
	InMagazine = InMagazine;
	NotInMagazine = NotInMagazine;
	s1 = 11;
return;
	case 11:
	count_down1 = ReloadDuration;
	goto case 12;
	case 12:
	if(((count_down1) > (0f)))
	{

	count_down1 = ((count_down1) - (dt));
	s1 = 12;
return;	}else
	{

	goto case 8;	}
	case 8:
	if(((MagazineSize) > (NotInMagazine)))
	{

	goto case 6;	}else
	{

	goto case 7;	}
	case 6:
	Reloading = false;
	InMagazine = NotInMagazine;
	NotInMagazine = 0;
	s1 = -1;
return;
	case 7:
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

	goto case 15;	}else
	{

	s2 = -1;
return;	}
	case 15:
	InMagazine = ((InMagazine) - (1));
	s2 = 16;
return;
	case 16:
	if(!(!(GunController.Trigger)))
	{

	s2 = 16;
return;	}else
	{

	s2 = -1;
return;	}	
	default: return;}}
	





}
public class Light{
public int frame;
public bool JustEntered = true;
	public int ID;
public Light()
	{JustEntered = false;
 frame = World.frame;
		Lighty = false;
		LightController = new ControllerRazor("Hydra1 - Left");
		Battery = 100f;
		Active = false;
		
}
		public System.Boolean Active;
	public System.Single Battery;
	public ControllerRazor LightController;
	public System.Boolean Lighty;
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
	if(!(((Active) && (((Battery) > (0.49f))))))
	{

	s0 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	UnityEngine.Debug.Log(("Battery: ") + (Battery));
	Battery = ((Battery) - (0.5f));
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(!(!(((LightController.Trigger) == (Active)))))
	{

	s1 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Active = LightController.Trigger;
	Lighty = world.Jeep.LightOn;
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
		GUIBarScript = GUIBarScript.Instantiate();
		
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
	public System.Single Value{  get { return GUIBarScript.Value; }
  set{GUIBarScript.Value = value; }
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

(Spawnpoints2).Select(__ContextSymbol30 => new { ___a06 = __ContextSymbol30 })
.Select(__ContextSymbol31 => __ContextSymbol31.___a06)
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
		maxMotorTorque = 200f;
		TruckScript = TruckScript.Instantiate();
		Fuel = 4000f;
		DriveEngine = new Engine();
		AxleInfos = (

(new Cons<AxleInfo>(new AxleInfo(FrontLeftWheel,FrontRightWheel,true,true),(new Cons<AxleInfo>(new AxleInfo(RearLeftWheel,RearRightWheel,true,false),(new Empty<AxleInfo>()).ToList<AxleInfo>())).ToList<AxleInfo>())).ToList<AxleInfo>()).ToList<AxleInfo>();
		
}
		public System.Single Acceleration{  get { return TruckScript.Acceleration; }
 }
	public List<AxleInfo> AxleInfos;
	public System.Single BrakeAndReverse{  get { return TruckScript.BrakeAndReverse; }
 }
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
	public System.Boolean LightOn{  get { return TruckScript.LightOn; }
  set{TruckScript.LightOn = value; }
 }
	public UnityEngine.Vector3 Position{  get { return TruckScript.Position; }
 }
	public UnityEngine.WheelCollider RearLeftWheel{  get { return TruckScript.RearLeftWheel; }
  set{TruckScript.RearLeftWheel = value; }
 }
	public UnityEngine.WheelCollider RearRightWheel{  get { return TruckScript.RearRightWheel; }
  set{TruckScript.RearRightWheel = value; }
 }
	public System.Single Steering{  get { return TruckScript.Steering; }
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
	public UnityEngine.Light lampi{  get { return TruckScript.lampi; }
  set{TruckScript.lampi = value; }
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
	if(((((world.Jeep.DriveEngine.Active) && (!(((world.Jeep.DriveEngine.cnvAccel) == (0f)))))) && (((leftWheel.isGrounded) || (rightWheel.isGrounded)))))
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
	___speed00 = ((((world.Jeep.maxMotorTorque) * (world.Jeep.DriveEngine.cnvAccel))) * (-1f));
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
	___steeringAngle10 = ((world.Jeep.maxSteeringAngle) * (world.Jeep.DriveEngine.cnvRotation));
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
		cnvRotation = 0f;
		cnvBrakeAndReverse = 0f;
		cnvAccel = 0f;
		TruckScript = new TruckScript();
		Active = true;
		
}
		public System.Single Acceleration{  get { return TruckScript.Acceleration; }
 }
	public System.Boolean Active;
	public System.Single BrakeAndReverse{  get { return TruckScript.BrakeAndReverse; }
 }
	public UnityEngine.Vector3 CenterOfMass{  get { return TruckScript.CenterOfMass; }
  set{TruckScript.CenterOfMass = value; }
 }
	public System.Single Frce{  set{TruckScript.Frce = value; }
 }
	public UnityEngine.WheelCollider FrontLeftWheel{  get { return TruckScript.FrontLeftWheel; }
  set{TruckScript.FrontLeftWheel = value; }
 }
	public UnityEngine.WheelCollider FrontRightWheel{  get { return TruckScript.FrontRightWheel; }
  set{TruckScript.FrontRightWheel = value; }
 }
	public System.Boolean LightOn{  get { return TruckScript.LightOn; }
  set{TruckScript.LightOn = value; }
 }
	public UnityEngine.Vector3 Position{  get { return TruckScript.Position; }
 }
	public UnityEngine.WheelCollider RearLeftWheel{  get { return TruckScript.RearLeftWheel; }
  set{TruckScript.RearLeftWheel = value; }
 }
	public UnityEngine.WheelCollider RearRightWheel{  get { return TruckScript.RearRightWheel; }
  set{TruckScript.RearRightWheel = value; }
 }
	public System.Single Steering{  get { return TruckScript.Steering; }
 }
	public UnityEngine.Vector3 Trque{  set{TruckScript.Trque = value; }
 }
	public TruckScript TruckScript;
	public System.Single cnvAccel;
	public System.Single cnvBrakeAndReverse;
	public System.Single cnvRotation;
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
	public UnityEngine.Light lampi{  get { return TruckScript.lampi; }
  set{TruckScript.lampi = value; }
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

		this.Rule0(dt, world);
		this.Rule1(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(!(((Acceleration) == (0f))))
	{

	goto case 3;	}else
	{

	goto case 4;	}
	case 3:
	cnvAccel = Acceleration;
	s0 = -1;
return;
	case 4:
	cnvAccel = ((BrakeAndReverse) * (-1f));
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	cnvRotation = Steering;
	s1 = -1;
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
		UnityZombie = UnityZombie.Find(trans);
		Life = 100f;
		
}
		public System.Boolean Destroyed{  get { return UnityZombie.Destroyed; }
  set{UnityZombie.Destroyed = value; }
 }
	public System.Boolean IsHit{  get { return UnityZombie.IsHit; }
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
	if(((0.1f) > (Life)))
	{

	goto case 2;	}else
	{

	s0 = -1;
return;	}
	case 2:
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
	if(world.Pistols.Head().GunController.Trigger)
	{

	goto case 5;	}else
	{

	s1 = -1;
return;	}
	case 5:
	if(IsHit)
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
	count_down2 = 1f;
	goto case 2;
	case 2:
	if(((count_down2) > (0f)))
	{

	count_down2 = ((count_down2) - (dt));
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