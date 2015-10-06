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
		UnityEngine.Debug.Log(GameSettings.isHost);
		SpawnAmount = 2f;
		PlayerClient = new Client();
		GameServer = new Server();
		GameReady = false;
		CurrentPlayer = new Player();
		Asteroids = (

Enumerable.Empty<Asteroid>()).ToList<Asteroid>();
		
}
		public List<Asteroid> __Asteroids;
	public List<Asteroid> Asteroids{  get { return  __Asteroids; }
  set{ __Asteroids = value;
 foreach(var e in value){if(e.JustEntered){ e.JustEntered = false;
}
} }
 }
	public Player CurrentPlayer;
	public System.Boolean GameReady;
	public Server GameServer;
	public Client PlayerClient;
	public System.Single SpawnAmount;
	public System.Single count_down1;
	public System.Single count_down2;
	public System.Int32 ___x20;
	public System.Boolean ___x31;
	public System.Boolean ___a31;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;		this.Rule0(dt, world);

		for(int x0 = 0; x0 < Asteroids.Count; x0++) { 
			Asteroids[x0].Update(dt, world);
		}
		CurrentPlayer.Update(dt, world);
		GameServer.Update(dt, world);
		PlayerClient.Update(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
		this.Rule3(dt, world);
	}

	public void Rule0(float dt, World world) 
	{
	Asteroids = (

(Asteroids).Select(__ContextSymbol1 => new { ___a00 = __ContextSymbol1 })
.Where(__ContextSymbol2 => ((__ContextSymbol2.___a00.Destroyed) == (false)))
.Select(__ContextSymbol3 => __ContextSymbol3.___a00)
.ToList<Asteroid>()).ToList<Asteroid>();
	}
	




	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	count_down1 = 1f;
	goto case 6;
	case 6:
	if(((count_down1) > (0f)))
	{

	count_down1 = ((count_down1) - (dt));
	s1 = 6;
return;	}else
	{

	goto case 2;	}
	case 2:
	if(((SpawnAmount) > (0.1f)))
	{

	goto case 0;	}else
	{

	goto case 1;	}
	case 0:
	SpawnAmount = ((SpawnAmount) - (0.1f));
	s1 = -1;
return;
	case 1:
	SpawnAmount = SpawnAmount;
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	count_down2 = SpawnAmount;
	goto case 3;
	case 3:
	if(((count_down2) > (0f)))
	{

	count_down2 = ((count_down2) - (dt));
	s2 = 3;
return;	}else
	{

	goto case 1;	}
	case 1:
	___x20 = UnityEngine.Random.Range(-15,15);
	Asteroids = new Cons<Asteroid>(new Asteroid(new UnityEngine.Vector3(((System.Single)___x20),7f,-15f)), (Asteroids)).ToList<Asteroid>();
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	if(GameSettings.isHost)
	{

	goto case 4;	}else
	{

	goto case 5;	}
	case 4:
	___x31 = GameServer.Host;
	UnityEngine.Debug.Log(___x31);
	GameReady = ___x31;
	s3 = -1;
return;
	case 5:
	___a31 = PlayerClient.Connect;
	UnityEngine.Debug.Log(___a31);
	GameReady = ___a31;
	s3 = -1;
