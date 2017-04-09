using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedInputObjectSun : MonoBehaviour, TimedInputHandler {

	AudioSource audio;
	GvrReticle GVR = new GvrReticle();
	SolarVRList List = new SolarVRList ();
	public int sun = 1;
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
		sun = 0;
	}
}
