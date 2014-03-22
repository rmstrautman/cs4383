using UnityEngine;
using System.Collections;

public class GrouchoBehaviorScript : MonoBehaviour {

	public Animation walk;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("w")) {
			walk.Play();
		}
	}
}
