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
		___truk00 = new Truck("zpickup",new UnityEngine.Vector3(0f,-6f,0f),false,(

(new Cons<System.Int32>(4,(new Cons<System.Int32>(2,(new Cons<System.Int32>(1,(new Cons<System.Int32>(3,(new Empty<System.Int32>()).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>()).ToList<System.Int32>());
		Zombies = (

Enumerable.Empty<Zombie>()).ToList<Zombie>();
		ZombiegroupDest = (new Nothing<ZombieGroupDestroyer>());
		W_Refill_Resources = false;
		UnityLandscape = new UnityLandscape();
		Score = 0;
		Players = (

(new Cons<Player>(new Player(1),(new Empty<Player>()).ToList<Player>())).ToList<Player>()).ToList<Player>();
		Landscapes = (

(new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,-160f),1),(new Cons<Landscape>(new Landscape(Vector3.zero,2),(new Empty<Landscape>()).ToList<Landscape>())).ToList<Landscape>())).ToList<Landscape>()).ToList<Landscape>();
		Jeep = (new Just<Truck>(___truk00));
		Gasstations = (

(new Cons<Gasstation>(new Gasstation(new UnityEngine.Vector3(0f,0f,-80f)),(new Empty<Gasstation>()).ToList<Gasstation>())).ToList<Gasstation>()).ToList<Gasstation>();
		GUIpanel = new GUI();
		Counter = 3;
		ActiveBoR = "";
		
}
		public System.String ActiveBoR;
	public UnityCheckpoint Checkpoint{  get { return UnityLandscape.Checkpoint; }
 }
	public System.Int32 Counter;
	public System.Boolean Destroyed{  get { return UnityLandscape.Destroyed; }
  set{UnityLandscape.Destroyed = value; }
 }
	public GUI GUIpanel;
	public List<Gasstation> __Gasstations;
	public List<Gasstation> Gasstations{  get { return  __Gasstations; }
  set{ __Gasstations = value;
 foreach(var e in value){if(e.JustEntered){ e.JustEntered = false;
}
} }
 }
	public Option<Truck> __Jeep;
	public Option<Truck> Jeep{  get { return  __Jeep; }
  set{ __Jeep = value;
 if(value.IsSome){if(!value.Value.JustEntered) __Jeep = value; 
 else{ value.Value.JustEntered = false;
}
} }
 }
	public List<Landscape> __Landscapes;
	public List<Landscape> Landscapes{  get { return  __Landscapes; }
  set{ __Landscapes = value;
 foreach(var e in value){if(e.JustEntered){ e.JustEntered = false;
}
} }
 }
	public List<Player> Players;
	public UnityEngine.Vector3 Position{  get { return UnityLandscape.Position; }
 }
	public System.Int32 Score;
	public System.Collections.Generic.List<UnityEngine.Transform> Spawnpoints2{  get { return UnityLandscape.Spawnpoints2; }
 }
	public UnityLandscape UnityLandscape;
	public System.Boolean W_Refill_Resources;
	public Option<ZombieGroupDestroyer> ZombiegroupDest;
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
	public List<Gasstation> ___gs00;
	public System.Int32 ___randr00;
	public UnityEngine.Vector3 ___Headpos00;
	public UnityEngine.Vector3 ___Headpos01;
	public List<System.String> ___a12;
	public List<System.String> ___resourcelist20;
	public System.Int32 ___rnd20;
	public List<Zombie> ___zmbies30;
	public List<GroupZombie> ___groups40;
	public List<Zombie> ___zombiegroup40;
	public List<Zombie> ___groupleader40;
	public List<Zombie> ___group40;
	public List<Gasstation> ___j60;
	public System.Boolean ___t60;
	public System.Single count_down3;
	public List<Landscape> ___x70;
	public List<Landscape> ___q70;
	public UnityEngine.Transform ___g70;
	public ZombieGroupDestroyer ___j71;
	public System.Single count_down1;
	public ZombieGroupDestroyer ___z71;
	public System.Single count_down2;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;

		GUIpanel.Update(dt, world);
		for(int x0 = 0; x0 < Gasstations.Count; x0++) { 
			Gasstations[x0].Update(dt, world);
		}
if(Jeep.IsSome){ 		Jeep.Value.Update(dt, world);
 } 
		for(int x0 = 0; x0 < Landscapes.Count; x0++) { 
			Landscapes[x0].Update(dt, world);
		}
		for(int x0 = 0; x0 < Players.Count; x0++) { 
			Players[x0].Update(dt, world);
		}
if(ZombiegroupDest.IsSome){ 		ZombiegroupDest.Value.Update(dt, world);
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
		this.Rule7(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	___ls00 = (

(Landscapes).Select(__ContextSymbol5 => new { ___a00 = __ContextSymbol5 })
.Select(__ContextSymbol6 => __ContextSymbol6.___a00)
.ToList<Landscape>()).ToList<Landscape>();
	___gs00 = (

(Gasstations).Select(__ContextSymbol7 => new { ___b00 = __ContextSymbol7 })
.Select(__ContextSymbol8 => __ContextSymbol8.___b00)
.ToList<Gasstation>()).ToList<Gasstation>();
	if(((___ls00.Count) > (0)))
	{

	goto case 1;	}else
	{

	s0 = -1;
return;	}
	case 1:
	___randr00 = UnityEngine.Random.Range(1,5);
	if(((___gs00.Count) > (0)))
	{

	goto case 2;	}else
	{

	goto case 3;	}
	case 2:
	if(((___gs00.Head().Position.z) > (___ls00.Head().Position.z)))
	{

	___Headpos00 = ___ls00.Head().Position;	}else
	{

	___Headpos00 = ___gs00.Head().Position;	}
	if(((Counter) > (7)))
	{

	goto case 5;	}else
	{

	goto case 6;	}
	case 5:
	Landscapes = Landscapes;
	Counter = 0;
	Gasstations = new Cons<Gasstation>(new Gasstation(new UnityEngine.Vector3(0f,0f,(___Headpos00.z) - (80f))), (Gasstations)).ToList<Gasstation>();
	s0 = 8;
return;
	case 8:
	if(!(((200f) > (UnityEngine.Vector3.Distance(___Headpos00,Jeep.Value.Position)))))
	{

	s0 = 8;
return;	}else
	{

	s0 = -1;
return;	}
	case 6:
	Landscapes = new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,(___Headpos00.z) - (80f)),___randr00), (Landscapes)).ToList<Landscape>();
	Counter = ((Counter) + (1));
	Gasstations = Gasstations;
	s0 = 11;
return;
	case 11:
	Landscapes = Landscapes;
	Counter = Counter;
	Gasstations = Gasstations;
	s0 = 10;
return;
	case 10:
	if(!(((200f) > (UnityEngine.Vector3.Distance(___Headpos00,Jeep.Value.Position)))))
	{

	s0 = 10;
return;	}else
	{

	s0 = -1;
return;	}
	case 3:
	___Headpos01 = ___ls00.Head().Position;
	if(((Counter) > (7)))
	{

	goto case 14;	}else
	{

	goto case 15;	}
	case 14:
	Landscapes = Landscapes;
	Counter = 0;
	Gasstations = new Cons<Gasstation>(new Gasstation(new UnityEngine.Vector3(0f,0f,(___Headpos01.z) - (80f))), (Gasstations)).ToList<Gasstation>();
	s0 = 17;
return;
	case 17:
	if(!(((200f) > (UnityEngine.Vector3.Distance(___Headpos01,Jeep.Value.Position)))))
	{

	s0 = 17;
return;	}else
	{

	s0 = -1;
return;	}
	case 15:
	Landscapes = new Cons<Landscape>(new Landscape(new UnityEngine.Vector3(0f,0f,(___Headpos01.z) - (80f)),___randr00), (Landscapes)).ToList<Landscape>();
	Counter = ((Counter) + (1));
	Gasstations = Gasstations;
	s0 = 20;
return;
	case 20:
	Landscapes = Landscapes;
	Counter = Counter;
	Gasstations = Gasstations;
	s0 = 19;
return;
	case 19:
	if(!(((200f) > (UnityEngine.Vector3.Distance(___Headpos01,Jeep.Value.Position)))))
	{

	s0 = 19;
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
	___a12 = (

(Landscapes).Select(__ContextSymbol9 => new { ___a11 = __ContextSymbol9 })
.SelectMany(__ContextSymbol10=> (__ContextSymbol10.___a11.PickUps).Select(__ContextSymbol11 => new { ___b11 = __ContextSymbol11,
                                                      prev = __ContextSymbol10 })
.SelectMany(__ContextSymbol12=> (__ContextSymbol12.___b11.BonusAndResources).Select(__ContextSymbol13 => new { ___c10 = __ContextSymbol13,
                                                      prev = __ContextSymbol12 })
.Where(__ContextSymbol14 => __ContextSymbol14.___c10.Active)
.Select(__ContextSymbol15 => __ContextSymbol15.___c10.NameOfBoR)
.ToList<System.String>()))).ToList<System.String>();
	if(((___a12.Count) > (0)))
	{

	goto case 27;	}else
	{

	s1 = -1;
return;	}
	case 27:
	UnityEngine.Debug.Log(___a12.Head());
	ActiveBoR = ___a12.Head();
	s1 = 28;
return;
	case 28:
	ActiveBoR = "";
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(((ActiveBoR) == ("Crossed Wrenches Red")))
	{

	goto case 33;	}else
	{

	s2 = -1;
return;	}
	case 33:
	___resourcelist20 = (

(new Cons<System.String>("Medipack Red",(new Cons<System.String>("Battery Black",(new Cons<System.String>("Jerry Can Green",(new Empty<System.String>()).ToList<System.String>())).ToList<System.String>())).ToList<System.String>())).ToList<System.String>()).ToList<System.String>();
	___rnd20 = UnityEngine.Random.Range(0,3);
	ActiveBoR = (___resourcelist20)[___rnd20];
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	___zmbies30 = (

(Zombies).Select(__ContextSymbol17 => new { ___a33 = __ContextSymbol17 })
.Where(__ContextSymbol18 => ((__ContextSymbol18.___a33.Destroyed) == (false)))
.Select(__ContextSymbol19 => __ContextSymbol19.___a33)
.ToList<Zombie>()).ToList<Zombie>();
	Zombies = ___zmbies30;
	s3 = -1;
return;	
	default: return;}}
	

	int s4=-1;
	public void Rule4(float dt, World world){ 
	switch (s4)
	{

	case -1:
	___groups40 = (

(Landscapes).Select(__ContextSymbol20 => new { ___a44 = __ContextSymbol20 })
.SelectMany(__ContextSymbol21=> (__ContextSymbol21.___a44.Group).Select(__ContextSymbol22 => new { ___b42 = __ContextSymbol22,
                                                      prev = __ContextSymbol21 })
.Select(__ContextSymbol23 => __ContextSymbol23.___b42)
.ToList<GroupZombie>())).ToList<GroupZombie>();
	___zombiegroup40 = (

(___groups40).Select(__ContextSymbol24 => new { ___a45 = __ContextSymbol24 })
.SelectMany(__ContextSymbol25=> (__ContextSymbol25.___a45.ZombieFollowers).Select(__ContextSymbol26 => new { ___c41 = __ContextSymbol26,
                                                      prev = __ContextSymbol25 })
.Select(__ContextSymbol27 => __ContextSymbol27.___c41)
.ToList<Zombie>())).ToList<Zombie>();
	___groupleader40 = (

(___groups40).Select(__ContextSymbol28 => new { ___a46 = __ContextSymbol28 })
.Where(__ContextSymbol29 => __ContextSymbol29.___a46.ZombieLeader.IsSome)
.Select(__ContextSymbol30 => new {___z40 = __ContextSymbol30.___a46.ZombieLeader.Value, prev = __ContextSymbol30 })
.Select(__ContextSymbol31 => __ContextSymbol31.___z40)
.ToList<Zombie>()).ToList<Zombie>();
	___group40 = (___groupleader40).Concat(___zombiegroup40).ToList<Zombie>();
	if(((___group40.Count) > (0)))
	{

	goto case 3;	}else
	{

	s4 = -1;
return;	}
	case 3:
	Zombies = (___group40).Concat(Zombies).ToList<Zombie>();
	s4 = -1;
return;	
	default: return;}}
	

	int s5=-1;
	public void Rule5(float dt, World world){ 
	switch (s5)
	{

	case -1:
	Score = ((Score) + (1));
	s5 = -1;
return;	
	default: return;}}
	

	int s6=-1;
	public void Rule6(float dt, World world){ 
	switch (s6)
	{

	case -1:
	___j60 = (

(Gasstations).Select(__ContextSymbol32 => new { ___a67 = __ContextSymbol32 })
.Where(__ContextSymbol33 => __ContextSymbol33.___a67.RepairZonE.Refill_Resources)
.Select(__ContextSymbol34 => __ContextSymbol34.___a67)
.ToList<Gasstation>()).ToList<Gasstation>();
	if(((___j60.Count) > (0)))
	{

	___t60 = true;	}else
	{

	___t60 = false;	}
	if(___t60)
	{

	goto case 1;	}else
	{

	goto case 2;	}
	case 1:
	W_Refill_Resources = true;
	s6 = -1;
return;
	case 2:
	W_Refill_Resources = false;
	s6 = -1;
return;	
	default: return;}}
	

	int s7=-1;
	public void Rule7(float dt, World world){ 
	switch (s7)
	{

	case -1:
	count_down3 = 0.5f;
	goto case 18;
	case 18:
	if(((count_down3) > (0f)))
	{

	count_down3 = ((count_down3) - (dt));
	s7 = 18;
return;	}else
	{

	goto case 16;	}
	case 16:
	___x70 = (

(Landscapes).Select(__ContextSymbol35 => new { ___a78 = __ContextSymbol35 })
.Where(__ContextSymbol36 => ((UnityEngine.Vector3.Distance(__ContextSymbol36.___a78.Position,Jeep.Value.Position)) > (400)))
.Select(__ContextSymbol37 => __ContextSymbol37.___a78)
.ToList<Landscape>()).ToList<Landscape>();
	UnityEngine.Debug.Log(("landscapes = ") + (___x70.Count));
	if(((___x70.Count) > (0)))
	{

	goto case 0;	}else
	{

	goto case 1;	}
	case 0:
	___q70 = (

(Landscapes).Select(__ContextSymbol38 => new { ___a79 = __ContextSymbol38 })
.Where(__ContextSymbol39 => ((400) > (UnityEngine.Vector3.Distance(__ContextSymbol39.___a79.Position,Jeep.Value.Position))))
.Select(__ContextSymbol40 => __ContextSymbol40.___a79)
.ToList<Landscape>()).ToList<Landscape>();
	___g70 = ___x70.Head().transform;
	___j71 = new ZombieGroupDestroyer(___g70.position.z,Jeep.Value.Position);
	ZombiegroupDest = (new Just<ZombieGroupDestroyer>(___j71));
	Landscapes = ___q70;
	s7 = 4;
return;
	case 4:
	count_down1 = dt;
	goto case 5;
	case 5:
	if(((count_down1) > (0f)))
	{

	count_down1 = ((count_down1) - (dt));
	s7 = 5;
return;	}else
	{

	goto case 3;	}
	case 3:
	ZombiegroupDest = (new Nothing<ZombieGroupDestroyer>());
	Landscapes = Landscapes;
	s7 = -1;
return;
	case 1:
	___z71 = new ZombieGroupDestroyer(10f,Jeep.Value.Position);
	ZombiegroupDest = (new Just<ZombieGroupDestroyer>(___z71));
	Landscapes = Landscapes;
	s7 = 11;
return;
	case 11:
	count_down2 = dt;
	goto case 12;
	case 12:
	if(((count_down2) > (0f)))
	{

	count_down2 = ((count_down2) - (dt));
	s7 = 12;
return;	}else
	{

	goto case 10;	}
	case 10:
	ZombiegroupDest = (new Nothing<ZombieGroupDestroyer>());
	Landscapes = Landscapes;
	s7 = -1;
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
public class TruckStats{
public int frame;
public bool JustEntered = true;
private System.Boolean bs;
private List<System.Int32> sts;
	public int ID;
public TruckStats(System.Boolean bs, List<System.Int32> sts)
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
		List<System.Int32> ___NotInMagList00;
		___NotInMagList00 = (

(new Cons<System.Int32>(850,(new Cons<System.Int32>(200,(new Cons<System.Int32>(60,(new Cons<System.Int32>(90,(new Cons<System.Int32>(16,(new Empty<System.Int32>()).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>()).ToList<System.Int32>();
		isModel = bs;
		TypeWeapon = sts;
		MaxSteering = ___MaxSteeringList00[___rnd01];
		MaxSpeed = ___MaxSpeedList00[___rnd01];
		Hull = ___HullList00[___rnd01];
		Health = ___HealthList00[___rnd01];
		Fuel = ___FuelList00[___rnd01];
		AmountOfGunsInTruck = 0;
		
}
		public System.Int32 AmountOfGunsInTruck;
	public System.Single Fuel;
	public System.Single Health;
	public System.Single Hull;
	public System.Single MaxSpeed;
	public System.Single MaxSteering;
	public List<System.Int32> TypeWeapon;
	public System.Boolean isModel;
	public System.Single ___z02;
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
	if(!(((isModel) == (true))))
	{

	goto case 20;	}else
	{

	s0 = -1;
return;	}
	case 20:
	___z02 = world.Jeep.Value.CarHP2;
	if(!(((___z02) == (((Health) / (100f))))))
	{

	goto case 21;	}else
	{

	goto case 22;	}
	case 21:
	world.Jeep.Value.CarHP2 = world.Jeep.Value.CarHP2;
	Health = ((world.Jeep.Value.CarHP2) * (100f));
	world.GUIpanel.HPValue = world.Jeep.Value.CarHP2;
	s0 = -1;
return;
	case 22:
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

	goto case 28;	}else
	{

	s1 = -1;
return;	}
	case 28:
	Health = ((Health) + (20f));
	world.Jeep.Value.CarHP2 = ((Health) / (100f));
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	AmountOfGunsInTruck = TypeWeapon.Count;
	s2 = -1;
return;	
	default: return;}}
	





}
public class Truck{
public int frame;
public bool JustEntered = true;
private System.String nm;
private UnityEngine.Vector3 pos;
private System.Boolean ModelIs;
private List<System.Int32> ints;
	public int ID;
public Truck(System.String nm, UnityEngine.Vector3 pos, System.Boolean ModelIs, List<System.Int32> ints)
	{JustEntered = false;
 frame = World.frame;
		maxSteeringAngle = 50f;
		maxMotorTorque = 250f;
		isModel = ModelIs;
		cnvAccel = 0f;
		TruckScript = TruckScript.Instantiate(nm,pos);
		Stats = new TruckStats(ModelIs,ints);
		Keyboard = false;
		JRotation = 0f;
		Fuel = 80000f;
		AxleInfos = (

Enumerable.Empty<AxleInfo>()).ToList<AxleInfo>();
		
}
		public System.Single Acceleration{  get { return TruckScript.Acceleration; }
 }
	public UnityEngine.AudioClip Audio_DamageBig{  get { return TruckScript.Audio_DamageBig; }
  set{TruckScript.Audio_DamageBig = value; }
 }
	public UnityEngine.AudioClip Audio_DamageSmall{  get { return TruckScript.Audio_DamageSmall; }
  set{TruckScript.Audio_DamageSmall = value; }
 }
	public UnityEngine.AudioClip Audio_Driving{  get { return TruckScript.Audio_Driving; }
  set{TruckScript.Audio_Driving = value; }
 }
	public List<AxleInfo> AxleInfos;
	public System.Single BrakeAndReverse{  get { return TruckScript.BrakeAndReverse; }
 }
	public UnityEngine.Vector3 COM{  get { return TruckScript.COM; }
  set{TruckScript.COM = value; }
 }
	public System.Single CarHP2{  get { return TruckScript.CarHP2; }
  set{TruckScript.CarHP2 = value; }
 }
	public System.Single CarHPChanged{  get { return TruckScript.CarHPChanged; }
  set{TruckScript.CarHPChanged = value; }
 }
	public UnityEngine.Vector3 CenterOfMass{  get { return TruckScript.CenterOfMass; }
  set{TruckScript.CenterOfMass = value; }
 }
	public System.Boolean CollisionWithModel{  get { return TruckScript.CollisionWithModel; }
  set{TruckScript.CollisionWithModel = value; }
 }
	public System.Single Dama{  get { return TruckScript.Dama; }
  set{TruckScript.Dama = value; }
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
	public System.Boolean GameOver{  get { return TruckScript.GameOver; }
  set{TruckScript.GameOver = value; }
 }
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
	public UnityEngine.Vector3 InputPosition{  get { return TruckScript.InputPosition; }
 }
	public System.Boolean Invullen{  get { return TruckScript.Invullen; }
  set{TruckScript.Invullen = value; }
 }
	public System.Single JRotation;
	public System.Boolean Keyboard;
	public UnityEngine.Vector3 Position{  get { return TruckScript.Position; }
 }
	public UnityEngine.Vector3 PrevVelocity{  get { return TruckScript.PrevVelocity; }
  set{TruckScript.PrevVelocity = value; }
 }
	public UnityEngine.WheelCollider RearLeftWheel{  get { return TruckScript.RearLeftWheel; }
  set{TruckScript.RearLeftWheel = value; }
 }
	public UnityEngine.WheelCollider RearRightWheel{  get { return TruckScript.RearRightWheel; }
  set{TruckScript.RearRightWheel = value; }
 }
	public UnityEngine.Quaternion Rotation{  get { return TruckScript.Rotation; }
 }
	public System.Single RotationY{  get { return TruckScript.RotationY; }
 }
	public System.String Score{  get { return TruckScript.Score; }
  set{TruckScript.Score = value; }
 }
	public TruckStats Stats;
	public System.Single Steering{  get { return TruckScript.Steering; }
 }
	public UnityEngine.Vector3 Trque{  set{TruckScript.Trque = value; }
 }
	public TruckScript TruckScript;
	public System.Single cnvAccel;
	public System.Single driv{  get { return TruckScript.driv; }
  set{TruckScript.driv = value; }
 }
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
	public System.Single tim{  get { return TruckScript.tim; }
  set{TruckScript.tim = value; }
 }
	public UnityEngine.Transform transform{  get { return TruckScript.transform; }
 }
	public UnityEngine.Rigidbody truckRigidBody{  get { return TruckScript.truckRigidBody; }
  set{TruckScript.truckRigidBody = value; }
 }
	public System.Boolean useGUILayout{  get { return TruckScript.useGUILayout; }
  set{TruckScript.useGUILayout = value; }
 }
	public System.Single count_down8;
	public System.Single count_down7;
	public System.Single count_down6;
	public System.Single count_down5;
	public System.Single count_down4;
	public System.String ___j92;
	public System.Single count_down10;
	public System.Single count_down9;
	public System.Single ___a1310;
	public System.Single count_down11;
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
		this.Rule8(dt, world);
		this.Rule9(dt, world);
		this.Rule10(dt, world);
		this.Rule11(dt, world);
		this.Rule12(dt, world);
		this.Rule13(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	AxleInfos = (

(new Cons<AxleInfo>(new AxleInfo(FrontLeftWheel,FrontRightWheel,true,true),(new Cons<AxleInfo>(new AxleInfo(RearLeftWheel,RearRightWheel,true,false),(new Empty<AxleInfo>()).ToList<AxleInfo>())).ToList<AxleInfo>())).ToList<AxleInfo>()).ToList<AxleInfo>();
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
	if(!(isModel))
	{

	goto case 3;	}else
	{

	s1 = -1;
return;	}
	case 3:
	if(((world.ActiveBoR) == ("Jerry Can Green")))
	{

	goto case 5;	}else
	{

	s1 = -1;
return;	}
	case 5:
	UnityEngine.Debug.Log(("Fuel = ") + (Fuel));
	Fuel = ((Fuel) + (2000f));
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(!(world.W_Refill_Resources))
	{

	s2 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Fuel = 80000f;
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	if(!(!(((Invullen) == (true)))))
	{

	s3 = -1;
return;	}else
	{

	goto case 2;	}
	case 2:
	if(Keyboard)
	{

	goto case 0;	}else
	{

	goto case 1;	}
	case 0:
	JRotation = UnityEngine.Input.GetAxis("Horizontal");
	s3 = -1;
return;
	case 1:
	JRotation = Steering;
	s3 = -1;
return;	
	default: return;}}
	

	int s4=-1;
	public void Rule4(float dt, World world){ 
	switch (s4)
	{

	case -1:
	if(!(!(((Invullen) == (true)))))
	{

	s4 = -1;
return;	}else
	{

	goto case 2;	}
	case 2:
	if(Keyboard)
	{

	goto case 0;	}else
	{

	goto case 1;	}
	case 0:
	cnvAccel = UnityEngine.Input.GetAxis("Vertical");
	world.Score = world.Score;
	s4 = -1;
return;
	case 1:
	if(!(((Acceleration) == (0f))))
	{

	goto case 4;	}else
	{

	goto case 5;	}
	case 4:
	cnvAccel = Acceleration;
	world.Score = ((world.Score) + (2));
	s4 = -1;
return;
	case 5:
	cnvAccel = ((BrakeAndReverse) * (-1f));
	world.Score = world.Score;
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
	world.Score = ((world.Score) + (20));
	s5 = -1;
return;	
	default: return;}}
	

	int s6=-1;
	public void Rule6(float dt, World world){ 
	switch (s6)
	{

	case -1:
	if(!(!(((Invullen) == (false)))))
	{

	s6 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	HeadlightLeftOn = false;
	HeadlightRightOn = false;
	cnvAccel = 0f;
	JRotation = 0f;
	s6 = -1;
return;	
	default: return;}}
	

	int s7=-1;
	public void Rule7(float dt, World world){ 
	switch (s7)
	{

	case -1:
	if(!(!(((Invullen) == (true)))))
	{

	s7 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	if(((world.ActiveBoR) == ("Lightning Blue")))
	{

	goto case 1;	}else
	{

	s7 = -1;
return;	}
	case 1:
	HeadlightLeftOn = true;
	HeadlightRightOn = true;
	world.Score = ((world.Score) + (100));
	s7 = 15;
return;
	case 15:
	count_down8 = 5f;
	goto case 16;
	case 16:
	if(((count_down8) > (0f)))
	{

	count_down8 = ((count_down8) - (dt));
	s7 = 16;
return;	}else
	{

	goto case 14;	}
	case 14:
	HeadlightLeftOn = false;
	HeadlightRightOn = false;
	world.Score = world.Score;
	s7 = 12;
return;
	case 12:
	count_down7 = 0.2f;
	goto case 13;
	case 13:
	if(((count_down7) > (0f)))
	{

	count_down7 = ((count_down7) - (dt));
	s7 = 13;
return;	}else
	{

	goto case 11;	}
	case 11:
	HeadlightLeftOn = true;
	HeadlightRightOn = true;
	world.Score = world.Score;
	s7 = 9;
return;
	case 9:
	count_down6 = 0.1f;
	goto case 10;
	case 10:
	if(((count_down6) > (0f)))
	{

	count_down6 = ((count_down6) - (dt));
	s7 = 10;
return;	}else
	{

	goto case 8;	}
	case 8:
	HeadlightLeftOn = false;
	HeadlightRightOn = false;
	world.Score = world.Score;
	s7 = 6;
return;
	case 6:
	count_down5 = 0.3f;
	goto case 7;
	case 7:
	if(((count_down5) > (0f)))
	{

	count_down5 = ((count_down5) - (dt));
	s7 = 7;
return;	}else
	{

	goto case 5;	}
	case 5:
	HeadlightLeftOn = true;
	HeadlightRightOn = true;
	world.Score = world.Score;
	s7 = 3;
return;
	case 3:
	count_down4 = 0.1f;
	goto case 4;
	case 4:
	if(((count_down4) > (0f)))
	{

	count_down4 = ((count_down4) - (dt));
	s7 = 4;
return;	}else
	{

	goto case 2;	}
	case 2:
	HeadlightLeftOn = false;
	HeadlightRightOn = false;
	world.Score = world.Score;
	s7 = -1;
return;	
	default: return;}}
	

	int s8=-1;
	public void Rule8(float dt, World world){ 
	switch (s8)
	{

	case -1:
	PrevVelocity = truckRigidBody.velocity;
	s8 = -1;
return;	
	default: return;}}
	

	int s9=-1;
	public void Rule9(float dt, World world){ 
	switch (s9)
	{

	case -1:
	___j92 = (("") + (world.Score));
	Score = ___j92;
	s9 = 0;
return;
	case 0:
	if(!(!(((GameOver) == (true)))))
	{

	s9 = 0;
return;	}else
	{

	s9 = -1;
return;	}	
	default: return;}}
	

	int s10=-1;
	public void Rule10(float dt, World world){ 
	switch (s10)
	{

	case -1:
	if(!(((1) > (Stats.Health))))
	{

	s10 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	GameOver = true;
	s10 = 0;
return;
	case 0:
	if(!(false))
	{

	s10 = 0;
return;	}else
	{

	s10 = -1;
return;	}	
	default: return;}}
	

	int s11=-1;
	public void Rule11(float dt, World world){ 
	switch (s11)
	{

	case -1:
	if(!(GameOver))
	{

	s11 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	Invullen = true;
	s11 = 0;
return;
	case 0:
	if(!(false))
	{

	s11 = 0;
return;	}else
	{

	s11 = -1;
return;	}	
	default: return;}}
	

	int s12=-1;
	public void Rule12(float dt, World world){ 
	switch (s12)
	{

	case -1:
	if(((Keyboard) && (((0.5f) > (Dama)))))
	{

	goto case 9;	}else
	{

	goto case 3;	}
	case 9:
	driv = 1f;
	s12 = 10;
return;
	case 10:
	count_down10 = tim;
	goto case 11;
	case 11:
	if(((count_down10) > (0f)))
	{

	count_down10 = ((count_down10) - (dt));
	s12 = 11;
return;	}else
	{

	s12 = 3;
return;	}
	case 3:
	if(((Dama) > (0.5f)))
	{

	goto case 4;	}else
	{

	s12 = -1;
return;	}
	case 4:
	count_down9 = tim;
	goto case 7;
	case 7:
	if(((count_down9) > (0f)))
	{

	count_down9 = ((count_down9) - (dt));
	s12 = 7;
return;	}else
	{

	goto case 5;	}
	case 5:
	driv = 0f;
	s12 = -1;
return;	
	default: return;}}
	

	int s13=-1;
	public void Rule13(float dt, World world){ 
	switch (s13)
	{

	case -1:
	___a1310 = CarHPChanged;
	if(!(((___a1310) == (0f))))
	{

	goto case 14;	}else
	{

	s13 = -1;
return;	}
	case 14:
	Dama = 0f;
	driv = 0.5f;
	s13 = 15;
return;
	case 15:
	count_down11 = tim;
	goto case 16;
	case 16:
	if(((count_down11) > (0f)))
	{

	count_down11 = ((count_down11) - (dt));
	s13 = 16;
return;	}else
	{

	s13 = -1;
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
	public System.Single ___dir00;
	public System.Single ___speed00;
	public System.Single count_down12;
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

	goto case 20;	}else
	{

	s0 = -1;
return;	}
	case 20:
	if(((world.Jeep.Value.Fuel) > (0.99f)))
	{

	goto case 21;	}else
	{

	goto case 22;	}
	case 21:
	if(((!(((world.Jeep.Value.cnvAccel) == (0f)))) && (((leftWheel.isGrounded) || (rightWheel.isGrounded)))))
	{

	goto case 24;	}else
	{

	goto case 25;	}
	case 24:
	___dir00 = world.Jeep.Value.cnvAccel;
	___speed00 = ((((world.Jeep.Value.maxMotorTorque) * (world.Jeep.Value.cnvAccel))) * (-1f));
	if(((world.ActiveBoR) == ("Arrows Green")))
	{

	goto case 27;	}else
	{

	goto case 28;	}
	case 27:
	leftWheel.motorTorque = leftWheel.motorTorque;
	rightWheel.motorTorque = rightWheel.motorTorque;
	world.Jeep.Value.Fuel = world.Jeep.Value.Fuel;
	s0 = 31;
return;
	case 31:
	if(!(((!(((world.Jeep.Value.cnvAccel) == (___dir00)))) || (true))))
	{

	s0 = 31;
return;	}else
	{

	goto case 30;	}
	case 30:
	if(!(((world.Jeep.Value.cnvAccel) == (___dir00))))
	{

	goto case 32;	}else
	{

	if(true)
	{

	goto case 33;	}else
	{

	s0 = 30;
return;	}	}
	case 32:
	leftWheel.motorTorque = ___speed00;
	rightWheel.motorTorque = ___speed00;
	world.Jeep.Value.Fuel = ((world.Jeep.Value.Fuel) - (1f));
	s0 = -1;
return;
	case 33:
	leftWheel.motorTorque = ((___speed00) * (10f));
	rightWheel.motorTorque = ((___speed00) * (10f));
	world.Jeep.Value.Fuel = world.Jeep.Value.Fuel;
	s0 = 35;
return;
	case 35:
	count_down12 = 2f;
	goto case 36;
	case 36:
	if(((count_down12) > (0f)))
	{

	count_down12 = ((count_down12) - (dt));
	s0 = 36;
return;	}else
	{

	s0 = -1;
return;	}
	case 28:
	leftWheel.motorTorque = ___speed00;
	rightWheel.motorTorque = ___speed00;
	world.Jeep.Value.Fuel = ((world.Jeep.Value.Fuel) - (1f));
	s0 = -1;
return;
	case 25:
	leftWheel.motorTorque = 0f;
	rightWheel.motorTorque = 0f;
	world.Jeep.Value.Fuel = world.Jeep.Value.Fuel;
	s0 = -1;
return;
	case 22:
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
public class Gasstation{
public int frame;
public bool JustEntered = true;
private UnityEngine.Vector3 ps;
	public int ID;
public Gasstation(UnityEngine.Vector3 ps)
	{JustEntered = false;
 frame = World.frame;
		ZombieSpawnpoints = (

Enumerable.Empty<UnityEngine.Transform>()).ToList<UnityEngine.Transform>();
		UnityGasstation = UnityGasstation.Instantiate(ps);
		RepairZonE = new Repair();
		GroupZombies = (

Enumerable.Empty<GroupZombie>()).ToList<GroupZombie>();
		Counter = 0;
		
}
		public System.Int32 Counter;
	public System.Boolean Destroyed{  get { return UnityGasstation.Destroyed; }
  set{UnityGasstation.Destroyed = value; }
 }
	public List<GroupZombie> GroupZombies;
	public UnityEngine.Vector3 Position{  get { return UnityGasstation.Position; }
 }
	public Repair RepairZonE;
	public UnityEngine.Light RepairZone{  get { return UnityGasstation.RepairZone; }
  set{UnityGasstation.RepairZone = value; }
 }
	public System.Collections.Generic.List<UnityEngine.Transform> SP2{  get { return UnityGasstation.SP2; }
  set{UnityGasstation.SP2 = value; }
 }
	public UnityGasstation UnityGasstation;
	public List<UnityEngine.Transform> ZombieSpawnpoints;
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
	public UnityEngine.GameObject modely{  get { return UnityGasstation.modely; }
  set{UnityGasstation.modely = value; }
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
	public UnityEngine.Vector3 ___pos10;
	public Truck ___newt10;
	public List<UnityEngine.Transform> ___x21;
	public UnityEngine.Transform ___zsp30;
	public UnityEngine.Vector3 ___t31;
	public List<GroupZombie> ___newZ30;
	public System.Single count_down13;
	public void Update(float dt, World world) {
frame = World.frame;

		for(int x0 = 0; x0 < GroupZombies.Count; x0++) { 
			GroupZombies[x0].Update(dt, world);
		}
		RepairZonE.Update(dt, world);
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
	world.Jeep.Value.CollisionWithModel = world.Jeep.Value.CollisionWithModel;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(!(world.Jeep.Value.CollisionWithModel))
	{

	s1 = -1;
return;	}else
	{

	goto case 3;	}
	case 3:
	___pos10 = modely.transform.position;
	___newt10 = new Truck("zpickup",___pos10,false,(

(new Cons<System.Int32>(4,(new Cons<System.Int32>(2,(new Cons<System.Int32>(1,(new Cons<System.Int32>(3,(new Empty<System.Int32>()).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>()).ToList<System.Int32>());
	world.Jeep.Value.Destroyed = true;
	world.Jeep = (new Just<Truck>(___newt10));
	world.Jeep.Value.CollisionWithModel = false;
	Destroyed = true;
	s1 = 0;
return;
	case 0:
	world.Jeep.Value.Destroyed = world.Jeep.Value.Destroyed;
	world.Jeep = world.Jeep;
	world.Jeep.Value.CollisionWithModel = world.Jeep.Value.CollisionWithModel;
	Destroyed = Destroyed;
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	___x21 = (

(SP2).Select(__ContextSymbol55 => new { ___a211 = __ContextSymbol55 })
.Select(__ContextSymbol56 => __ContextSymbol56.___a211)
.ToList<UnityEngine.Transform>()).ToList<UnityEngine.Transform>();
	ZombieSpawnpoints = ___x21;
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
	if(!(((((ZombieSpawnpoints.Count) > (0))) && (((RepairZonE.RepairProgressBar.Value.pspeed) == (15))))))
	{

	s3 = -1;
return;	}else
	{

	goto case 2;	}
	case 2:
	if(!(((Counter) == (ZombieSpawnpoints.Count))))
	{

	goto case 0;	}else
	{

	goto case 1;	}
	case 0:
	___zsp30 = (ZombieSpawnpoints)[Counter];
	___t31 = ___zsp30.position;
	___newZ30 = (

(new Cons<GroupZombie>(new GroupZombie(___t31,2),(new Empty<GroupZombie>()).ToList<GroupZombie>())).ToList<GroupZombie>()).ToList<GroupZombie>();
	GroupZombies = (GroupZombies).Concat(___newZ30).ToList<GroupZombie>();
	Counter = ((Counter) + (1));
	s3 = 3;
return;
	case 3:
	count_down13 = 2f;
	goto case 4;
	case 4:
	if(((count_down13) > (0f)))
	{

	count_down13 = ((count_down13) - (dt));
	s3 = 4;
return;	}else
	{

	s3 = -1;
return;	}
	case 1:
	GroupZombies = GroupZombies;
	Counter = 0;
	s3 = -1;
return;	
	default: return;}}
	





}
public class Repair{
public int frame;
public bool JustEntered = true;
	public int ID;
public Repair()
	{JustEntered = false;
 frame = World.frame;
		UnityCheckpoint = UnityCheckpoint.Find();
		RepairProgressBar = (new Just<ProgressBar_1>(new ProgressBar_1(1)));
		Refill_Resources = false;
		
}
		public System.Boolean Refill_Resources;
	public Option<ProgressBar_1> RepairProgressBar;
	public UnityCheckpoint UnityCheckpoint;
	public System.Boolean enabled{  get { return UnityCheckpoint.enabled; }
  set{UnityCheckpoint.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityCheckpoint.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityCheckpoint.hideFlags; }
  set{UnityCheckpoint.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityCheckpoint.isActiveAndEnabled; }
 }
	public System.Boolean isEntered{  get { return UnityCheckpoint.isEntered; }
 }
	public System.String name{  get { return UnityCheckpoint.name; }
  set{UnityCheckpoint.name = value; }
 }
	public System.String tag{  get { return UnityCheckpoint.tag; }
  set{UnityCheckpoint.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityCheckpoint.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityCheckpoint.useGUILayout; }
  set{UnityCheckpoint.useGUILayout = value; }
 }
	public List<AxleInfo> ___axl10;
	public List<UnityEngine.WheelCollider> ___wheel10;
	public System.Boolean ___bo10;
	public void Update(float dt, World world) {
frame = World.frame;

if(RepairProgressBar.IsSome){ 		RepairProgressBar.Value.Update(dt, world);
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
	RepairProgressBar.Value.startprogress = false;
	RepairProgressBar.Value.pspeed = 101;
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
	if(!(world.Jeep.IsSome))
	{

	s1 = -1;
return;	}else
	{

	goto case 14;	}
	case 14:
	if(!(RepairProgressBar.IsSome))
	{

	s1 = 14;
return;	}else
	{

	goto case 13;	}
	case 13:
	___axl10 = world.Jeep.Value.AxleInfos;
	if(((___axl10.Count) > (0)))
	{

	goto case 1;	}else
	{

	s1 = -1;
return;	}
	case 1:
	___wheel10 = (

(___axl10).Select(__ContextSymbol58 => new { ___a112 = __ContextSymbol58 })
.Where(__ContextSymbol59 => __ContextSymbol59.___a112.motor)
.Select(__ContextSymbol60 => __ContextSymbol60.___a112.leftWheel)
.ToList<UnityEngine.WheelCollider>()).ToList<UnityEngine.WheelCollider>();
	if(((((-40f) > (___wheel10.Head().motorTorque))) || (((___wheel10.Head().motorTorque) > (40f)))))
	{

	___bo10 = false;	}else
	{

	___bo10 = true;	}
	if(((isEntered) && (___bo10)))
	{

	goto case 2;	}else
	{

	goto case 3;	}
	case 2:
	RepairProgressBar.Value.startprogress = true;
	RepairProgressBar.Value.pspeed = 15;
	s1 = -1;
return;
	case 3:
	if(isEntered)
	{

	goto case 6;	}else
	{

	goto case 7;	}
	case 6:
	RepairProgressBar.Value.startprogress = false;
	RepairProgressBar.Value.pspeed = 50;
	s1 = -1;
return;
	case 7:
	RepairProgressBar.Value.startprogress = false;
	RepairProgressBar.Value.pspeed = 40;
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(!(RepairProgressBar.IsSome))
	{

	s2 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	if(RepairProgressBar.Value.Finished)
	{

	goto case 1;	}else
	{

	s2 = -1;
return;	}
	case 1:
	UnityEngine.Debug.Log("finished all. add resources now");
	RepairProgressBar.Value.Destroyed = true;
	RepairProgressBar = (new Nothing<ProgressBar_1>());
	Refill_Resources = true;
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	if(!(!(((Refill_Resources) == (false)))))
	{

	s3 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	Refill_Resources = true;
	s3 = 0;
return;
	case 0:
	Refill_Resources = false;
	s3 = -1;
return;	
	default: return;}}
	





}
public class ProgressBar_1{
public int frame;
public bool JustEntered = true;
private System.Int32 j;
	public int ID;
public ProgressBar_1(System.Int32 j)
	{JustEntered = false;
 frame = World.frame;
		num = j;
		ProgressBarBehaviour = ProgressBar.ProgressBarBehaviour.Instantiate();
		
}
		public System.Boolean Destroyed{  get { return ProgressBarBehaviour.Destroyed; }
  set{ProgressBarBehaviour.Destroyed = value; }
 }
	public System.Boolean Finished{  get { return ProgressBarBehaviour.Finished; }
  set{ProgressBarBehaviour.Finished = value; }
 }
	public ProgressBar.ProgressBarBehaviour ProgressBarBehaviour;
	public System.Int32 ProgressSpeed{  get { return ProgressBarBehaviour.ProgressSpeed; }
  set{ProgressBarBehaviour.ProgressSpeed = value; }
 }
	public System.Single TransitoryValue{  get { return ProgressBarBehaviour.TransitoryValue; }
 }
	public System.Boolean TriggerOnComplete{  get { return ProgressBarBehaviour.TriggerOnComplete; }
  set{ProgressBarBehaviour.TriggerOnComplete = value; }
 }
	public System.Single Value{  get { return ProgressBarBehaviour.Value; }
  set{ProgressBarBehaviour.Value = value; }
 }
	public System.Boolean enabled{  get { return ProgressBarBehaviour.enabled; }
  set{ProgressBarBehaviour.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return ProgressBarBehaviour.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return ProgressBarBehaviour.hideFlags; }
  set{ProgressBarBehaviour.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return ProgressBarBehaviour.isActiveAndEnabled; }
 }
	public System.Boolean isDone{  get { return ProgressBarBehaviour.isDone; }
 }
	public System.Boolean isPaused{  get { return ProgressBarBehaviour.isPaused; }
 }
	public System.String name{  get { return ProgressBarBehaviour.name; }
  set{ProgressBarBehaviour.name = value; }
 }
	public System.Int32 num;
	public System.Int32 pspeed{  get { return ProgressBarBehaviour.pspeed; }
  set{ProgressBarBehaviour.pspeed = value; }
 }
	public System.Boolean startprogress{  get { return ProgressBarBehaviour.startprogress; }
  set{ProgressBarBehaviour.startprogress = value; }
 }
	public System.String tag{  get { return ProgressBarBehaviour.tag; }
  set{ProgressBarBehaviour.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return ProgressBarBehaviour.transform; }
 }
	public System.Boolean useGUILayout{  get { return ProgressBarBehaviour.useGUILayout; }
  set{ProgressBarBehaviour.useGUILayout = value; }
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

(Spawnpoints2).Select(__ContextSymbol67 => new { ___a013 = __ContextSymbol67 })
.Select(__ContextSymbol68 => __ContextSymbol68.___a013)
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

(new Cons<GroupZombie>(new GroupZombie(___sps_pos10,7),(new Empty<GroupZombie>()).ToList<GroupZombie>())).ToList<GroupZombie>()).ToList<GroupZombie>();
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

(new Cons<GroupZombie>(new GroupZombie(___sps_pos110,7),(new Empty<GroupZombie>()).ToList<GroupZombie>())).ToList<GroupZombie>()).ToList<GroupZombie>();
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
	___p010 = ((BARpos) + (new UnityEngine.Vector3(0f,1f,0f)));
	___p110 = ((BARpos) - (new UnityEngine.Vector3(2f,-1f,0f)));
	___p210 = ((BARpos) + (new UnityEngine.Vector3(2f,1f,0f)));
	___p310 = ((BARpos) - (new UnityEngine.Vector3(4f,-1f,0f)));
	___plist10 = (

(new Cons<UnityEngine.Vector3>(___p010,(new Cons<UnityEngine.Vector3>(___p110,(new Cons<UnityEngine.Vector3>(___p210,(new Cons<UnityEngine.Vector3>(___p310,(new Empty<UnityEngine.Vector3>()).ToList<UnityEngine.Vector3>())).ToList<UnityEngine.Vector3>())).ToList<UnityEngine.Vector3>())).ToList<UnityEngine.Vector3>())).ToList<UnityEngine.Vector3>()).ToList<UnityEngine.Vector3>();
	___Slist10 = Shuffled;
	___BAR10 = (

(Enumerable.Range(0,(1) + ((3) - (0))).ToList<System.Int32>()).Select(__ContextSymbol79 => new { ___a114 = __ContextSymbol79 })
.Select(__ContextSymbol80 => new BonusAndResource(___plist10[__ContextSymbol80.___a114],___Slist10[__ContextSymbol80.___a114]))
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

(BonusAndResources).Select(__ContextSymbol81 => new { ___a215 = __ContextSymbol81 })
.Where(__ContextSymbol82 => ((__ContextSymbol82.___a215.Destroyed) == (false)))
.Select(__ContextSymbol83 => __ContextSymbol83.___a215)
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
public class Player{
public int frame;
public bool JustEntered = true;
private System.Int32 id;
	public int ID;
public Player(System.Int32 id)
	{JustEntered = false;
 frame = World.frame;
		Num = id;
		Equip = new Equipment();
		Controllers = (

(new Cons<ControllerRazor>(new ControllerRazor("Hydra1 - Right"),(new Cons<ControllerRazor>(new ControllerRazor("Hydra1 - Left"),(new Empty<ControllerRazor>()).ToList<ControllerRazor>())).ToList<ControllerRazor>())).ToList<ControllerRazor>()).ToList<ControllerRazor>();
		
}
		public List<ControllerRazor> Controllers;
	public Equipment Equip;
	public System.Int32 Num;
	public void Update(float dt, World world) {
frame = World.frame;

		Equip.Update(dt, world);


	}











}
public class Equipment{
public int frame;
public bool JustEntered = true;
	public int ID;
public Equipment()
	{JustEntered = false;
 frame = World.frame;
		UnityEquipment = UnityEquipment.Instantiate();
		NotActiveGuns = (

Enumerable.Empty<Gun>()).ToList<Gun>();
		NotActiveFlashs = (

Enumerable.Empty<Light>()).ToList<Light>();
		LightControllerPressed = (new Nothing<Light>());
		GunControllerPressed = (new Nothing<Gun>());
		AllGuns = (

Enumerable.Empty<Gun>()).ToList<Gun>();
		AllFlashs = (

Enumerable.Empty<Light>()).ToList<Light>();
		AllAmmo = (

Enumerable.Empty<Ammo>()).ToList<Ammo>();
		ActiveGuns = (

Enumerable.Empty<Gun>()).ToList<Gun>();
		ActiveFlashs = (

Enumerable.Empty<Light>()).ToList<Light>();
		
}
		public List<Light> ActiveFlashs;
	public List<Gun> ActiveGuns;
	public List<Ammo> AllAmmo;
	public List<Light> AllFlashs;
	public List<Gun> AllGuns;
	public System.Collections.Generic.List<Casanova.Prelude.Tuple<System.Int32,System.Int32>> Ammos{  get { return UnityEquipment.Ammos; }
 }
	public Option<Gun> GunControllerPressed;
	public System.Collections.Generic.List<System.String> HL{  get { return UnityEquipment.HL; }
  set{UnityEquipment.HL = value; }
 }
	public System.Collections.Generic.List<System.String> HR{  get { return UnityEquipment.HR; }
  set{UnityEquipment.HR = value; }
 }
	public Option<Light> LightControllerPressed;
	public List<Light> NotActiveFlashs;
	public List<Gun> NotActiveGuns;
	public UnityEngine.Vector3 Position{  get { return UnityEquipment.Position; }
  set{UnityEquipment.Position = value; }
 }
	public UnityEngine.Transform TransformHL{  get { return UnityEquipment.TransformHL; }
  set{UnityEquipment.TransformHL = value; }
 }
	public UnityEngine.Transform TransformHR{  get { return UnityEquipment.TransformHR; }
  set{UnityEquipment.TransformHR = value; }
 }
	public UnityEquipment UnityEquipment;
	public System.Collections.Generic.List<System.String> asdf{  set{UnityEquipment.asdf = value; }
 }
	public System.Boolean enabled{  get { return UnityEquipment.enabled; }
  set{UnityEquipment.enabled = value; }
 }
	public UnityEngine.Transform flashL{  get { return UnityEquipment.flashL; }
  set{UnityEquipment.flashL = value; }
 }
	public UnityEngine.Transform flashR{  get { return UnityEquipment.flashR; }
  set{UnityEquipment.flashR = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityEquipment.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityEquipment.hideFlags; }
  set{UnityEquipment.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityEquipment.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityEquipment.name; }
  set{UnityEquipment.name = value; }
 }
	public System.Collections.Generic.List<System.Boolean> sap{  set{UnityEquipment.sap = value; }
 }
	public System.String tag{  get { return UnityEquipment.tag; }
  set{UnityEquipment.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityEquipment.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityEquipment.useGUILayout; }
  set{UnityEquipment.useGUILayout = value; }
 }
	public List<Ammo> ___j03;
	public List<ControllerRazor> ___pl10;
	public List<System.String> ___j14;
	public List<Gun> ___x12;
	public List<Gun> ___y10;
	public List<System.Int32> ___AcCount10;
	public List<System.Int32> ___ac10;
	public List<Gun> ___AllGunslist10;
	public List<System.String> ___z13;
	public List<Light> ___NAF10;
	public List<Gun> ___AG10;
	public List<Gun> ___NotAG10;
	public List<System.String> ___fdsa10;
	public List<System.String> ___gunhand10;
	public List<Gun> ___AG11;
	public List<Gun> ___NotAG11;
	public List<System.String> ___z14;
	public List<Light> ___AF10;
	public List<Light> ___NAF11;
	public List<Light> ___AllF10;
	public List<System.String> ___fdsa11;
	public List<Gun> ___AG12;
	public List<Gun> ___NotAG12;
	public List<Light> ___AF11;
	public List<Light> ___NAF12;
	public List<Light> ___AllF11;
	public List<System.String> ___fdsa12;
	public List<Gun> ___q21;
	public List<Light> ___j25;
	public System.String ___Joystickname30;
	public System.String ___Operation30;
	public System.Int32 ___GunNumber30;
	public List<Gun> ___OldActiveGun30;
	public List<Light> ___OldActiveFlash30;
	public List<Gun> ___changingjoystick30;
	public System.Int32 ___Listsize30;
	public List<Light> ___changingLight30;
	public Light ___NewActiveFlash30;
	public System.Int32 ___nextGunNumber30;
	public List<Gun> ___check30;
	public System.Int32 ___othernumber30;
	public List<Gun> ___newActiveGun30;
	public List<Gun> ___newActiveGun31;
	public System.Int32 ___prevGunNumber30;
	public List<Gun> ___check31;
	public System.Int32 ___othernumber31;
	public List<Gun> ___newActiveGun32;
	public List<Gun> ___newActiveGun33;
	public List<Light> ___changingjoystick31;
	public List<System.Int32> ___currActiveGunNumber30;
	public List<Gun> ___newActiveGun34;
	public List<Gun> ___NAG30;
	public List<Gun> ___r40;
	public List<System.String> ___fdsa43;
	public List<Light> ___j56;
	public List<Light> ___rig50;
	public System.Boolean ___right50;
	public List<Light> ___lef50;
	public System.Boolean ___left50;
	public void Update(float dt, World world) {
frame = World.frame;

		for(int x0 = 0; x0 < ActiveFlashs.Count; x0++) { 
			ActiveFlashs[x0].Update(dt, world);
		}
		for(int x0 = 0; x0 < ActiveGuns.Count; x0++) { 
			ActiveGuns[x0].Update(dt, world);
		}
if(GunControllerPressed.IsSome){ 		GunControllerPressed.Value.Update(dt, world);
 } 
if(LightControllerPressed.IsSome){ 		LightControllerPressed.Value.Update(dt, world);
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
	___j03 = (

(Ammos).Select(__ContextSymbol100 => new { ___a016 = __ContextSymbol100 })
.Select(__ContextSymbol101 => new Ammo(__ContextSymbol101.___a016.Item1,__ContextSymbol101.___a016.Item2))
.ToList<Ammo>()).ToList<Ammo>();
	AllAmmo = ___j03;
	s0 = 0;
return;
	case 0:
	if(!(world.W_Refill_Resources))
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
	___pl10 = world.Players.Head().Controllers;
	___j14 = (

(new Cons<System.String>(TransformHR.name,(new Cons<System.String>(TransformHL.name,(new Empty<System.String>()).ToList<System.String>())).ToList<System.String>())).ToList<System.String>()).ToList<System.String>();
	___x12 = (

(Enumerable.Range(0,(1) + (((HR.Count) - (1)) - (0))).ToList<System.Int32>()).Select(__ContextSymbol103 => new { ___a117 = __ContextSymbol103 })
.Select(__ContextSymbol104 => new Gun(__ContextSymbol104.___a117,___pl10.Head(),___j14.Head(),AllAmmo[__ContextSymbol104.___a117]))
.ToList<Gun>()).ToList<Gun>();
	___y10 = (

(Enumerable.Range(0,(1) + (((HL.Count) - (1)) - (0))).ToList<System.Int32>()).Select(__ContextSymbol105 => new { ___a118 = __ContextSymbol105 })
.Select(__ContextSymbol106 => new Gun(__ContextSymbol106.___a118,___pl10[1],___j14[1],AllAmmo[__ContextSymbol106.___a118]))
.ToList<Gun>()).ToList<Gun>();
	___AcCount10 = (

(ActiveGuns).Select(__ContextSymbol107 => new { ___a119 = __ContextSymbol107 })
.Select(__ContextSymbol108 => __ContextSymbol108.___a119.GunNumber)
.ToList<System.Int32>()).ToList<System.Int32>();
	if(!(((___AcCount10.Count) == (0))))
	{

	___ac10 = ___AcCount10;	}else
	{

	___ac10 = (

Enumerable.Empty<System.Int32>()).ToList<System.Int32>();	}
	___AllGunslist10 = (___x12).Concat(___y10).ToList<Gun>();
	if(((___ac10.Count) == (2)))
	{

	goto case 25;	}else
	{

	goto case 5;	}
	case 25:
	UnityEngine.Debug.Log("2 guns");
	___z13 = (

(new Cons<System.String>(flashL.name,(new Cons<System.String>(flashR.name,(new Empty<System.String>()).ToList<System.String>())).ToList<System.String>())).ToList<System.String>()).ToList<System.String>();
	___NAF10 = (

(new Cons<Light>(new Light(___pl10[0]),(new Cons<Light>(new Light(___pl10[1]),(new Empty<Light>()).ToList<Light>())).ToList<Light>())).ToList<Light>()).ToList<Light>();
	___AG10 = (

(new Cons<Gun>(___AllGunslist10[___ac10.Head()],(new Cons<Gun>(___AllGunslist10[___ac10[1]],(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	___NotAG10 = (

(___AllGunslist10).Select(__ContextSymbol113 => new { ___a120 = __ContextSymbol113 })
.Where(__ContextSymbol114 => !(___AG10.Contains(__ContextSymbol114.___a120)))
.Select(__ContextSymbol115 => __ContextSymbol115.___a120)
.ToList<Gun>()).ToList<Gun>();
	___fdsa10 = (

(___NotAG10).Select(__ContextSymbol116 => new { ___a121 = __ContextSymbol116 })
.Select(__ContextSymbol117 => ((("Nummer:") + (__ContextSymbol117.___a121.GunNumber)) + (" Controller:")) + (__ContextSymbol117.___a121.GunController.JoystickName))
.ToList<System.String>()).ToList<System.String>();
	ActiveGuns = ___AG10;
	NotActiveGuns = ___NotAG10;
	AllGuns = ___AllGunslist10;
	asdf = ___fdsa10;
	ActiveFlashs = (

Enumerable.Empty<Light>()).ToList<Light>();
	NotActiveFlashs = ___NAF10;
	AllFlashs = ___NAF10;
	s1 = 26;
return;
	case 26:
	if(!(world.W_Refill_Resources))
	{

	s1 = 26;
return;	}else
	{

	s1 = 5;
return;	}
	case 5:
	if(((___ac10.Count) == (1)))
	{

	goto case 3;	}else
	{

	goto case 4;	}
	case 3:
	___gunhand10 = (

(ActiveGuns).Select(__ContextSymbol119 => new { ___a122 = __ContextSymbol119 })
.Select(__ContextSymbol120 => __ContextSymbol120.___a122.GunController.JoystickName)
.ToList<System.String>()).ToList<System.String>();
	if(!(((___gunhand10.Head()) == ("Hydra1 - Left"))))
	{

	___AG11 = (

(new Cons<Gun>(___AllGunslist10[___ac10.Head()],(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();	}else
	{

	___AG11 = (

(new Cons<Gun>(___AllGunslist10[(___ac10.Head()) + (HR.Count)],(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();	}
	___NotAG11 = (

(___AllGunslist10).Select(__ContextSymbol123 => new { ___a123 = __ContextSymbol123 })
.Where(__ContextSymbol124 => !(___AG11.Contains(__ContextSymbol124.___a123)))
.Select(__ContextSymbol125 => __ContextSymbol125.___a123)
.ToList<Gun>()).ToList<Gun>();
	___z14 = (

(new Cons<System.String>(flashL.name,(new Cons<System.String>(flashR.name,(new Empty<System.String>()).ToList<System.String>())).ToList<System.String>())).ToList<System.String>()).ToList<System.String>();
	if(!(((___gunhand10.Head()) == ("Hydra1 - Left"))))
	{

	___AF10 = (

(new Cons<Light>(new Light(___pl10[1]),(new Empty<Light>()).ToList<Light>())).ToList<Light>()).ToList<Light>();	}else
	{

	___AF10 = (

(new Cons<Light>(new Light(___pl10[0]),(new Empty<Light>()).ToList<Light>())).ToList<Light>()).ToList<Light>();	}
	if(((___gunhand10.Head()) == ("Hydra1 - Left")))
	{

	___NAF11 = (

(new Cons<Light>(new Light(___pl10[0]),(new Empty<Light>()).ToList<Light>())).ToList<Light>()).ToList<Light>();	}else
	{

	___NAF11 = (

(new Cons<Light>(new Light(___pl10[1]),(new Empty<Light>()).ToList<Light>())).ToList<Light>()).ToList<Light>();	}
	___AllF10 = (___AF10).Concat(___NAF11).ToList<Light>();
	___fdsa11 = (

(___NotAG11).Select(__ContextSymbol131 => new { ___a124 = __ContextSymbol131 })
.Select(__ContextSymbol132 => ((("Nummer:") + (__ContextSymbol132.___a124.GunNumber)) + (" Controller:")) + (__ContextSymbol132.___a124.GunController.JoystickName))
.ToList<System.String>()).ToList<System.String>();
	ActiveGuns = ___AG11;
	NotActiveGuns = ___NotAG11;
	AllGuns = ___AllGunslist10;
	asdf = ___fdsa11;
	ActiveFlashs = ___AF10;
	NotActiveFlashs = ___NAF11;
	AllFlashs = ___AllF10;
	s1 = 6;
return;
	case 6:
	if(!(world.W_Refill_Resources))
	{

	s1 = 6;
return;	}else
	{

	s1 = -1;
return;	}
	case 4:
	___AG12 = (

(new Cons<Gun>(___AllGunslist10[0],(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	___NotAG12 = (

(___AllGunslist10).Select(__ContextSymbol134 => new { ___a125 = __ContextSymbol134 })
.Where(__ContextSymbol135 => !(___AG12.Contains(__ContextSymbol135.___a125)))
.Select(__ContextSymbol136 => __ContextSymbol136.___a125)
.ToList<Gun>()).ToList<Gun>();
	___AF11 = (

(new Cons<Light>(new Light(___pl10[1]),(new Empty<Light>()).ToList<Light>())).ToList<Light>()).ToList<Light>();
	___NAF12 = (

(new Cons<Light>(new Light(___pl10[0]),(new Empty<Light>()).ToList<Light>())).ToList<Light>()).ToList<Light>();
	___AllF11 = (___AF11).Concat(___NAF12).ToList<Light>();
	___fdsa12 = (

(___NotAG12).Select(__ContextSymbol139 => new { ___a126 = __ContextSymbol139 })
.Select(__ContextSymbol140 => ((("Nummer:") + (__ContextSymbol140.___a126.GunNumber)) + (" Controller:")) + (__ContextSymbol140.___a126.GunController.JoystickName))
.ToList<System.String>()).ToList<System.String>();
	ActiveGuns = ___AG12;
	NotActiveGuns = ___NotAG12;
	AllGuns = ___AllGunslist10;
	asdf = ___fdsa12;
	ActiveFlashs = ___AF11;
	NotActiveFlashs = ___NAF12;
	AllFlashs = ___AllF11;
	s1 = 16;
return;
	case 16:
	if(!(world.W_Refill_Resources))
	{

	s1 = 16;
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
	___q21 = (

(ActiveGuns).Select(__ContextSymbol141 => new { ___a227 = __ContextSymbol141 })
.Where(__ContextSymbol142 => !(((__ContextSymbol142.___a227.GunController.ECB) == (""))))
.Select(__ContextSymbol143 => __ContextSymbol143.___a227)
.ToList<Gun>()).ToList<Gun>();
	___j25 = (

(ActiveFlashs).Select(__ContextSymbol144 => new { ___a228 = __ContextSymbol144 })
.Where(__ContextSymbol145 => ((__ContextSymbol145.___a228.LightController.ECB) == ("other")))
.Select(__ContextSymbol146 => __ContextSymbol146.___a228)
.ToList<Light>()).ToList<Light>();
	if(((((___q21.Count) > (0))) && (!(((___j25.Count) > (0))))))
	{

	goto case 47;	}else
	{

	goto case 43;	}
	case 47:
	GunControllerPressed = (new Just<Gun>(___q21.Head()));
	LightControllerPressed = (new Nothing<Light>());
	s2 = 43;
return;
	case 43:
	if(((((___j25.Count) > (0))) && (!(((___q21.Count) > (0))))))
	{

	goto case 41;	}else
	{

	goto case 42;	}
	case 41:
	GunControllerPressed = (new Nothing<Gun>());
	LightControllerPressed = (new Just<Light>(___j25.Head()));
	s2 = -1;
return;
	case 42:
	GunControllerPressed = (new Nothing<Gun>());
	LightControllerPressed = (new Nothing<Light>());
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	if(!(((GunControllerPressed.IsSome) || (LightControllerPressed.IsSome))))
	{

	s3 = -1;
return;	}else
	{

	goto case 101;	}
	case 101:
	if(GunControllerPressed.IsSome)
	{

	___Joystickname30 = GunControllerPressed.Value.GunController.JoystickName;	}else
	{

	___Joystickname30 = LightControllerPressed.Value.LightController.JoystickName;	}
	if(GunControllerPressed.IsSome)
	{

	___Operation30 = GunControllerPressed.Value.GunController.ECB;	}else
	{

	___Operation30 = LightControllerPressed.Value.LightController.ECB;	}
	if(GunControllerPressed.IsSome)
	{

	___GunNumber30 = GunControllerPressed.Value.GunNumber;	}else
	{

	___GunNumber30 = 0;	}
	___OldActiveGun30 = (

(ActiveGuns).Select(__ContextSymbol147 => new { ___a329 = __ContextSymbol147 })
.Where(__ContextSymbol148 => !(((__ContextSymbol148.___a329.GunController.JoystickName) == (___Joystickname30))))
.Select(__ContextSymbol149 => __ContextSymbol149.___a329)
.ToList<Gun>()).ToList<Gun>();
	___OldActiveFlash30 = (

(ActiveFlashs).Select(__ContextSymbol150 => new { ___a330 = __ContextSymbol150 })
.Where(__ContextSymbol151 => !(((__ContextSymbol151.___a330.LightController.JoystickName) == (___Joystickname30))))
.Select(__ContextSymbol152 => __ContextSymbol152.___a330)
.ToList<Light>()).ToList<Light>();
	if(GunControllerPressed.IsSome)
	{

	goto case 12;	}else
	{

	goto case 0;	}
	case 12:
	___changingjoystick30 = (

(AllGuns).Select(__ContextSymbol153 => new { ___a331 = __ContextSymbol153 })
.Where(__ContextSymbol154 => ((__ContextSymbol154.___a331.GunController.JoystickName) == (___Joystickname30)))
.Select(__ContextSymbol155 => __ContextSymbol155.___a331)
.ToList<Gun>()).ToList<Gun>();
	___Listsize30 = ___changingjoystick30.Count;
	if(((___Operation30) == ("other")))
	{

	goto case 86;	}else
	{

	goto case 49;	}
	case 86:
	___changingLight30 = (

(AllFlashs).Select(__ContextSymbol156 => new { ___a332 = __ContextSymbol156 })
.Where(__ContextSymbol157 => ((__ContextSymbol157.___a332.LightController.JoystickName) == (___Joystickname30)))
.Select(__ContextSymbol158 => __ContextSymbol158.___a332)
.ToList<Light>()).ToList<Light>();
	if(((___OldActiveFlash30.Count) > (0)))
	{

	goto case 87;	}else
	{

	goto case 88;	}
	case 87:
	UnityEngine.Debug.Log("Max 1 flashlight allowed");
	ActiveGuns = ActiveGuns;
	ActiveFlashs = (

(new Cons<Light>(___OldActiveFlash30.Head(),(new Empty<Light>()).ToList<Light>())).ToList<Light>()).ToList<Light>();
	s3 = 49;
return;
	case 88:
	___NewActiveFlash30 = ___changingLight30.Head();
	ActiveGuns = ___OldActiveGun30;
	ActiveFlashs = (

(new Cons<Light>(___NewActiveFlash30,(new Empty<Light>()).ToList<Light>())).ToList<Light>()).ToList<Light>();
	s3 = 49;
return;
	case 49:
	if(((___Operation30) == ("next")))
	{

	goto case 50;	}else
	{

	goto case 13;	}
	case 50:
	___nextGunNumber30 = ((((___GunNumber30) + (1))) % (___Listsize30));
	___check30 = (

(ActiveGuns).Select(__ContextSymbol161 => new { ___a333 = __ContextSymbol161 })
.Where(__ContextSymbol162 => ((__ContextSymbol162.___a333.GunNumber) == (___nextGunNumber30)))
.Select(__ContextSymbol163 => __ContextSymbol163.___a333)
.ToList<Gun>()).ToList<Gun>();
	if(((___check30.Count) > (0)))
	{

	goto case 51;	}else
	{

	goto case 52;	}
	case 51:
	___othernumber30 = ((((___GunNumber30) + (2))) % (___Listsize30));
	___newActiveGun30 = (

(___changingjoystick30).Select(__ContextSymbol164 => new { ___a334 = __ContextSymbol164 })
.Where(__ContextSymbol165 => ((__ContextSymbol165.___a334.GunNumber) == (___othernumber30)))
.Select(__ContextSymbol166 => __ContextSymbol166.___a334)
.ToList<Gun>()).ToList<Gun>();
	if(((___Joystickname30) == (TransformHR.name)))
	{

	goto case 54;	}else
	{

	goto case 55;	}
	case 54:
	if(((___OldActiveGun30.Count) > (0)))
	{

	goto case 57;	}else
	{

	goto case 58;	}
	case 57:
	ActiveGuns = (

(new Cons<Gun>(___newActiveGun30.Head(),(new Cons<Gun>(___OldActiveGun30.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = ActiveFlashs;
	s3 = 13;
return;
	case 58:
	ActiveGuns = (

(new Cons<Gun>(___newActiveGun30.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = ActiveFlashs;
	s3 = 13;
return;
	case 55:
	if(((___OldActiveGun30.Count) > (0)))
	{

	goto case 62;	}else
	{

	goto case 63;	}
	case 62:
	ActiveGuns = (

(new Cons<Gun>(___OldActiveGun30.Head(),(new Cons<Gun>(___newActiveGun30.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = ActiveFlashs;
	s3 = 13;
return;
	case 63:
	ActiveGuns = (

(new Cons<Gun>(___newActiveGun30.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = ActiveFlashs;
	s3 = 13;
return;
	case 52:
	___newActiveGun31 = (

(___changingjoystick30).Select(__ContextSymbol171 => new { ___a335 = __ContextSymbol171 })
.Where(__ContextSymbol172 => ((__ContextSymbol172.___a335.GunNumber) == (___nextGunNumber30)))
.Select(__ContextSymbol173 => __ContextSymbol173.___a335)
.ToList<Gun>()).ToList<Gun>();
	if(((___Joystickname30) == (TransformHR.name)))
	{

	goto case 69;	}else
	{

	goto case 70;	}
	case 69:
	if(((___OldActiveGun30.Count) > (0)))
	{

	goto case 72;	}else
	{

	goto case 73;	}
	case 72:
	ActiveGuns = (

(new Cons<Gun>(___newActiveGun31.Head(),(new Cons<Gun>(___OldActiveGun30.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = ActiveFlashs;
	s3 = 13;
return;
	case 73:
	ActiveGuns = (

(new Cons<Gun>(___newActiveGun31.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = ActiveFlashs;
	s3 = 13;
return;
	case 70:
	if(((___OldActiveGun30.Count) > (0)))
	{

	goto case 77;	}else
	{

	goto case 78;	}
	case 77:
	ActiveGuns = (

(new Cons<Gun>(___OldActiveGun30.Head(),(new Cons<Gun>(___newActiveGun31.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = ActiveFlashs;
	s3 = 13;
return;
	case 78:
	ActiveGuns = (

(new Cons<Gun>(___newActiveGun31.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = ActiveFlashs;
	s3 = 13;
return;
	case 13:
	if(((___Operation30) == ("prev")))
	{

	goto case 14;	}else
	{

	s3 = 0;
return;	}
	case 14:
	___prevGunNumber30 = ((((((___GunNumber30) + (___Listsize30))) - (1))) % (___Listsize30));
	___check31 = (

(ActiveGuns).Select(__ContextSymbol178 => new { ___a336 = __ContextSymbol178 })
.Where(__ContextSymbol179 => ((__ContextSymbol179.___a336.GunNumber) == (___prevGunNumber30)))
.Select(__ContextSymbol180 => __ContextSymbol180.___a336)
.ToList<Gun>()).ToList<Gun>();
	if(((___check31.Count) > (0)))
	{

	goto case 15;	}else
	{

	goto case 16;	}
	case 15:
	___othernumber31 = ((((((___GunNumber30) + (___Listsize30))) - (2))) % (___Listsize30));
	___newActiveGun32 = (

(___changingjoystick30).Select(__ContextSymbol181 => new { ___a337 = __ContextSymbol181 })
.Where(__ContextSymbol182 => ((__ContextSymbol182.___a337.GunNumber) == (___othernumber31)))
.Select(__ContextSymbol183 => __ContextSymbol183.___a337)
.ToList<Gun>()).ToList<Gun>();
	if(((___Joystickname30) == (TransformHR.name)))
	{

	goto case 18;	}else
	{

	goto case 19;	}
	case 18:
	if(((___OldActiveGun30.Count) > (0)))
	{

	goto case 21;	}else
	{

	goto case 22;	}
	case 21:
	ActiveGuns = (

(new Cons<Gun>(___newActiveGun32.Head(),(new Cons<Gun>(___OldActiveGun30.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = ActiveFlashs;
	s3 = 0;
return;
	case 22:
	ActiveGuns = (

(new Cons<Gun>(___newActiveGun32.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = ActiveFlashs;
	s3 = 0;
return;
	case 19:
	if(((___OldActiveGun30.Count) > (0)))
	{

	goto case 26;	}else
	{

	goto case 27;	}
	case 26:
	ActiveGuns = (

(new Cons<Gun>(___OldActiveGun30.Head(),(new Cons<Gun>(___newActiveGun32.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = ActiveFlashs;
	s3 = 0;
return;
	case 27:
	ActiveGuns = (

(new Cons<Gun>(___newActiveGun32.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = ActiveFlashs;
	s3 = 0;
return;
	case 16:
	___newActiveGun33 = (

(___changingjoystick30).Select(__ContextSymbol188 => new { ___a338 = __ContextSymbol188 })
.Where(__ContextSymbol189 => ((__ContextSymbol189.___a338.GunNumber) == (___prevGunNumber30)))
.Select(__ContextSymbol190 => __ContextSymbol190.___a338)
.ToList<Gun>()).ToList<Gun>();
	if(((___Joystickname30) == (TransformHR.name)))
	{

	goto case 33;	}else
	{

	goto case 34;	}
	case 33:
	if(((___OldActiveGun30.Count) > (0)))
	{

	goto case 36;	}else
	{

	goto case 37;	}
	case 36:
	ActiveGuns = (

(new Cons<Gun>(___newActiveGun33.Head(),(new Cons<Gun>(___OldActiveGun30.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = ActiveFlashs;
	s3 = 0;
return;
	case 37:
	ActiveGuns = (

(new Cons<Gun>(___newActiveGun33.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = ActiveFlashs;
	s3 = 0;
return;
	case 34:
	if(((___OldActiveGun30.Count) > (0)))
	{

	goto case 41;	}else
	{

	goto case 42;	}
	case 41:
	ActiveGuns = (

(new Cons<Gun>(___OldActiveGun30.Head(),(new Cons<Gun>(___newActiveGun33.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = ActiveFlashs;
	s3 = 0;
return;
	case 42:
	ActiveGuns = (

(new Cons<Gun>(___newActiveGun33.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = ActiveFlashs;
	s3 = 0;
return;
	case 0:
	if(LightControllerPressed.IsSome)
	{

	goto case 1;	}else
	{

	s3 = -1;
return;	}
	case 1:
	___changingjoystick31 = (

(AllFlashs).Select(__ContextSymbol195 => new { ___a339 = __ContextSymbol195 })
.Where(__ContextSymbol196 => ((__ContextSymbol196.___a339.LightController.JoystickName) == (___Joystickname30)))
.Select(__ContextSymbol197 => __ContextSymbol197.___a339)
.ToList<Light>()).ToList<Light>();
	___currActiveGunNumber30 = (

(ActiveGuns).Select(__ContextSymbol198 => new { ___a340 = __ContextSymbol198 })
.Select(__ContextSymbol199 => __ContextSymbol199.___a340.GunNumber)
.ToList<System.Int32>()).ToList<System.Int32>();
	if(((___currActiveGunNumber30.Count) > (0)))
	{

	goto case 2;	}else
	{

	goto case 3;	}
	case 2:
	___newActiveGun34 = (

(NotActiveGuns).Select(__ContextSymbol200 => new { ___a341 = __ContextSymbol200 })
.Where(__ContextSymbol201 => ((((__ContextSymbol201.___a341.GunController.JoystickName) == (___Joystickname30))) && (!(((__ContextSymbol201.___a341.GunNumber) == (___currActiveGunNumber30.Head()))))))
.Select(__ContextSymbol202 => __ContextSymbol202.___a341)
.ToList<Gun>()).ToList<Gun>();
	ActiveGuns = (

(new Cons<Gun>(___OldActiveGun30.Head(),(new Cons<Gun>(___newActiveGun34.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = (

Enumerable.Empty<Light>()).ToList<Light>();
	s3 = -1;
return;
	case 3:
	___NAG30 = (

(NotActiveGuns).Select(__ContextSymbol205 => new { ___a342 = __ContextSymbol205 })
.Where(__ContextSymbol206 => ((__ContextSymbol206.___a342.GunController.JoystickName) == (___Joystickname30)))
.Select(__ContextSymbol207 => __ContextSymbol207.___a342)
.ToList<Gun>()).ToList<Gun>();
	ActiveGuns = (

(new Cons<Gun>(___NAG30.Head(),(new Empty<Gun>()).ToList<Gun>())).ToList<Gun>()).ToList<Gun>();
	ActiveFlashs = (

(new Cons<Light>(___OldActiveFlash30.Head(),(new Empty<Light>()).ToList<Light>())).ToList<Light>()).ToList<Light>();
	s3 = -1;
return;	
	default: return;}}
	

	int s4=-1;
	public void Rule4(float dt, World world){ 
	switch (s4)
	{

	case -1:
	if(!(((GunControllerPressed.IsSome) || (LightControllerPressed.IsSome))))
	{

	s4 = -1;
return;	}else
	{

	goto case 2;	}
	case 2:
	___r40 = (

(AllGuns).Select(__ContextSymbol210 => new { ___a443 = __ContextSymbol210 })
.Where(__ContextSymbol211 => !(ActiveGuns.Contains(__ContextSymbol211.___a443)))
.Select(__ContextSymbol212 => __ContextSymbol212.___a443)
.ToList<Gun>()).ToList<Gun>();
	___fdsa43 = (

(___r40).Select(__ContextSymbol213 => new { ___a444 = __ContextSymbol213 })
.Select(__ContextSymbol214 => ((("Nummer:") + (__ContextSymbol214.___a444.GunNumber)) + (" Controller:")) + (__ContextSymbol214.___a444.GunController.JoystickName))
.ToList<System.String>()).ToList<System.String>();
	NotActiveGuns = ___r40;
	asdf = ___fdsa43;
	s4 = -1;
return;	
	default: return;}}
	

	int s5=-1;
	public void Rule5(float dt, World world){ 
	switch (s5)
	{

	case -1:
	if(!(((AllFlashs.Count) > (0))))
	{

	s5 = -1;
return;	}else
	{

	goto case 7;	}
	case 7:
	UnityEngine.Debug.Log("change for flashs");
	___j56 = (

(AllFlashs).Select(__ContextSymbol215 => new { ___a545 = __ContextSymbol215 })
.Where(__ContextSymbol216 => !(ActiveFlashs.Contains(__ContextSymbol216.___a545)))
.Select(__ContextSymbol217 => __ContextSymbol217.___a545)
.ToList<Light>()).ToList<Light>();
	___rig50 = (

(ActiveFlashs).Select(__ContextSymbol218 => new { ___a546 = __ContextSymbol218 })
.Where(__ContextSymbol219 => !(((__ContextSymbol219.___a546.LightController.JoystickName) == ("Hydra1 - Left"))))
.Select(__ContextSymbol220 => __ContextSymbol220.___a546)
.ToList<Light>()).ToList<Light>();
	if(((___rig50.Count) > (0)))
	{

	___right50 = true;	}else
	{

	___right50 = false;	}
	___lef50 = (

(ActiveFlashs).Select(__ContextSymbol221 => new { ___a547 = __ContextSymbol221 })
.Where(__ContextSymbol222 => !(((__ContextSymbol222.___a547.LightController.JoystickName) == ("Hydra1 - Right"))))
.Select(__ContextSymbol223 => __ContextSymbol223.___a547)
.ToList<Light>()).ToList<Light>();
	if(((___lef50.Count) > (0)))
	{

	___left50 = true;	}else
	{

	___left50 = false;	}
	NotActiveFlashs = ___j56;
	sap = (

(new Cons<System.Boolean>(___right50,(new Cons<System.Boolean>(___left50,(new Empty<System.Boolean>()).ToList<System.Boolean>())).ToList<System.Boolean>())).ToList<System.Boolean>()).ToList<System.Boolean>();
	s5 = 0;
return;
	case 0:
	if(!(((((GunControllerPressed.IsSome) || (LightControllerPressed.IsSome))) || (world.W_Refill_Resources))))
	{

	s5 = 0;
return;	}else
	{

	s5 = -1;
return;	}	
	default: return;}}
	

	int s6=-1;
	public void Rule6(float dt, World world){ 
	switch (s6)
	{

	case -1:
	Position = world.Jeep.Value.InputPosition;
	s6 = -1;
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
		prev = false;
		other = false;
		next = false;
		SixenseHand = SixenseHand.Instantiate(joystickName);
		JoystickName = joystickName;
		ECB = "";
		
}
		public System.Boolean Bumper{  get { return SixenseHand.Bumper; }
  set{SixenseHand.Bumper = value; }
 }
	public System.Boolean Drie{  get { return SixenseHand.Drie; }
 }
	public System.String ECB;
	public UnityEngine.Vector3 Forward{  get { return SixenseHand.Forward; }
 }
	public SixenseHands Hand{  get { return SixenseHand.Hand; }
 }
	public UnityEngine.Vector3 InitialPosition{  get { return SixenseHand.InitialPosition; }
 }
	public UnityEngine.Quaternion InitialRotation{  get { return SixenseHand.InitialRotation; }
 }
	public System.String JoystickName;
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
	public System.Boolean Twee{  get { return SixenseHand.Twee; }
 }
	public System.Boolean Vier{  get { return SixenseHand.Vier; }
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
	public UnityEngine.Quaternion m_initialRot{  get { return SixenseHand.m_initialRot; }
  set{SixenseHand.m_initialRot = value; }
 }
	public System.String name{  get { return SixenseHand.name; }
  set{SixenseHand.name = value; }
 }
	public System.Boolean next;
	public System.Boolean other;
	public System.Boolean prev;
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
	if(!(Vier))
	{

	s0 = -1;
return;	}else
	{

	goto case 3;	}
	case 3:
	next = true;
	s0 = 2;
return;
	case 2:
	next = true;
	s0 = 1;
return;
	case 1:
	next = false;
	s0 = 0;
return;
	case 0:
	if(!(!(Vier)))
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
	if(!(Drie))
	{

	s1 = -1;
return;	}else
	{

	goto case 3;	}
	case 3:
	prev = true;
	s1 = 2;
return;
	case 2:
	prev = true;
	s1 = 1;
return;
	case 1:
	prev = false;
	s1 = 0;
return;
	case 0:
	if(!(!(Drie)))
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
	if(!(Twee))
	{

	s2 = -1;
return;	}else
	{

	goto case 3;	}
	case 3:
	other = true;
	s2 = 2;
return;
	case 2:
	other = true;
	s2 = 1;
return;
	case 1:
	other = false;
	s2 = 0;
return;
	case 0:
	if(!(!(Twee)))
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
	if(prev)
	{

	goto case 14;	}else
	{

	goto case 10;	}
	case 14:
	ECB = "prev";
	s3 = 10;
return;
	case 10:
	if(next)
	{

	goto case 11;	}else
	{

	goto case 7;	}
	case 11:
	ECB = "next";
	s3 = 7;
return;
	case 7:
	if(other)
	{

	goto case 5;	}else
	{

	goto case 6;	}
	case 5:
	ECB = "other";
	s3 = -1;
return;
	case 6:
	ECB = "";
	s3 = -1;
return;	
	default: return;}}
	

	int s4=-1;
	public void Rule4(float dt, World world){ 
	switch (s4)
	{

	case -1:
	Bumper = Bumper;
	s4 = -1;
return;	
	default: return;}}
	

	int s5=-1;
	public void Rule5(float dt, World world){ 
	switch (s5)
	{

	case -1:
	Trigger = Trigger;
	s5 = -1;
return;	
	default: return;}}
	

	int s6=-1;
	public void Rule6(float dt, World world){ 
	switch (s6)
	{

	case -1:
	if(!(!(((world.Jeep.Value.Invullen) == (true)))))
	{

	s6 = -1;
return;	}else
	{

	goto case 2;	}
	case 2:
	if(((Trigger) || (UnityEngine.Input.GetMouseButtonDown(0))))
	{

	goto case 0;	}else
	{

	goto case 1;	}
	case 0:
	Shot = true;
	s6 = -1;
return;
	case 1:
	Shot = false;
	s6 = -1;
return;	
	default: return;}}
	

	int s7=-1;
	public void Rule7(float dt, World world){ 
	switch (s7)
	{

	case -1:
	m_initialRot = world.Jeep.Value.Rotation;
	s7 = -1;
return;	
	default: return;}}
	





}
public class Gun{
public int frame;
public bool JustEntered = true;
private System.Int32 ind;
private ControllerRazor GC;
private System.String tr;
private Ammo am;
	public int ID;
public Gun(System.Int32 ind, ControllerRazor GC, System.String tr, Ammo am)
	{JustEntered = false;
 frame = World.frame;
		System.Boolean ___autom00;
		if(!(((ind) == (0))))
			{
			___autom00 = false;
			}else
			{
			___autom00 = true;
			}
		List<System.String> ___stlist00;
		___stlist00 = (

(new Cons<System.String>("MachineGun",(new Cons<System.String>("Pistol",(new Cons<System.String>("ShotGun",(new Cons<System.String>("Bazooka",(new Empty<System.String>()).ToList<System.String>())).ToList<System.String>())).ToList<System.String>())).ToList<System.String>())).ToList<System.String>()).ToList<System.String>();
		List<System.Int32> ___InMagList00;
		___InMagList00 = (

(new Cons<System.Int32>(50,(new Cons<System.Int32>(20,(new Cons<System.Int32>(5,(new Cons<System.Int32>(0,(new Empty<System.Int32>()).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>()).ToList<System.Int32>();
		List<System.Int32> ___NotInMagList01;
		___NotInMagList01 = (

(new Cons<System.Int32>(850,(new Cons<System.Int32>(200,(new Cons<System.Int32>(60,(new Cons<System.Int32>(16,(new Empty<System.Int32>()).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>()).ToList<System.Int32>();
		List<System.Int32> ___ClipSizeList00;
		___ClipSizeList00 = (

(new Cons<System.Int32>(150,(new Cons<System.Int32>(20,(new Cons<System.Int32>(5,(new Cons<System.Int32>(1,(new Empty<System.Int32>()).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>())).ToList<System.Int32>()).ToList<System.Int32>();
		List<System.Single> ___ReloadDurationList00;
		___ReloadDurationList00 = (

(new Cons<System.Single>(7f,(new Cons<System.Single>(3f,(new Cons<System.Single>(0.5f,(new Cons<System.Single>(5f,(new Empty<System.Single>()).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>()).ToList<System.Single>();
		List<System.Single> ___DamageList00;
		___DamageList00 = (

(new Cons<System.Single>(40f,(new Cons<System.Single>(75f,(new Cons<System.Single>(135f,(new Cons<System.Single>(400f,(new Empty<System.Single>()).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>())).ToList<System.Single>()).ToList<System.Single>();
		System.String ___nam00;
		___nam00 = ___stlist00[ind];
		UnityGun = UnityGun.Instantiate(___nam00,tr);
		TypeWeapon = ___nam00;
		Reloading = false;
		ReloadDuration = ___ReloadDurationList00[ind];
		MagazineSize = ___ClipSizeList00[ind];
		GunNumber = ind;
		GunController = GC;
		GNotInMagazine = 0;
		GInMagazine = 0;
		DamagePerBullet = ___DamageList00[ind];
		Automatic = ___autom00;
		AmmoAct = am;
		
}
		public Ammo AmmoAct;
	public System.Boolean Automatic;
	public System.Single DamagePerBullet;
	public System.Int32 GInMagazine;
	public System.Int32 GNotInMagazine;
	public ControllerRazor GunController;
	public System.Single GunDamage{  get { return UnityGun.GunDamage; }
  set{UnityGun.GunDamage = value; }
 }
	public System.Int32 GunNumber;
	public System.Int32 InMag{  get { return UnityGun.InMag; }
  set{UnityGun.InMag = value; }
 }
	public System.Boolean Keyboard{  get { return UnityGun.Keyboard; }
  set{UnityGun.Keyboard = value; }
 }
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
	public UnityEngine.Vector3 Position{  get { return UnityGun.Position; }
  set{UnityGun.Position = value; }
 }
	public System.Single ReloadDuration;
	public System.Boolean Reloading;
	public UnityEngine.Vector3 Rotation{  get { return UnityGun.Rotation; }
  set{UnityGun.Rotation = value; }
 }
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
	public System.Single count_down14;
	public void Update(float dt, World world) {
frame = World.frame;

		AmmoAct.Update(dt, world);
		GunController.Update(dt, world);
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
	AmmoAct.GC = (new Just<ControllerRazor>(GunController));
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	AmmoAct.Automatic = Automatic;
	AmmoAct.ReloadDuration = ReloadDuration;
	AmmoAct.MagazineSize = MagazineSize;
	AmmoAct.TypeWeapon = TypeWeapon;
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
	if(UnityEngine.Input.GetKey(KeyCode.C))
	{

	goto case 6;	}else
	{

	goto case 2;	}
	case 6:
	Reloading = false;
	s2 = 2;
return;
	case 2:
	if(((AmmoAct.Reloading) == (false)))
	{

	goto case 3;	}else
	{

	s2 = -1;
return;	}
	case 3:
	Reloading = false;
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	InMag = AmmoAct.InMagazine;
	NotInMag = AmmoAct.NotInMagazine;
	s3 = -1;
return;	
	default: return;}}
	

	int s4=-1;
	public void Rule4(float dt, World world){ 
	switch (s4)
	{

	case -1:
	if(!(UnityEngine.Input.GetKeyDown(KeyCode.U)))
	{

	s4 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Keyboard = !(Keyboard);
	s4 = -1;
return;	
	default: return;}}
	

	int s5=-1;
	public void Rule5(float dt, World world){ 
	switch (s5)
	{

	case -1:
	if(UnityEngine.Input.GetKey(KeyCode.R))
	{

	goto case 2;	}else
	{

	goto case 3;	}
	case 2:
	AmmoAct.Reloading = true;
	s5 = 5;
return;
	case 5:
	if(!(!(Reloading)))
	{

	s5 = 5;
return;	}else
	{

	s5 = -1;
return;	}
	case 3:
	AmmoAct.Reloading = false;
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
	if(((((AmmoAct.InMagazine) > (0))) && (!(AmmoAct.Reloading))))
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
	s6 = 6;
return;
	case 6:
	Shoot = false;
	s6 = 5;
return;
	case 5:
	if(!(!(GunController.Shot)))
	{

	s6 = 5;
return;	}else
	{

	s6 = -1;
return;	}
	case 3:
	if(!(((GunController.Shot) && (((AmmoAct.InMagazine) > (0))))))
	{

	s6 = -1;
return;	}else
	{

	goto case 9;	}
	case 9:
	Shoot = true;
	s6 = 12;
return;
	case 12:
	Shoot = false;
	s6 = 10;
return;
	case 10:
	count_down14 = 0.05f;
	goto case 11;
	case 11:
	if(((count_down14) > (0f)))
	{

	count_down14 = ((count_down14) - (dt));
	s6 = 11;
return;	}else
	{

	s6 = 3;
return;	}	
	default: return;}}
	

	int s7=-1;
	public void Rule7(float dt, World world){ 
	switch (s7)
	{

	case -1:
	GunDamage = DamagePerBullet;
	s7 = 0;
return;
	case 0:
	if(!(false))
	{

	s7 = 0;
return;	}else
	{

	s7 = -1;
return;	}	
	default: return;}}
	





}
public class Ammo{
public int frame;
public bool JustEntered = true;
private System.Int32 InMag;
private System.Int32 NotInMag;
	public int ID;
public Ammo(System.Int32 InMag, System.Int32 NotInMag)
	{JustEntered = false;
 frame = World.frame;
		shot = false;
		TypeWeapon = "";
		Reloading = false;
		ReloadDuration = 0f;
		NotInMagazine = NotInMag;
		MagazineSize = 0;
		InMagazine = InMag;
		GC = (new Nothing<ControllerRazor>());
		Automatic = false;
		
}
		public System.Boolean Automatic;
	public Option<ControllerRazor> GC;
	public System.Int32 InMagazine;
	public System.Int32 MagazineSize;
	public System.Int32 NotInMagazine;
	public System.Single ReloadDuration;
	public System.Boolean Reloading;
	public System.String TypeWeapon;
	public System.Boolean shot;
	public System.Single count_down15;
	public System.Int32 ___a148;
	public System.Int32 ___b13;
	public System.Single count_down16;
	public System.Single count_down17;
	public System.Int32 ___changed10;
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
	if(!(GC.IsSome))
	{

	s0 = -1;
return;	}else
	{

	goto case 14;	}
	case 14:
	if(!(GC.Value.Shot))
	{

	s0 = 14;
return;	}else
	{

	goto case 0;	}
	case 0:
	if(((((InMagazine) > (0))) && (!(Reloading))))
	{

	goto case 1;	}else
	{

	s0 = -1;
return;	}
	case 1:
	if(!(Automatic))
	{

	goto case 2;	}else
	{

	goto case 3;	}
	case 2:
	InMagazine = ((InMagazine) - (1));
	shot = true;
	s0 = 6;
return;
	case 6:
	InMagazine = InMagazine;
	shot = false;
	s0 = 5;
return;
	case 5:
	if(!(!(GC.Value.Shot)))
	{

	s0 = 5;
return;	}else
	{

	s0 = -1;
return;	}
	case 3:
	if(!(((GC.Value.Shot) && (((InMagazine) > (0))))))
	{

	s0 = -1;
return;	}else
	{

	goto case 9;	}
	case 9:
	InMagazine = ((InMagazine) - (1));
	shot = true;
	s0 = 12;
return;
	case 12:
	InMagazine = InMagazine;
	shot = false;
	s0 = 10;
return;
	case 10:
	count_down15 = 0.05f;
	goto case 11;
	case 11:
	if(((count_down15) > (0f)))
	{

	count_down15 = ((count_down15) - (dt));
	s0 = 11;
return;	}else
	{

	s0 = 3;
return;	}	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(!(((((InMagazine) == (0))) || (Reloading))))
	{

	s1 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	if(((NotInMagazine) > (0)))
	{

	goto case 1;	}else
	{

	s1 = -1;
return;	}
	case 1:
	if(((TypeWeapon) == ("ShotGun")))
	{

	goto case 2;	}else
	{

	goto case 3;	}
	case 2:
	if(!(((((NotInMagazine) > (0))) && (((((MagazineSize) + (1))) > (InMagazine))))))
	{

	s1 = -1;
return;	}else
	{

	goto case 6;	}
	case 6:
	___a148 = ((NotInMagazine) - (1));
	___b13 = ((InMagazine) + (1));
	Reloading = true;
	NotInMagazine = ___a148;
	InMagazine = ___b13;
	s1 = 7;
return;
	case 7:
	count_down16 = ReloadDuration;
	goto case 8;
	case 8:
	if(((count_down16) > (0f)))
	{

	count_down16 = ((count_down16) - (dt));
	s1 = 8;
return;	}else
	{

	s1 = 2;
return;	}
	case 3:
	Reloading = true;
	NotInMagazine = NotInMagazine;
	InMagazine = InMagazine;
	s1 = 18;
return;
	case 18:
	count_down17 = ReloadDuration;
	goto case 19;
	case 19:
	if(((count_down17) > (0f)))
	{

	count_down17 = ((count_down17) - (dt));
	s1 = 19;
return;	}else
	{

	goto case 14;	}
	case 14:
	if(((MagazineSize) > (NotInMagazine)))
	{

	goto case 12;	}else
	{

	goto case 13;	}
	case 12:
	Reloading = false;
	NotInMagazine = 0;
	InMagazine = NotInMagazine;
	s1 = -1;
return;
	case 13:
	___changed10 = ((MagazineSize) - (InMagazine));
	Reloading = false;
	NotInMagazine = ((NotInMagazine) - (___changed10));
	InMagazine = MagazineSize;
	s1 = -1;
return;	
	default: return;}}
	





}
public class Bullet{
public int frame;
public bool JustEntered = true;
private UnityEngine.Vector3 pos;
private UnityEngine.Vector3 directi;
	public int ID;
public Bullet(UnityEngine.Vector3 pos, UnityEngine.Vector3 directi)
	{JustEntered = false;
 frame = World.frame;
		transforw = directi;
		cnt = 0f;
		UnityBullet = UnityBullet.Instantiate(pos,"bullet");
		
}
		public UnityEngine.Vector3 Frce{  set{UnityBullet.Frce = value; }
 }
	public UnityEngine.Rigidbody Rbody{  get { return UnityBullet.Rbody; }
  set{UnityBullet.Rbody = value; }
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
	public UnityEngine.Vector3 transforw;
	public System.Boolean useGUILayout{  get { return UnityBullet.useGUILayout; }
  set{UnityBullet.useGUILayout = value; }
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
	if(!(((40f) > (cnt))))
	{

	goto case 0;	}else
	{

	goto case 2;	}
	case 2:
	Frce = transforw;
	cnt = ((cnt) + (10f));
	s0 = -1;
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
	Active = LightController.Trigger;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(((Active) && (((Battery) > (0.49f)))))
	{

	goto case 1;	}else
	{

	goto case 2;	}
	case 1:
	Battery = ((Battery) - (0.5f));
	s1 = -1;
return;
	case 2:
	Battery = Battery;
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(((world.ActiveBoR) == ("Battery Black")))
	{

	goto case 7;	}else
	{

	s2 = -1;
return;	}
	case 7:
	UnityEngine.Debug.Log(("Battery = ") + (Battery));
	Battery = ((Battery) + (50f));
	s2 = -1;
return;	
	default: return;}}
	





}
public class GroupZombie{
public int frame;
public bool JustEntered = true;
private UnityEngine.Vector3 sps;
private System.Int32 amount;
	public int ID;
public GroupZombie(UnityEngine.Vector3 sps, System.Int32 amount)
	{JustEntered = false;
 frame = World.frame;
		ZombieLeader = (new Nothing<Zombie>());
		ZombieFollowers = (

Enumerable.Empty<Zombie>()).ToList<Zombie>();
		UnityGroup = UnityGroup.Instantiate(sps,amount);
		
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
	public List<Zombie> ___z05;
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
	___z05 = (

(U_Zombies).Select(__ContextSymbol233 => new { ___a049 = __ContextSymbol233 })
.Select(__ContextSymbol234 => new Zombie(__ContextSymbol234.___a049))
.ToList<Zombie>()).ToList<Zombie>();
	ZombieFollowers = ___z05;
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
public class Zombie{
public int frame;
public bool JustEntered = true;
private UnityEngine.Transform trans;
	public int ID;
public Zombie(UnityEngine.Transform trans)
	{JustEntered = false;
 frame = World.frame;
		UnityZombie2 = UnityZombie2.Find(trans);
		
}
		public System.Boolean ApplyForceOnZombie{  get { return UnityZombie2.ApplyForceOnZombie; }
  set{UnityZombie2.ApplyForceOnZombie = value; }
 }
	public UnityEngine.AudioClip Audio_Attack1{  get { return UnityZombie2.Audio_Attack1; }
  set{UnityZombie2.Audio_Attack1 = value; }
 }
	public UnityEngine.AudioClip Audio_Attack2{  get { return UnityZombie2.Audio_Attack2; }
  set{UnityZombie2.Audio_Attack2 = value; }
 }
	public UnityEngine.AudioClip Audio_Shout{  get { return UnityZombie2.Audio_Shout; }
  set{UnityZombie2.Audio_Shout = value; }
 }
	public UnityEngine.AudioClip Audio_Walk{  get { return UnityZombie2.Audio_Walk; }
  set{UnityZombie2.Audio_Walk = value; }
 }
	public System.Single BodyPartMultiplier{  get { return UnityZombie2.BodyPartMultiplier; }
  set{UnityZombie2.BodyPartMultiplier = value; }
 }
	public System.Boolean CollidedWithCar{  get { return UnityZombie2.CollidedWithCar; }
  set{UnityZombie2.CollidedWithCar = value; }
 }
	public UnityEngine.Vector3 CollisionDirection{  get { return UnityZombie2.CollisionDirection; }
  set{UnityZombie2.CollisionDirection = value; }
 }
	public System.Single Damage{  get { return UnityZombie2.Damage; }
  set{UnityZombie2.Damage = value; }
 }
	public System.Boolean Dead{  get { return UnityZombie2.Dead; }
  set{UnityZombie2.Dead = value; }
 }
	public UnityEngine.Vector3 Dest{  get { return UnityZombie2.Dest; }
  set{UnityZombie2.Dest = value; }
 }
	public System.Boolean Destroyed{  get { return UnityZombie2.Destroyed; }
  set{UnityZombie2.Destroyed = value; }
 }
	public System.Single Force{  get { return UnityZombie2.Force; }
  set{UnityZombie2.Force = value; }
 }
	public UnityEngine.Collider HitCollider{  get { return UnityZombie2.HitCollider; }
  set{UnityZombie2.HitCollider = value; }
 }
	public UnityEngine.Rigidbody HitRigidbody{  get { return UnityZombie2.HitRigidbody; }
  set{UnityZombie2.HitRigidbody = value; }
 }
	public UnityEngine.Transform HitTransform{  get { return UnityZombie2.HitTransform; }
  set{UnityZombie2.HitTransform = value; }
 }
	public System.Boolean IsHitByForce{  get { return UnityZombie2.IsHitByForce; }
  set{UnityZombie2.IsHitByForce = value; }
 }
	public System.Single Life{  get { return UnityZombie2.Life; }
  set{UnityZombie2.Life = value; }
 }
	public UnityEngine.Vector3 Position{  get { return UnityZombie2.Position; }
 }
	public System.String SoundToPlay{  get { return UnityZombie2.SoundToPlay; }
  set{UnityZombie2.SoundToPlay = value; }
 }
	public UnityZombie2 UnityZombie2;
	public System.String WhichSoundToPlay{  get { return UnityZombie2.WhichSoundToPlay; }
 }
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
	public System.String name{  get { return UnityZombie2.name; }
  set{UnityZombie2.name = value; }
 }
	public System.String tag{  get { return UnityZombie2.tag; }
  set{UnityZombie2.tag = value; }
 }
	public System.Single tim{  get { return UnityZombie2.tim; }
  set{UnityZombie2.tim = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityZombie2.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityZombie2.useGUILayout; }
  set{UnityZombie2.useGUILayout = value; }
 }
	public System.Single count_down18;
	public void Update(float dt, World world) {
frame = World.frame;

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
	Dest = world.Jeep.Value.Position;
	s0 = 0;
return;
	case 0:
	if(!(!(Dead)))
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
	if(!(((UnityEngine.Vector3.Distance(Position,world.Jeep.Value.Position)) > (410f))))
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
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	Destroyed = false;
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	count_down18 = tim;
	goto case 2;
	case 2:
	if(((count_down18) > (0f)))
	{

	count_down18 = ((count_down18) - (dt));
	s3 = 2;
return;	}else
	{

	goto case 0;	}
	case 0:
	SoundToPlay = WhichSoundToPlay;
	s3 = -1;
return;	
	default: return;}}
	





}
public class ZombieGroupDestroyer{
public int frame;
public bool JustEntered = true;
private System.Single a;
private UnityEngine.Vector3 b;
	public int ID;
public ZombieGroupDestroyer(System.Single a, UnityEngine.Vector3 b)
	{JustEntered = false;
 frame = World.frame;
		UnityDestroyer = UnityDestroyer.instantiate(a,b);
		
}
		public UnityDestroyer UnityDestroyer;
	public System.Boolean enabled{  get { return UnityDestroyer.enabled; }
  set{UnityDestroyer.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityDestroyer.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityDestroyer.hideFlags; }
  set{UnityDestroyer.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityDestroyer.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityDestroyer.name; }
  set{UnityDestroyer.name = value; }
 }
	public System.String tag{  get { return UnityDestroyer.tag; }
  set{UnityDestroyer.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityDestroyer.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityDestroyer.useGUILayout; }
  set{UnityDestroyer.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;



	}











}
}      