using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedInputObjectVenus : MonoBehaviour, TimedInputHandler  {


	AudioSource audio;
	GvrReticle GVR = new GvrReticle();

	// Use this for initialization
	bool flag = false;
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
		PlayerPrefs.SetInt ("VenusFlag", 0);
	}
}
