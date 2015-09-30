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
		Players = (

Enumerable.Empty<Player>()).ToList<Player>();
		MainMenu = new Menu();
		Host = false;
		
}
		public System.Boolean Host;
	public Menu MainMenu;
	public List<Player> Players;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, World world) {
var t = System.DateTime.Now;

		MainMenu.Update(dt, world);
		for(int x0 = 0; x0 < Players.Count; x0++) { 
			Players[x0].Update(dt, world);
		}


	}











}
public class Player{
public int frame;
public bool JustEntered = true;
	public int ID;
public Player()
	{JustEntered = false;
 frame = World.frame;
		Identifier = 2;
		
}
		public System.Int32 Identifier;
	public void Update(float dt, World world) {
frame = World.frame;



	}











}
public class Ship{
public int frame;
public bool JustEntered = true;
	public int ID;
public Ship()
	{JustEntered = false;
 frame = World.frame;
		Health = 98;
		
}
		public System.Int32 Health;
	public void Update(float dt, World world) {
frame = World.frame;



	}











}
public class Menu{
public int frame;
public bool JustEntered = true;
	public int ID;
public Menu()
	{JustEntered = false;
 frame = World.frame;
		isHost = new Toggle("InstanceHost");
		UnityMenu = UnityMenu.Find();
		InstanceReady = new Button("Connect");
		
}
		public Button InstanceReady;
	public UnityMenu UnityMenu;
	public System.Boolean enabled{  get { return UnityMenu.enabled; }
  set{UnityMenu.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityMenu.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityMenu.hideFlags; }
  set{UnityMenu.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityMenu.isActiveAndEnabled; }
 }
	public Toggle isHost;
	public System.String name{  get { return UnityMenu.name; }
  set{UnityMenu.name = value; }
 }
	public System.String tag{  get { return UnityMenu.tag; }
  set{UnityMenu.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityMenu.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityMenu.useGUILayout; }
  set{UnityMenu.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;

		InstanceReady.Update(dt, world);
		isHost.Update(dt, world);
		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, World world){ 
	switch (s0)
	{

	case -1:
	if(isHost.Toggled)
	{

	goto case 0;	}else
	{

	goto case 1;	}
	case 0:
	InstanceReady.ButtonText = "Test";
	s0 = -1;
return;
	case 1:
	InstanceReady.ButtonText = "Whatever";
	s0 = -1;
return;	
	default: return;}}
	






}
public class Button{
public int frame;
public bool JustEntered = true;
private System.String n;
	public int ID;
public Button(System.String n)
	{JustEntered = false;
 frame = World.frame;
		UnityButton = UnityButton.Find(n);
		
}
		public System.String ButtonText{  get { return UnityButton.ButtonText; }
  set{UnityButton.ButtonText = value; }
 }
	public System.Boolean Clicked{  get { return UnityButton.Clicked; }
 }
	public UnityButton UnityButton;
	public System.Boolean enabled{  get { return UnityButton.enabled; }
  set{UnityButton.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityButton.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityButton.hideFlags; }
  set{UnityButton.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityButton.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityButton.name; }
  set{UnityButton.name = value; }
 }
	public System.String tag{  get { return UnityButton.tag; }
  set{UnityButton.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityButton.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityButton.useGUILayout; }
  set{UnityButton.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;



	}











}
public class Toggle{
public int frame;
public bool JustEntered = true;
private System.String n;
	public int ID;
public Toggle(System.String n)
	{JustEntered = false;
 frame = World.frame;
		UnityToggle = UnityToggle.Find(n);
		
}
		public System.Boolean Toggled{  get { return UnityToggle.Toggled; }
 }
	public UnityToggle UnityToggle;
	public System.Boolean enabled{  get { return UnityToggle.enabled; }
  set{UnityToggle.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityToggle.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityToggle.hideFlags; }
  set{UnityToggle.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityToggle.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityToggle.name; }
  set{UnityToggle.name = value; }
 }
	public System.String tag{  get { return UnityToggle.tag; }
  set{UnityToggle.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityToggle.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityToggle.useGUILayout; }
  set{UnityToggle.useGUILayout = value; }
 }
	public void Update(float dt, World world) {
frame = World.frame;



	}











}
}       