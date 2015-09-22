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
		WinConditionField = new CnvInputField("MenuUI/WinConditionText/InputField");
		TurnDurationField = new CnvInputField("MenuUI/TurnDurationText/InputField");
		StartingResourcesField = new CnvInputField("MenuUI/StartingResourcesText/InputField");
		QuitButton = new CnvButton("MenuUI/QuitButton");
		PlayerCountField = new CnvInputField("MenuUI/PlayerCountText/InputField");
		PlayButton = new CnvButton("MenuUI/PlayButton");
		Planet = new MenuPlanet("MenuPlanet");
		MiningRateField = new CnvInputField("MenuUI/MiningRateText/InputField");
		MessageCostField = new CnvInputField("MenuUI/MessageCostText/InputField");
		MapSizeField = new CnvInputField("MenuUI/MapSizeText/InputField");
		MapSeedField = new CnvInputField("MenuUI/MapSeedText/InputField");
		LoadingText = new CnvText("LoadingCanvas/LoadingText");
		Loading = false;
		BlackScreen = new CnvPanel("LoadingCanvas/BlackCanvas/LoadingScreen");
		
}
		public CnvPanel BlackScreen;
	public System.Boolean Loading;
	public CnvText LoadingText;
	public CnvInputField MapSeedField;
	public CnvInputField MapSizeField;
	public CnvInputField MessageCostField;
	public CnvInputField MiningRateField;
	public MenuPlanet Planet;
	public CnvButton __PlayButton;
	public CnvButton PlayButton{  get { return  __PlayButton; }
  set{ __PlayButton = value;
 if(!value.JustEntered) __PlayButton = value; 
 else{ value.JustEntered = false;
}
 }
 }
	public CnvInputField PlayerCountField;
	public CnvButton __QuitButton;
	public CnvButton QuitButton{  get { return  __QuitButton; }
  set{ __QuitButton = value;
 if(!value.JustEntered) __QuitButton = value; 
 else{ value.JustEntered = false;
}
 }
 }
	public CnvInputField StartingResourcesField;
	public CnvInputField TurnDurationField;
	public CnvInputField WinConditionField;
	public System.Single ___lifetime00;
	public System.Int32 ___startingResources30;
	public System.Int32 ___turnDuration30;
	public System.Int32 ___playerCount30;
	public System.Int32 ___winCondition30;
	public System.Int32 ___messageCost30;
	public System.Int32 ___miningRate30;
	public System.Int32 ___mapSize30;
	public System.Int32 ___mapSize31;
	public System.Int32 ___mapSeed30;

