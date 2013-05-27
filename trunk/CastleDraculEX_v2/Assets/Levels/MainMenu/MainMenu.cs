using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	public GUISkin skin;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		GUI.skin = skin;
		int boxY = 70;
		int boxX = 120;
		int y_offset = 250;
		
		if (GUI.Button (new Rect ((Screen.width - boxX)/2,y_offset,boxX,boxY), "Start")) {
			Application.LoadLevel("main");	
		}

	}
}
