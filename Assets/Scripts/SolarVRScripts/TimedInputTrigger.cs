using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedInputTrigger : MonoBehaviour, TimedInputHandler  {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HandleTimedInput()
	{
		Application.LoadLevel ("SolarVRQuestion1");
	}
}
