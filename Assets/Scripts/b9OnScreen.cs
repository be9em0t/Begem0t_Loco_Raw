﻿
//Stolen from Attila

using UnityEngine;
using System.Collections;

public class b9OnScreen : MonoBehaviour {


	void OnGUI () {
		// Make a background box
		GUIStyle infoStyle = new GUIStyle();	
		infoStyle.fontSize = 9;
		infoStyle.font = GUI.skin.font;

        GUIStyle smallStyle = new GUIStyle();
        smallStyle.normal.textColor = Color.white;
        smallStyle.fontSize = 12;
        smallStyle.fontStyle = FontStyle.Bold;
        smallStyle.font = GUI.skin.font;

        GUIStyle mainStyle = new GUIStyle();
        mainStyle.normal.textColor = Color.white;
        mainStyle.fontStyle = FontStyle.Bold;
        mainStyle.fontSize = 12;
        mainStyle.font = GUI.skin.font;


//		GUI.Box(new Rect(10,10,100,90), "Hotkeys");

//		string s = player.speed.ToString();
//		string d = player.direction.ToString();
		
//		GUI.Box (new Rect (8,8,220,260), "Avatar Controller  (v"+version+")");
		
//		GUI.Label(new Rect(10, 25, 160,20), "Avatar: "+player.avatar.name);		
//		GUI.Label(new Rect(10,45, 100,20), "Speed:    "+s);		
//		GUI.Label(new Rect(10,55, 100,40), "Direction:"+d);
		
		GUI.Label(new Rect(10, 10, 200, 120), "KEYBOARD", mainStyle);
        GUI.Label(new Rect(10, 40, 200, 120), "Camera Left/Right : < >", smallStyle);
        GUI.Label(new Rect(10, 60, 200, 120), "Camera Up/Down : \" ?", smallStyle);
        GUI.Label(new Rect(10, 80, 200, 120), "Camera Zoom : PgUp PgDn", smallStyle);
        GUI.Label(new Rect(10, 100, 200, 120), "Reset Camera: Home", smallStyle);
        GUI.Label(new Rect(10, 120,200,120), "         --------" , smallStyle);
        GUI.Label(new Rect(10, 140, 200, 120), "Move avatar : Arrows, WASD", mainStyle);
        GUI.Label(new Rect(10, 160, 200, 120), "SpeedUp : LeftShift", mainStyle);
        GUI.Label(new Rect(10, 180, 200, 120), "Change Idle : I key", mainStyle);


//		GUI.Label(new Rect(10,130, 160,120), "Z/X: Zoom camera");
//		GUI.Label(new Rect(10,150, 160,120), "R  : Reset avatar");

	}
}