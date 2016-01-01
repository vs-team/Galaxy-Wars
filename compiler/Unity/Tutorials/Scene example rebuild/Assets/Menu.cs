#pragma warning disable 162,108,618
using Casanova.Prelude;
using System.Linq;
using System;
using System.Collections.Generic;
using UnityEngine;
namespace Menu {public class Menu : MonoBehaviour{
public static int frame;
void Update () { Update(Time.deltaTime, this); 
 frame++; }
public bool JustEntered = true;


public void Start()
	{
		UnityMenu = new UnityMenu();
		StartButton = new ButtonGUI("Canvas/Play");
		QuitButton = new ButtonGUI("Canvas/Quit");
		
}
		public System.String NextScene{  get { return UnityMenu.NextScene; }
  set{UnityMenu.NextScene = value; }
 }
	public ButtonGUI __QuitButton;
	public ButtonGUI QuitButton{  get { return  __QuitButton; }
  set{ __QuitButton = value;
 if(!value.JustEntered) __QuitButton = value; 
 else{ value.JustEntered = false;
}
 }
 }
	public ButtonGUI __StartButton;
	public ButtonGUI StartButton{  get { return  __StartButton; }
  set{ __StartButton = value;
 if(!value.JustEntered) __StartButton = value; 
 else{ value.JustEntered = false;
}
 }
 }
	public UnityMenu UnityMenu;
	public System.String begin_a{  set{UnityMenu.begin_a = value; }
 }
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
	public System.Single count_down4;
	public System.Single count_down3;
	public System.Single count_down2;
	public System.Single count_down1;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, Menu world) {
var t = System.DateTime.Now;

		this.Rule0(dt, world);
		this.Rule1(dt, world);
		this.Rule2(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, Menu world){ 
	switch (s0)
	{

	case -1:
	begin_a = "";
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
	public void Rule1(float dt, Menu world){ 
	switch (s1)
	{

	case -1:
	if(!(QuitButton.IsPressed))
	{

	s1 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	UnityEngine.Debug.Log("bye bye");
	NextScene = "Quit";
	s1 = -1;
return;	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, Menu world){ 
	switch (s2)
	{

	case -1:
	if(!(StartButton.IsPressed))
	{

	s2 = -1;
return;	}else
	{

	goto case 13;	}
	case 13:
	UnityEngine.Debug.Log("starting the game");
	NextScene = "Loading";
	s2 = 11;
return;
	case 11:
	NextScene = "countDown3";
	s2 = 9;
return;
	case 9:
	count_down4 = 1f;
	goto case 10;
	case 10:
	if(((count_down4) > (0f)))
	{

	count_down4 = ((count_down4) - (dt));
	s2 = 10;
return;	}else
	{

	goto case 8;	}
	case 8:
	NextScene = "countDown2";
	s2 = 6;
return;
	case 6:
	count_down3 = 1f;
	goto case 7;
	case 7:
	if(((count_down3) > (0f)))
	{

	count_down3 = ((count_down3) - (dt));
	s2 = 7;
return;	}else
	{

	goto case 5;	}
	case 5:
	NextScene = "countDown1";
	s2 = 3;
return;
	case 3:
	count_down2 = 1f;
	goto case 4;
	case 4:
	if(((count_down2) > (0f)))
	{

	count_down2 = ((count_down2) - (dt));
	s2 = 4;
return;	}else
	{

	goto case 2;	}
	case 2:
	NextScene = "NextScene";
	s2 = 0;
return;
	case 0:
	count_down1 = dt;
	goto case 1;
	case 1:
	if(((count_down1) > (0f)))
	{

	count_down1 = ((count_down1) - (dt));
	s2 = 1;
return;	}else
	{

	s2 = -1;
return;	}	
	default: return;}}
	





}
public class ButtonGUI{
public int frame;
public bool JustEntered = true;
private System.String n;
	public int ID;
public ButtonGUI(System.String n)
	{JustEntered = false;
 frame = Menu.frame;
		UnityButton = UnityButton.Find(n);
		
}
		public System.Boolean IsPressed{  get { return UnityButton.IsPressed; }
  set{UnityButton.IsPressed = value; }
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
	public void Update(float dt, Menu world) {
frame = Menu.frame;



	}











}
}                        