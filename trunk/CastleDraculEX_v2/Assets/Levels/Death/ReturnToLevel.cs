using UnityEngine;
using System.Collections;

public class ReturnToLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public GUISkin skin;
	public string mainText = "...Can you hear me? I think we lost him...";
	public string mylevel = "Enter level passcode";
	string helpText = "You died.";
	
	void OnGUI() {
		GUI.skin = skin;
		int boxY = 70;
		int boxX = 120;
		int y_offset = -150;
		
		float xpos = (Screen.width - boxX)/2;
		float ypos = y_offset;
		
		GUILayout.BeginArea(new Rect (Screen.width/2-200, Screen.height/2 - 200, 400, 500));
			//GUILayout.Space(550);
			myLabel(mainText);
			myLabel(helpText);
			//GUILayout.Label ("...Can you hear me? I think we lost him...", GUILayout.ExpandWidth(false), GUILayout.ExpandHeight(false));
			mylevel = GUILayout.TextArea(mylevel, GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(false));
		
		if (GUILayout.Button("Go", GUILayout.ExpandWidth(true))) {
			if (mylevel == "pencil") {
				loadLevel("level3");
			}
			else if (mylevel == "firecracker") {
				loadLevel("level2");
			}
			else if (mylevel == "cheese") {
				loadLevel("main");	
			}
			else {
				helpText = "Not a valid password!";
			}
		}
		
		if (GUILayout.Button ("Restart", GUILayout.ExpandWidth(true))) {
			Application.LoadLevel("mainMenu");	
		}
		
		GUILayout.EndVertical();
            
	}
	
	float center(float n) {
		return (Screen.width - n)/2;
	}
	
	void loadLevel(string s) {
		Application.LoadLevel(s);		
	}
	
	void myLabel(string s) {
		GUILayout.Label (s, GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(false));	
	}
}
