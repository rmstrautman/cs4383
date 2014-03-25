using UnityEngine;
using System.Collections;

public class GrouchoBehaviorScript : MonoBehaviour {

	public Animation walk;

	// Use this for initialization
	void Start () {
		Vector2 SS = renderer.material.mainTextureScale;
		SS.x = transform.localScale.x;
		SS.y = transform.localScale.y;
		renderer.material.mainTextureScale = SS;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w")) {
			walk.Play();
		}
	}
}
