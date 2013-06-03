using UnityEngine;
using System.Collections;

public class HealthBarScript : MonoBehaviour {

	public float barDisplay; //current progress
    public Vector2 pos = new Vector2(5,5);
    public Vector2 size = new Vector2(1,20);
    public Texture2D emptyTex;
    public Texture2D fullTex;
	
	void Start() {
		
		emptyTex.wrapMode = TextureWrapMode.Repeat;
		fullTex.wrapMode = TextureWrapMode.Repeat;
		barDisplay = 300;
	}
 
    void OnGUI() {
		GUI.DrawTexture(new Rect(pos.x, pos.y, pos.x+size.x, pos.y+size.y), emptyTex, ScaleMode.StretchToFill, false, 10.0F);
		GUI.DrawTexture(new Rect(pos.x, pos.y, pos.x+barDisplay, pos.y+size.y), fullTex, ScaleMode.StretchToFill, false, 10.0F);

    }
 
    void Update() {
       //for this example, the bar display is linked to the current time,
       //however you would set this value based on your desired display
       //eg, the loading progress, the player's health, or whatever.
       //barDisplay = 100;
   		Component playerHealthScript = GameObject.FindWithTag("Player").GetComponent("PlayerControl");
		PlayerControl pc = (PlayerControl) playerHealthScript;
		barDisplay = pc.Health * 3;
    }
}
