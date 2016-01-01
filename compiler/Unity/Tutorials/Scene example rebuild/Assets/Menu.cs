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
	public UnityEngine.Texture backgroundTexture{  get { return UnityMenu.backgroundTexture; }
  set{UnityMenu.backgroundTexture = value; }
 }
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
	public System.Single count_down6;
	public System.Single count_down5;
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

	goto case 17;	}
	case 17:
	UnityEngine.Debug.Log("starting the game");
	NextScene = "Loading";
	s2 = 15;
return;
	case 15:
	NextScene = "countDown3";
	s2 = 13;
return;
	case 13:
	count_down6 = 1f;
	goto case 14;
	case 14:
	if(((count_down6) > (0f)))
	{

	count_down6 = ((count_down6) - (dt));
	s2 = 14;
return;	}else
	{

	goto case 12;	}
	case 12:
	NextScene = "countDown2";
	s2 = 10;
return;
	case 10:
	count_down5 = 1f;
	goto case 11;
	case 11:
	if(((count_down5) > (0f)))
	{

	count_down5 = ((count_down5) - (dt));
	s2 = 11;
return;	}else
	{

	goto case 9;	}
	case 9:
	NextScene = "countDown1";
	s2 = 7;
return;
	case 7:
	count_down4 = 0.8f;
	goto case 8;
	case 8:
	if(((count_down4) > (0f)))
	{

	count_down4 = ((count_down4) - (dt));
	s2 = 8;
return;	}else
	{

	goto case 6;	}
	case 6:
	NextScene = "NextScene";
	s2 = 4;
return;
	case 4:
	count_down3 = dt;
	goto case 5;
	case 5:
	if(((count_down3) > (0f)))
	{

	count_down3 = ((count_down3) - (dt));
	s2 = 5;
return;	}else
	{

	goto case 2;	}
	case 2:
	count_down2 = dt;
	goto case 3;
	case 3:
	if(((count_down2) > (0f)))
	{

	count_down2 = ((count_down2) - (dt));
	s2 = 3;
return;	}else
	{

	goto case 0;	}
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