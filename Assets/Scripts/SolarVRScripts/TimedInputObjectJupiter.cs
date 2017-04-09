using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedInputObjectJupiter : MonoBehaviour, TimedInputHandler {

	AudioSource audio;
	// Use this for initialization
	bool flag = false;
	GvrReticle GVR = new GvrReticle();
	void Start () {

	}
	// Update is called once per frame
	void Update () {

	}

	public void HandleTimedInput()
	{
		audio = GetComponent<AudioSource> ();
		audio.Play ();
		if (flag == false) 
		{
			flag = true;
			GVR.count1 ();
		}
		PlayerPrefs.SetInt ("JupiterFlag", 0);
	}
}