return;	
	default: return;}}
	





}
public class Player{
public int frame;
public bool JustEntered = true;
	public int ID;
public Player()
	{JustEntered = false;
 frame = World.frame;
		PlayerShip = new Ship();
		PlayerID = 1;
		
}
		public System.Int32 PlayerID;
	public Ship PlayerShip;
	public void Update(float dt, World world) {
frame = World.frame;

		PlayerShip.Update(dt, world);


	}











}
public class Ship{
public int frame;
public bool JustEntered = true;
	public int ID;
public Ship()
	{JustEntered = false;
 frame = World.frame;
		UnityShip = UnityShip.Instantiate(new UnityEngine.Vector3(0f,-2f,-15f));
		Projectiles = (

Enumerable.Empty<Bullet>()).ToList<Bullet>();
		HitCounter = 0;
		HP = new PlayerHealth(new UnityEngine.Vector3(-12f,5f,-15f));
		
}
		public PlayerHealth HP;
	public System.Boolean Hit{  get { return UnityShip.Hit; }
  set{UnityShip.Hit = value; }
 }
	public System.Int32 HitCounter;
	public UnityEngine.Vector3 Position{  get { return UnityShip.Position; }
  set{UnityShip.Position = value; }
 }
	public List<Bullet> Projectiles;
	public UnityShip UnityShip;
	public System.Boolean enabled{  get { return UnityShip.enabled; }
  set{UnityShip.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityShip.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityShip.hideFlags; }
  set{UnityShip.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityShip.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityShip.name; }
  set{UnityShip.name = value; }
 }
	public System.String tag{  get { return UnityShip.tag; }
  set{UnityShip.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityShip.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityShip.useGUILayout; }
  set{UnityShip.useGUILayout = value; }
 }
	public System.Single count_down3;
	public void Update(float dt, World world) {
frame = World.frame;		this.Rule0(dt, world);

		HP.Update(dt, world);
		for(int x0 = 0; x0 < Projectiles.Count; x0++) { 
			Projectiles[x0].Update(dt, world);
		}
		this.Rule1(dt, world);
		this.Rule2(dt, world);
		this.Rule3(dt, world);
		this.Rule4(dt, world);
		this.Rule5(dt, world);
	}

