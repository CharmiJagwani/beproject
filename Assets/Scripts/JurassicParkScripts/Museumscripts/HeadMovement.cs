using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMovement : MonoBehaviour {
	public bool move;
	public float speed = 3.0f;
	public float toggleAngle = 30.0f;
	public Transform vrCamera;
	private CharacterController cc;
	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (vrCamera.eulerAngles.x > toggleAngle) {
			move = true;
		}
		else {
			move = false;
		}
		if (move) {
			Vector3 forward = vrCamera.TransformDirection (Vector3.forward);
			cc.SimpleMove (forward * speed);
		}
	}
}