System.DateTime init_time = System.DateTime.Now;
	public void Update(float dt, Menu world) {
var t = System.DateTime.Now;

		BlackScreen.Update(dt, world);
		LoadingText.Update(dt, world);
		MapSeedField.Update(dt, world);
		MapSizeField.Update(dt, world);
		MessageCostField.Update(dt, world);
		MiningRateField.Update(dt, world);
		Planet.Update(dt, world);
		PlayButton.Update(dt, world);
		PlayerCountField.Update(dt, world);
		QuitButton.Update(dt, world);
		StartingResourcesField.Update(dt, world);
		TurnDurationField.Update(dt, world);
		WinConditionField.Update(dt, world);
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
		this.Rule14(dt, world);
		this.Rule15(dt, world);
		this.Rule16(dt, world);
		this.Rule17(dt, world);
		this.Rule18(dt, world);
		this.Rule19(dt, world);
	}





	int s0=-1;
	public void Rule0(float dt, Menu world){ 
	switch (s0)
	{

	case -1:
	if(!(PlayButton.Clicked))
	{

	s0 = -1;
return;	}else
	{

	goto case 6;	}
	case 6:
	LoadingText.Alpha = LoadingText.Alpha;
	BlackScreen.Alpha = BlackScreen.Alpha;
	Loading = true;
	s0 = 5;
return;
	case 5:
	___lifetime00 = 2f;
	goto case 2;
	case 2:
	if(!(((1f) > (BlackScreen.Alpha))))
	{

	goto case 1;	}else
	{

	goto case 3;	}
	case 3:
	LoadingText.Alpha = 0f;
	BlackScreen.Alpha = ((BlackScreen.Alpha) + (((((1f) / (___lifetime00))) * (dt))));
	Loading = Loading;
	s0 = 2;
return;
	case 1:
	LoadingText.Alpha = 1f;
	BlackScreen.Alpha = 1f;
	Loading = Loading;
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
	LoadingText.Alpha = 0f;
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
	public void Rule2(float dt, Menu world){ 
	switch (s2)
	{

	case -1:
	if(!(((QuitButton.Clicked) && (!(Loading)))))
	{

	s2 = -1;
return;	}else
	{

	goto case 1;	}
	case 1:
	QuitButton.Clicked = false;
	s2 = 0;
return;
	case 0:
	UnityEngine.Application.Quit();
	s2 = -1;
return;	
	default: return;}}
	

	int s3=-1;
	public void Rule3(float dt, Menu world){ 
	switch (s3)
	{

	case -1:
	if(!(PlayButton.Clicked))
	{

	s3 = -1;
return;	}else
	{

	goto case 12;	}
	case 12:
	___startingResources30 = GameUtils.StringToInt(StartingResourcesField.Text);
	___turnDuration30 = GameUtils.StringToInt(TurnDurationField.Text);
	___playerCount30 = GameUtils.StringToInt(PlayerCountField.Text);
	___winCondition30 = GameUtils.StringToInt(WinConditionField.Text);
	___messageCost30 = GameUtils.StringToInt(MessageCostField.Text);
	___miningRate30 = GameUtils.StringToInt(MiningRateField.Text);
	___mapSize30 = GameUtils.StringToInt(MapSizeField.Text);
	___mapSize31 = UnityEngine.Mathf.Max(___mapSize30,___playerCount30);
	___mapSeed30 = GameUtils.StringToInt(MapSeedField.Text);
	GameSettings.SetParameters(___startingResources30,___turnDuration30,___playerCount30,___winCondition30,___messageCost30,___miningRate30,___mapSize31,___mapSeed30);
	goto case 2;
	case 2:
	if(!(((((LoadingText.Alpha) == (1f))) && (((BlackScreen.Alpha) == (1f))))))
	{

	s3 = 2;
return;	}else
	{

	goto case 1;	}
	case 1:
	PlayButton.Clicked = false;
	s3 = 0;
return;
	case 0:
	UnityEngine.Application.LoadLevel("contact");
	s3 = -1;
return;	
	default: return;}}
	

	int s4=-1;
	public void Rule4(float dt, Menu world){ 
	switch (s4)
	{

	case -1:
	MapSeedField.Text = GameUtils.IntToString(UnityEngine.Random.Range(0,100000));
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
	MapSizeField.Text = GameUtils.IntToString(4);
	s5 = 0;
return;
	case 0:
	if(!(false))
	{

	s5 = 0;
return;	}else
	{

	s5 = -1;
return;	}	
	default: return;}}
	

	int s6=-1;
	public void Rule6(float dt, Menu world){ 
	switch (s6)
	{

	case -1:
	MiningRateField.Text = GameUtils.IntToString(25);
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
	MessageCostField.Text = GameUtils.IntToString(300);
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
	WinConditionField.Text = GameUtils.IntToString(500);
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
	PlayerCountField.Text = GameUtils.IntToString(4);
	s9 = 0;
return;
	case 0:
	if(!(false))
	{

	s9 = 0;
return;	}else
	{

	s9 = -1;
return;	}	
	default: return;}}
	

	int s10=-1;
	public void Rule10(float dt, Menu world){ 
	switch (s10)
	{

	case -1:
	TurnDurationField.Text = GameUtils.IntToString(120);
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
	public void Rule11(float dt, Menu world){ 
	switch (s11)
	{

	case -1:
	StartingResourcesField.Text = GameUtils.IntToString(500);
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
	public void Rule12(float dt, Menu world){ 
	switch (s12)
	{

	case -1:
	MapSeedField.MaxValue = 100000;
	MapSeedField.MinValue = 0;
	s12 = 0;
return;
	case 0:
	if(!(false))
	{

	s12 = 0;
return;	}else
	{

	s12 = -1;
return;	}	
	default: return;}}
	

	int s13=-1;
	public void Rule13(float dt, Menu world){ 
	switch (s13)
	{

	case -1:
	MapSizeField.MaxValue = 1000;
	MapSizeField.MinValue = 2;
	s13 = 0;
return;
	case 0:
	if(!(false))
	{

	s13 = 0;
return;	}else
	{

	s13 = -1;
return;	}	
	default: return;}}
	

	int s14=-1;
	public void Rule14(float dt, Menu world){ 
	switch (s14)
	{

	case -1:
	MiningRateField.MaxValue = 5000;
	MiningRateField.MinValue = 1;
	s14 = 0;
return;
	case 0:
	if(!(false))
	{

	s14 = 0;
return;	}else
	{

	s14 = -1;
return;	}	
	default: return;}}
	

	int s15=-1;
	public void Rule15(float dt, Menu world){ 
	switch (s15)
	{

	case -1:
	MessageCostField.MaxValue = 5000;
	MessageCostField.MinValue = 0;
	s15 = 0;
return;
	case 0:
	if(!(false))
	{

	s15 = 0;
return;	}else
	{

	s15 = -1;
return;	}	
	default: return;}}
	

	int s16=-1;
	public void Rule16(float dt, Menu world){ 
	switch (s16)
	{

	case -1:
	WinConditionField.MaxValue = 9000;
	WinConditionField.MinValue = 100;
	s16 = 0;
return;
	case 0:
	if(!(false))
	{

	s16 = 0;
return;	}else
	{

	s16 = -1;
return;	}	
	default: return;}}
	

	int s17=-1;
	public void Rule17(float dt, Menu world){ 
	switch (s17)
	{

	case -1:
	PlayerCountField.MaxValue = 100;
	PlayerCountField.MinValue = 2;
	s17 = 0;
return;
	case 0:
	if(!(false))
	{

	s17 = 0;
return;	}else
	{

	s17 = -1;
return;	}	
	default: return;}}
	

	int s18=-1;
	public void Rule18(float dt, Menu world){ 
	switch (s18)
	{

	case -1:
	TurnDurationField.MaxValue = 600;
	TurnDurationField.MinValue = 30;
	s18 = 0;
return;
	case 0:
	if(!(false))
	{

	s18 = 0;
return;	}else
	{

	s18 = -1;
return;	}	
	default: return;}}
	

	int s19=-1;
	public void Rule19(float dt, Menu world){ 
	switch (s19)
	{

	case -1:
	StartingResourcesField.MaxValue = 9000;
	StartingResourcesField.MinValue = 0;
	s19 = 0;
return;
	case 0:
	if(!(false))
	{

	s19 = 0;
return;	}else
	{

	s19 = -1;
return;	}	
	default: return;}}
	





}
public class MenuPlanet{
public int frame;
public bool JustEntered = true;
private System.String n;
	public int ID;
public MenuPlanet(System.String n)
	{JustEntered = false;
 frame = Menu.frame;
		UnityPlanet = UnityPlanet.Find(n);
		RotationVelocity = new UnityEngine.Vector3(0f,3f,0f);
		
}
		public System.Boolean ClickedOver{  get { return UnityPlanet.ClickedOver; }
 }
	public UnityEngine.Color OwnerColor{  get { return UnityPlanet.OwnerColor; }
  set{UnityPlanet.OwnerColor = value; }
 }
	public UnityEngine.Vector3 Position{  get { return UnityPlanet.Position; }
  set{UnityPlanet.Position = value; }
 }
	public UnityEngine.Quaternion Rotation{  get { return UnityPlanet.Rotation; }
  set{UnityPlanet.Rotation = value; }
 }
	public UnityEngine.Vector3 RotationVelocity;
	public System.Boolean Selected{  get { return UnityPlanet.Selected; }
  set{UnityPlanet.Selected = value; }
 }
	public UnityEngine.Color TargetingPlayerColor{  get { return UnityPlanet.TargetingPlayerColor; }
  set{UnityPlanet.TargetingPlayerColor = value; }
 }
	public UnityPlanet UnityPlanet;
	public System.Boolean enabled{  get { return UnityPlanet.enabled; }
  set{UnityPlanet.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityPlanet.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityPlanet.hideFlags; }
  set{UnityPlanet.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityPlanet.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityPlanet.name; }
  set{UnityPlanet.name = value; }
 }
	public System.String tag{  get { return UnityPlanet.tag; }
  set{UnityPlanet.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityPlanet.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityPlanet.useGUILayout; }
  set{UnityPlanet.useGUILayout = value; }
 }
	public void Update(float dt, Menu world) {
frame = Menu.frame;		this.Rule1(dt, world);

		this.Rule0(dt, world);

	}

	public void Rule1(float dt, Menu world) 
	{
	Rotation = (UnityEngine.Quaternion.Euler((RotationVelocity) * (dt))) * (Rotation);
	}
	




	int s0=-1;
	public void Rule0(float dt, Menu world){ 
	switch (s0)
	{

	case -1:
	OwnerColor = new UnityEngine.Color(0,0,0,0);
	TargetingPlayerColor = new UnityEngine.Color(0,0,0,0);
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
public class CnvButton{
public int frame;
public bool JustEntered = true;
private System.String n;
	public int ID;
public CnvButton(System.String n)
	{JustEntered = false;
 frame = Menu.frame;
		UnityButton = UnityButton.GetButton(n);
		
}
		public System.Boolean Active{  get { return UnityButton.Active; }
  set{UnityButton.Active = value; }
 }
	public System.Boolean Clicked{  get { return UnityButton.Clicked; }
  set{UnityButton.Clicked = value; }
 }
	public System.Boolean Disabled{  get { return UnityButton.Disabled; }
  set{UnityButton.Disabled = value; }
 }
	public System.String ImageName{  get { return UnityButton.ImageName; }
  set{UnityButton.ImageName = value; }
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
public class CnvSelectionBox{
public int frame;
public bool JustEntered = true;
private System.String n;
	public int ID;
public CnvSelectionBox(System.String n)
	{JustEntered = false;
 frame = Menu.frame;
		UnitySelectionBox = UnitySelectionBox.GetBox(n);
		
}
		public System.Boolean Active{  get { return UnitySelectionBox.Active; }
  set{UnitySelectionBox.Active = value; }
 }
	public System.Boolean Clicked{  get { return UnitySelectionBox.Clicked; }
  set{UnitySelectionBox.Clicked = value; }
 }
	public System.Boolean Disabled{  get { return UnitySelectionBox.Disabled; }
  set{UnitySelectionBox.Disabled = value; }
 }
	public System.String ImageName{  get { return UnitySelectionBox.ImageName; }
  set{UnitySelectionBox.ImageName = value; }
 }
	public UnitySelectionBox UnitySelectionBox;
	public System.Boolean enabled{  get { return UnitySelectionBox.enabled; }
  set{UnitySelectionBox.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnitySelectionBox.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnitySelectionBox.hideFlags; }
  set{UnitySelectionBox.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnitySelectionBox.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnitySelectionBox.name; }
  set{UnitySelectionBox.name = value; }
 }
	public System.String tag{  get { return UnitySelectionBox.tag; }
  set{UnitySelectionBox.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnitySelectionBox.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnitySelectionBox.useGUILayout; }
  set{UnitySelectionBox.useGUILayout = value; }
 }
	public void Update(float dt, Menu world) {
frame = Menu.frame;



	}











}
public class CnvText{
public int frame;
public bool JustEntered = true;
private System.String n;
	public int ID;
public CnvText(System.String n)
	{JustEntered = false;
 frame = Menu.frame;
		UnityText = UnityText.GetText(n);
		
}
		public System.Single Alpha{  get { return UnityText.Alpha; }
  set{UnityText.Alpha = value; }
 }
	public System.String Text{  get { return UnityText.Text; }
  set{UnityText.Text = value; }
 }
	public UnityText UnityText;
	public System.Boolean enabled{  get { return UnityText.enabled; }
  set{UnityText.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityText.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityText.hideFlags; }
  set{UnityText.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityText.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityText.name; }
  set{UnityText.name = value; }
 }
	public System.String tag{  get { return UnityText.tag; }
  set{UnityText.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityText.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityText.useGUILayout; }
  set{UnityText.useGUILayout = value; }
 }
	public void Update(float dt, Menu world) {
frame = Menu.frame;



	}











}
public class IconInstantiation{
public int frame;
public bool JustEntered = true;
private UnityEngine.Vector3 position;
private System.String imageName;
private System.String parentPath;
	public int ID;
public IconInstantiation(UnityEngine.Vector3 position, System.String imageName, System.String parentPath)
	{JustEntered = false;
 frame = Menu.frame;
		Position = position;
		ParentPath = parentPath;
		ImageName = imageName;
		
}
		public System.String ImageName;
	public System.String ParentPath;
	public UnityEngine.Vector3 Position;
	public void Update(float dt, Menu world) {
frame = Menu.frame;



	}











}
public class CnvIcon{
public int frame;
public bool JustEntered = true;
private System.String n;
private Option<IconInstantiation> instantiate;
	public int ID;
public CnvIcon(System.String n, Option<IconInstantiation> instantiate)
	{JustEntered = false;
 frame = Menu.frame;
		UnityIcon ___icon00;
		if(instantiate.IsSome)
			{
			___icon00 = UnityIcon.Instantiate(n,instantiate.Value.ImageName,instantiate.Value.ParentPath,instantiate.Value.Position);
			}else
			{
			___icon00 = UnityIcon.GetIcon(n);
			}
		UnityIcon = ___icon00;
		
}
		public System.Boolean Active{  get { return UnityIcon.Active; }
  set{UnityIcon.Active = value; }
 }
	public UnityEngine.Color Color{  get { return UnityIcon.Color; }
  set{UnityIcon.Color = value; }
 }
	public System.Single Height{  get { return UnityIcon.Height; }
 }
	public System.String ImageName{  get { return UnityIcon.ImageName; }
  set{UnityIcon.ImageName = value; }
 }
	public UnityEngine.Vector2 Origin{  get { return UnityIcon.Origin; }
  set{UnityIcon.Origin = value; }
 }
	public System.String Text{  get { return UnityIcon.Text; }
  set{UnityIcon.Text = value; }
 }
	public UnityIcon UnityIcon;
	public System.Single Width{  get { return UnityIcon.Width; }
 }
	public System.Boolean enabled{  get { return UnityIcon.enabled; }
  set{UnityIcon.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityIcon.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityIcon.hideFlags; }
  set{UnityIcon.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityIcon.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityIcon.name; }
  set{UnityIcon.name = value; }
 }
	public System.String tag{  get { return UnityIcon.tag; }
  set{UnityIcon.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityIcon.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityIcon.useGUILayout; }
  set{UnityIcon.useGUILayout = value; }
 }
	public void Update(float dt, Menu world) {
frame = Menu.frame;



	}











}
public class CnvFrame{
public int frame;
public bool JustEntered = true;
private System.String n;
private Option<System.Single> offsetX;
private Option<System.Single> offsetY;
	public int ID;
public CnvFrame(System.String n, Option<System.Single> offsetX, Option<System.Single> offsetY)
	{JustEntered = false;
 frame = Menu.frame;
		System.Single ___offsetX00;
		if(offsetX.IsNone)
			{
			___offsetX00 = 0f;
			}else
			{
			___offsetX00 = offsetX.Value;
			}
		System.Single ___offsetY00;
		if(offsetY.IsNone)
			{
			___offsetY00 = 0f;
			}else
			{
			___offsetY00 = offsetY.Value;
			}
		UnityFrame = UnityFrame.GetFrame(n,___offsetX00,___offsetY00);
		
}
		public System.Single Height{  get { return UnityFrame.Height; }
 }
	public System.Single OffsetX{  get { return UnityFrame.OffsetX; }
  set{UnityFrame.OffsetX = value; }
 }
	public System.Single OffsetY{  get { return UnityFrame.OffsetY; }
  set{UnityFrame.OffsetY = value; }
 }
	public UnityEngine.Vector2 Origin{  get { return UnityFrame.Origin; }
 }
	public UnityFrame UnityFrame;
	public System.Single Width{  get { return UnityFrame.Width; }
 }
	public System.Boolean enabled{  get { return UnityFrame.enabled; }
  set{UnityFrame.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityFrame.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityFrame.hideFlags; }
  set{UnityFrame.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityFrame.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityFrame.name; }
  set{UnityFrame.name = value; }
 }
	public System.String tag{  get { return UnityFrame.tag; }
  set{UnityFrame.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityFrame.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityFrame.useGUILayout; }
  set{UnityFrame.useGUILayout = value; }
 }
	public void Update(float dt, Menu world) {
frame = Menu.frame;



	}











}
public class CnvToggle{
public int frame;
public bool JustEntered = true;
private System.String n;
	public int ID;
public CnvToggle(System.String n)
	{JustEntered = false;
 frame = Menu.frame;
		UnityToggle = UnityToggle.GetToggle(n);
		
}
		public System.Boolean IsOn{  get { return UnityToggle.IsOn; }
  set{UnityToggle.IsOn = value; }
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
	public void Update(float dt, Menu world) {
frame = Menu.frame;



	}











}
public class CnvPanel{
public int frame;
public bool JustEntered = true;
private System.String n;
	public int ID;
public CnvPanel(System.String n)
	{JustEntered = false;
 frame = Menu.frame;
		UnityPanel = UnityPanel.GetPanel(n);
		
}
		public System.Single Alpha{  get { return UnityPanel.Alpha; }
  set{UnityPanel.Alpha = value; }
 }
	public UnityPanel UnityPanel;
	public System.Boolean enabled{  get { return UnityPanel.enabled; }
  set{UnityPanel.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityPanel.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityPanel.hideFlags; }
  set{UnityPanel.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityPanel.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityPanel.name; }
  set{UnityPanel.name = value; }
 }
	public System.String tag{  get { return UnityPanel.tag; }
  set{UnityPanel.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityPanel.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityPanel.useGUILayout; }
  set{UnityPanel.useGUILayout = value; }
 }
	public void Update(float dt, Menu world) {
frame = Menu.frame;



	}











}
public class CnvInputField{
public int frame;
public bool JustEntered = true;
private System.String n;
	public int ID;
public CnvInputField(System.String n)
	{JustEntered = false;
 frame = Menu.frame;
		UnityInputField = UnityInputField.Find(n);
		
}
		public System.Int32 MaxValue{  get { return UnityInputField.MaxValue; }
  set{UnityInputField.MaxValue = value; }
 }
	public System.Int32 MinValue{  get { return UnityInputField.MinValue; }
  set{UnityInputField.MinValue = value; }
 }
	public System.String Text{  get { return UnityInputField.Text; }
  set{UnityInputField.Text = value; }
 }
	public UnityInputField UnityInputField;
	public System.Boolean enabled{  get { return UnityInputField.enabled; }
  set{UnityInputField.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return UnityInputField.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return UnityInputField.hideFlags; }
  set{UnityInputField.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return UnityInputField.isActiveAndEnabled; }
 }
	public System.String name{  get { return UnityInputField.name; }
  set{UnityInputField.name = value; }
 }
	public System.String tag{  get { return UnityInputField.tag; }
  set{UnityInputField.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return UnityInputField.transform; }
 }
	public System.Boolean useGUILayout{  get { return UnityInputField.useGUILayout; }
  set{UnityInputField.useGUILayout = value; }
 }
	public void Update(float dt, Menu world) {
frame = Menu.frame;



	}











}
public class CnvComboBox{
public int frame;
public bool JustEntered = true;
private System.String n;
	public int ID;
public CnvComboBox(System.String n)
	{JustEntered = false;
 frame = Menu.frame;
		ComboBox = ComboBox.Find(n);
		
}
		public System.Single ButtonDistance{  get { return ComboBox.ButtonDistance; }
 }
	public ComboBox ComboBox;
	public UnityEngine.GameObject RootCanvas{  get { return ComboBox.RootCanvas; }
 }
	public System.String SelectionName{  get { return ComboBox.SelectionName; }
 }
	public System.Boolean enabled{  get { return ComboBox.enabled; }
  set{ComboBox.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return ComboBox.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return ComboBox.hideFlags; }
  set{ComboBox.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return ComboBox.isActiveAndEnabled; }
 }
	public System.String name{  get { return ComboBox.name; }
  set{ComboBox.name = value; }
 }
	public System.String tag{  get { return ComboBox.tag; }
  set{ComboBox.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return ComboBox.transform; }
 }
	public System.Boolean useGUILayout{  get { return ComboBox.useGUILayout; }
  set{ComboBox.useGUILayout = value; }
 }
	public void Update(float dt, Menu world) {
frame = Menu.frame;



	}











}
public class CnvComboList{
public int frame;
public bool JustEntered = true;
private System.String n;
	public int ID;
public CnvComboList(System.String n)
	{JustEntered = false;
 frame = Menu.frame;
		ComboList = ComboList.Find(n);
		
}
		public System.Single ButtonDistance{  get { return ComboList.ButtonDistance; }
 }
	public System.Collections.Generic.List<UnityEngine.GameObject> Buttons{  get { return ComboList.Buttons; }
 }
	public ComboList ComboList;
	public System.Int32 CurrentSelectionIndex{  get { return ComboList.CurrentSelectionIndex; }
 }
	public UnityEngine.GameObject RootCanvas{  get { return ComboList.RootCanvas; }
 }
	public System.String SelectionName{  get { return ComboList.SelectionName; }
 }
	public System.Boolean enabled{  get { return ComboList.enabled; }
  set{ComboList.enabled = value; }
 }
	public UnityEngine.GameObject gameObject{  get { return ComboList.gameObject; }
 }
	public UnityEngine.HideFlags hideFlags{  get { return ComboList.hideFlags; }
  set{ComboList.hideFlags = value; }
 }
	public System.Boolean isActiveAndEnabled{  get { return ComboList.isActiveAndEnabled; }
 }
	public System.String name{  get { return ComboList.name; }
  set{ComboList.name = value; }
 }
	public System.String tag{  get { return ComboList.tag; }
  set{ComboList.tag = value; }
 }
	public UnityEngine.Transform transform{  get { return ComboList.transform; }
 }
	public System.Boolean useGUILayout{  get { return ComboList.useGUILayout; }
  set{ComboList.useGUILayout = value; }
 }
	public void Update(float dt, Menu world) {
frame = Menu.frame;



	}











}
}                          