	public void Rule0(float dt, World world) 
	{
	Projectiles = (

(Projectiles).Select(__ContextSymbol6 => new { ___p00 = __ContextSymbol6 })
.Where(__ContextSymbol7 => ((__ContextSymbol7.___p00.Destroyed) == (false)))
.Select(__ContextSymbol8 => __ContextSymbol8.___p00)
.ToList<Bullet>()).ToList<Bullet>();
	}
	




	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(((HitCounter) == (0)))
	{

	goto case 23;	}else
	{

	goto case 19;	}
	case 23:
	HP.FirstLife = true;
	HP.SecondLife = true;
	HP.ThirdLife = true;
	s1 = 19;
return;
	case 19:
	if(((HitCounter) == (1)))
	{

	goto case 20;	}else
	{

	goto case 16;	}
	case 20:
	HP.FirstLife = true;
	HP.SecondLife = true;
	HP.ThirdLife = false;
	s1 = 16;
return;
	case 16:
	if(((HitCounter) == (2)))
	{

	goto case 17;	}else
	{

	goto case 13;	}
	case 17:
	HP.FirstLife = true;
	HP.SecondLife = false;
	HP.ThirdLife = false;
	s1 = 13;
return;
	case 13:
	if(((HitCounter) == (3)))
	{

	goto case 14;	}else
	{

	s1 = -1;
return;	}
	case 14:
	HP.FirstLife = false;
	HP.SecondLife = false;
	HP.ThirdLife = false;
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, World world){ 
	switch (s2)
	{

	case -1:
	if(!(Hit))
	{

	s2 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	HitCounter = ((HitCounter) + (1));
	Hit = false;
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, World world){ 
	switch (s3)
	{

	case -1:
	if(!(UnityEngine.Input.GetKey(KeyCode.D)))
	{

	s3 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Position = ((Position) + (new UnityEngine.Vector3((4f) * (dt),0f,0f)));
	s3 = -1;
return;	
	default: return;}}
	

	int s4=-1;
	public void Rule4(float dt, World world){ 
	switch (s4)
	{

	case -1:
	if(!(UnityEngine.Input.GetKey(KeyCode.A)))
	{

	s4 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Position = ((Position) - (new UnityEngine.Vector3((4f) * (dt),0f,0f)));
	s4 = -1;
return;	
	default: return;}}
	

	int s5=-1;
	public void Rule5(float dt, World world){ 
	switch (s5)
	{

	case -1:
	if(!(UnityEngine.Input.GetKeyDown(KeyCode.Space)))
	{

	s5 = -1;
return;	}else
	{

	goto case 2;	}
	case 2:
	Projectiles = new Cons<Bullet>(new Bullet(Position), (Projectiles)).ToList<Bullet>();
	s5 = 0;
return;
	case 0:
	count_down3 = 0.1f;
	goto case 1;
	case 1:
	if(((count_down3) > (0f)))
	{

	count_down3 = ((count_down3) - (dt));
	s5 = 1;
return;	}else
	{

	s5 = -1;
return;	}	
	default: return;}}
	





}
public class Bullet{
public int frame;
public bool JustEntered = true;
private UnityEngine.Vector3 pos;
	public int ID;
public Bullet(UnityEngine.Vector3 pos)
	{JustEntered = false;
 frame = World.frame;
		UnityBullet = UnityBullet.Instantiate(pos);
		
}
		public System.Boolean Destroyed{  get { return UnityBullet.Destroyed; }
  set{UnityBullet.Destroyed = value; }
 }
	public System.Boolean Impact{  get { return UnityBullet.Impact; }
  set{UnityBullet.Impact = value; }
 }
	public UnityEngine.Vector3 Position{  get { return UnityBullet.Position; }
  set{UnityBullet.Position = value; }
 }
	public UnityBullet UnityBullet;
	public UnityEngine.Vector3 ViewPortPoint{  get { return UnityBullet.ViewPortPoint; }
 }
	public System.Boolean destroyed{  get { return UnityBullet.destroyed; }
  set{UnityBullet.destroyed = value; }
 }
	public System.Boolean enabled{  get { return UnityBullet.enabled; }
  set{UnityBullet.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityBullet.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityBullet.hideFlags; }
  set{UnityBullet.hideFlags = value; }
 }
	public System.Boolean impact{  get { return UnityBullet.impact; }
  set{UnityBullet.impact = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityBullet.isActiveAndEnabled; }
 }
	public UnityEngine.Camera mainCamera{  get { return UnityBullet.mainCamera; }
  set{UnityBullet.mainCamera = value; }
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
frame = World.frame;		this.Rule0(dt, world);

		this.Rule1(dt, world);

	}

	public void Rule0(float dt, World world) 
	{
	Position = (Position) + (new UnityEngine.Vector3(0f,(5f) * (dt),0f));
	}
	




	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	if(!(((Impact) || (((ViewPortPoint.y) > (1f))))))
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
public class Asteroid{
public int frame;
public bool JustEntered = true;
private UnityEngine.Vector3 pos;
	public int ID;
public Asteroid(UnityEngine.Vector3 pos)
	{JustEntered = false;
 frame = World.frame;
		UnityAsteroid = UnityAsteroid.Instantiate(pos);
		
}
		public System.Boolean Destroyed{  get { return UnityAsteroid.Destroyed; }
  set{UnityAsteroid.Destroyed = value; }
 }
	public System.Boolean Hit{  get { return UnityAsteroid.Hit; }
  set{UnityAsteroid.Hit = value; }
 }
	public UnityEngine.Vector3 Position{  get { return UnityAsteroid.Position; }
  set{UnityAsteroid.Position = value; }
 }
	public UnityAsteroid UnityAsteroid;
	public UnityEngine.Vector3 ViewPortPoint{  get { return UnityAsteroid.ViewPortPoint; }
 }
	public System.Boolean enabled{  get { return UnityAsteroid.enabled; }
  set{UnityAsteroid.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityAsteroid.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityAsteroid.hideFlags; }
  set{UnityAsteroid.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityAsteroid.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityAsteroid.name; }
  set{UnityAsteroid.name = value; }
 }
	public System.String tag{  get { return UnityAsteroid.tag; }
  set{UnityAsteroid.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityAsteroid.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityAsteroid.useGUILayout; }
  set{UnityAsteroid.useGUILayout = value; }
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
	if(!(((Hit) || (((-0.4f) > (ViewPortPoint.y))))))
	{

	s0 = -1;
return;	}else
	{

	goto case 0;	}
	case 0:
	Destroyed = true;
	s0 = -1;
return;	
	default: return;}}
	

	int s1=-1;
	public void Rule1(float dt, World world){ 
	switch (s1)
	{

	case -1:
	Position = ((Position) + (new UnityEngine.Vector3(0f,(-5f) * (dt),0f)));
	s1 = -1;
return;	
	default: return;}}
	





}
public class PlayerHealth{
public int frame;
public bool JustEntered = true;
private UnityEngine.Vector3 pos;
	public int ID;
public PlayerHealth(UnityEngine.Vector3 pos)
	{JustEntered = false;
 frame = World.frame;
		UnityPlayerHealth = UnityPlayerHealth.Instantiate(pos);
		
}
		public System.Boolean FirstLife{  get { return UnityPlayerHealth.FirstLife; }
  set{UnityPlayerHealth.FirstLife = value; }
 }
	public System.Boolean SecondLife{  get { return UnityPlayerHealth.SecondLife; }
  set{UnityPlayerHealth.SecondLife = value; }
 }
	public System.Boolean ThirdLife{  get { return UnityPlayerHealth.ThirdLife; }
  set{UnityPlayerHealth.ThirdLife = value; }
 }
	public UnityPlayerHealth UnityPlayerHealth;
	public System.Boolean enabled{  get { return UnityPlayerHealth.enabled; }
  set{UnityPlayerHealth.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityPlayerHealth.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityPlayerHealth.hideFlags; }
  set{UnityPlayerHealth.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityPlayerHealth.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityPlayerHealth.name; }
  set{UnityPlayerHealth.name = value; }
 }
	public System.String tag{  get { return UnityPlayerHealth.tag; }
  set{UnityPlayerHealth.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityPlayerHealth.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityPlayerHealth.useGUILayout; }
  set{UnityPlayerHealth.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;



	}











}
public class Client{
public int frame;
public bool JustEntered = true;
	public int ID;
public Client()
	{JustEntered = false;
 frame = World.frame;
		UnityGameClient = UnityGameClient.Find();
		
}
		public System.Boolean Connect{  get { return UnityGameClient.Connect; }
 }
	public UnityGameClient UnityGameClient;
	public System.Boolean enabled{  get { return UnityGameClient.enabled; }
  set{UnityGameClient.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityGameClient.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityGameClient.hideFlags; }
  set{UnityGameClient.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityGameClient.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityGameClient.name; }
  set{UnityGameClient.name = value; }
 }
	public System.String tag{  get { return UnityGameClient.tag; }
  set{UnityGameClient.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityGameClient.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityGameClient.useGUILayout; }
  set{UnityGameClient.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;



	}











}
public class Server{
public int frame;
public bool JustEntered = true;
	public int ID;
public Server()
	{JustEntered = false;
 frame = World.frame;
		UnityGameServer = UnityGameServer.Find();
		
}
		public System.Int32 Connections{  get { return UnityGameServer.Connections; }
 }
	public System.Boolean Host{  get { return UnityGameServer.Host; }
 }
	public UnityGameServer UnityGameServer;
	public System.Boolean enabled{  get { return UnityGameServer.enabled; }
  set{UnityGameServer.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityGameServer.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityGameServer.hideFlags; }
  set{UnityGameServer.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityGameServer.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityGameServer.name; }
  set{UnityGameServer.name = value; }
 }
	public System.String tag{  get { return UnityGameServer.tag; }
  set{UnityGameServer.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityGameServer.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityGameServer.useGUILayout; }
  set{UnityGameServer.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;



	}











}
}                                                           