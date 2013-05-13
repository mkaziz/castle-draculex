using UnityEngine;
using System.Collections;



public class TileSize : MonoBehaviour {
	int s_fact = 1;
	// Use this for initialization
	void Start () {
		float scaleX = transform.localScale.x;
       	float scaleY = transform.localScale.y;
		float myx = scaleX/s_fact;
		float myy = scaleY/s_fact;
        renderer.material.mainTextureScale = new Vector2 (myx, myy);
	
	}
	
	// Update is called once per frame
	void Update () {
	}
}
