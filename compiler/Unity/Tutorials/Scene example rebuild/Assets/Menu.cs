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
		StartButton = (new Nothing<ButtonGUI>());
		QuitButton = (new Nothing<ButtonGUI>());
		Highscore = (new Nothing<ButtonGUI>());
		Highs = (new Nothing<HighScore>());
		Credits = (new Nothing<ButtonGUI>());
		BackToMenuButton = (new Nothing<ButtonGUI>());
		
}
		public Option<ButtonGUI> BackToMenuButton;
	public Option<ButtonGUI> Credits;
	public Option<HighScore> Highs;
	public Option<ButtonGUI> Highscore;
	public System.Int32 LL{  get { return UnityMenu.LL; }
  set{UnityMenu.LL = value; }
 }
	public System.String NextScene{  get { return UnityMenu.NextScene; }
  set{UnityMenu.NextScene = value; }
 }
	public Option<ButtonGUI> QuitButton;
	public Option<ButtonGUI> StartButton;
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
	public System.Single count_down3;
	public System.Single count_down2;
	public System.Single count_down1;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, Menu world) {
var t = System.DateTime.Now;

if(Highs.IsSome){ 		Highs.Value.Update(dt, world);
 } 
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
	}





	int s0=-1;
	public void Rule0(float dt, Menu world){ 
	switch (s0)
	{

	case -1:
	if(((LL) == (0)))
	{

	goto case 1;	}else
	{

	s0 = -1;
return;	}
	case 1:
	StartButton = (new Just<ButtonGUI>(new ButtonGUI("Canvas/Play")));
	QuitButton = (new Just<ButtonGUI>(new ButtonGUI("Canvas/Quit")));
	Credits = (new Just<ButtonGUI>(new ButtonGUI("Canvas/Credits")));
	Highscore = (new Just<ButtonGUI>(new ButtonGUI("Canvas/HighScore")));
	s0 = 2;
return;
	case 2:
	if(!(false))
	{

	s0 = 2;
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
	if(((LL) == (2)))
	{

	goto case 5;	}else
	{

	s1 = -1;
return;	}
	case 5:
	StartButton = (new Just<ButtonGUI>(new ButtonGUI("Canvas/Play")));
	BackToMenuButton = (new Just<ButtonGUI>(new ButtonGUI("Canvas/Back_To_Menu")));
	s1 = 6;
return;
	case 6:
	if(!(false))
	{

	s1 = 6;
return;	}else
	{

	s1 = -1;
return;	}	
	default: return;}}
	

	int s2=-1;
	public void Rule2(float dt, Menu world){ 
	switch (s2)
	{

	case -1:
	if(((LL) == (3)))
	{

	goto case 9;	}else
	{

	s2 = -1;
return;	}
	case 9:
	BackToMenuButton = (new Just<ButtonGUI>(new ButtonGUI("Canvas/Back_To_Menu")));
	s2 = 10;
return;
	case 10:
	if(!(false))
	{

	s2 = 10;
return;	}else
	{

	s2 = -1;
return;	}	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, Menu world){ 
	switch (s3)
	{

	case -1:
	if(!(((LL) == (2))))
	{

	s3 = -1;
return;	}else
	{

	goto case 2;	}
	case 2:
	UnityEngine.Debug.Log("highscore create");
	Highs = (new Just<HighScore>(new HighScore()));
	s3 = 0;
return;
	case 0:
	if(!(false))
	{

	s3 = 0;
return;	}else
	{

	s3 = -1;
return;	}	
	default: return;}}
	

	int s4=-1;
	public void Rule4(float dt, Menu world){ 
	switch (s4)
	{

	case -1:
	begin_a = "";
	s4 = 0;
return;
	case 0:
	if(!(false))
	{

	s4 = 0;
return;	}else
	{

	s4 = -1;
return;	}	
	default: return;}}
	

	int s5=-1;
	public void Rule5(float dt, Menu world){ 
	switch (s5)
	{

	case -1:
	if(!(QuitButton.IsSome))
	{

	s5 = -1;
return;	}else
	{

	goto case 2;	}
	case 2:
	if(!(QuitButton.Value.IsPressed))
	{

	s5 = 2;
return;	}else
	{

	goto case 1;	}
	case 1:
	UnityEngine.Debug.Log("bye bye");
	NextScene = "Quit";
	s5 = -1;
return;	
	default: return;}}
	

	int s6=-1;
	public void Rule6(float dt, Menu world){ 
	switch (s6)
	{

	case -1:
	if(!(Highscore.IsSome))
	{

	s6 = -1;
return;	}else
	{

	goto case 2;	}
	case 2:
	if(!(Highscore.Value.IsPressed))
	{

	s6 = 2;
return;	}else
	{

	goto case 1;	}
	case 1:
	LL = 2;
	s6 = 0;
return;
	case 0:
	if(!(false))
	{

	s6 = 0;
return;	}else
	{

	s6 = -1;
return;	}	
	default: return;}}
	

	int s7=-1;
	public void Rule7(float dt, Menu world){ 
	switch (s7)
	{

	case -1:
	if(!(Credits.IsSome))
	{

	s7 = -1;
return;	}else
	{

	goto case 2;	}
	case 2:
	if(!(Credits.Value.IsPressed))
	{

	s7 = 2;
return;	}else
	{

	goto case 1;	}
	case 1:
	LL = 3;
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
	

	int s8=-1;
	public void Rule8(float dt, Menu world){ 
	switch (s8)
	{

	case -1:
	if(!(BackToMenuButton.IsSome))
	{

	s8 = -1;
return;	}else
	{

	goto case 2;	}
	case 2:
	if(!(BackToMenuButton.Value.IsPressed))
	{

	s8 = 2;
return;	}else
	{

	goto case 1;	}
	case 1:
	LL = 0;
	s8 = 0;
return;
	case 0:
	if(!(false))
	{

	s8 = 0;
return;	}else
	{

	s8 = -1;
return;	}	
	default: return;}}
	

	int s9=-1;
	public void Rule9(float dt, Menu world){ 
	switch (s9)
	{

	case -1:
	if(!(StartButton.IsSome))
	{

	s9 = -1;
return;	}else
	{

	goto case 12;	}
	case 12:
	if(!(StartButton.Value.IsPressed))
	{

	s9 = 12;
return;	}else
	{

	goto case 11;	}
	case 11:
	UnityEngine.Debug.Log("starting the game");
	NextScene = "Loading";
	s9 = 9;
return;
	case 9:
	NextScene = "countDown3";
	s9 = 7;
return;
	case 7:
	count_down3 = 1f;
	goto case 8;
	case 8:
	if(((count_down3) > (0f)))
	{

	count_down3 = ((count_down3) - (dt));
	s9 = 8;
return;	}else
	{

	goto case 6;	}
	case 6:
	NextScene = "countDown2";
	s9 = 4;
return;
	case 4:
	count_down2 = 1f;
	goto case 5;
	case 5:
	if(((count_down2) > (0f)))
	{

	count_down2 = ((count_down2) - (dt));
	s9 = 5;
return;	}else
	{

	goto case 3;	}
	case 3:
	NextScene = "countDown1";
	s9 = 1;
return;
	case 1:
	count_down1 = 0.8f;
	goto case 2;
	case 2:
	if(((count_down1) > (0f)))
	{

	count_down1 = ((count_down1) - (dt));
	s9 = 2;
return;	}else
	{

	goto case 0;	}
	case 0:
	NextScene = "NextScene";
	s9 = -1;
return;	
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
public class HighScore{
public int frame;
public bool JustEntered = true;
	public int ID;
public HighScore()
	{JustEntered = false;
 frame = Menu.frame;
		unityhighscore = unityhighscore.instantiate();
		
}
		public System.Boolean Box{  get { return unityhighscore.Box; }
  set{unityhighscore.Box = value; }
 }
	public System.Boolean enabled{  get { return unityhighscore.enabled; }
  set{unityhighscore.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return unityhighscore.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return unityhighscore.hideFlags; }
  set{unityhighscore.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return unityhighscore.isActiveAndEnabled; }
 }
	public System.String name{  get { return unityhighscore.name; }
  set{unityhighscore.name = value; }
 }
	public System.String tag{  get { return unityhighscore.tag; }
  set{unityhighscore.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return unityhighscore.transform; }
 }
	public unityhighscore unityhighscore;
	public System.Boolean useGUILayout{  get { return unityhighscore.useGUILayout; }
  set{unityhighscore.useGUILayout = value; }
 }
	public void Update(float dt, Menu world) {
frame = Menu.frame;

		this.Rule0(dt, world);

	}





	int s0=-1;
	public void Rule0(float dt, Menu world){ 
	switch (s0)
	{

	case -1:
	Box = true;
	s0 = 4;
return;
	case 4:
	UnityEngine.Debug.Log("boxie create");
	goto case 3;
	case 3:
	if(!(world.StartButton.Value.IsPressed))
	{

	s0 = 3;
return;	}else
	{

	goto case 2;	}
	case 2:
	UnityEngine.Debug.Log("start is pressed");
	Box = false;
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
}                                  