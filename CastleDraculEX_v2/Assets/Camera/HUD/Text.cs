using UnityEngine;
using System.Collections;

public class Text : MonoBehaviour {
	
	public string displaytext = " ";
	Rect myBackground = new Rect (25, 25, 100, 30);
	GUIStyle style = new GUIStyle();
	
	void Start () { 
		style.wordWrap = true;
		style.normal.textColor = Color.white;
	}
	
	void Update() {
		myBackground.width = displaytext.Length * 10;
	}
	
	void OnGUI() {
		GUI.Label(myBackground, displaytext, style);	
	}
}
