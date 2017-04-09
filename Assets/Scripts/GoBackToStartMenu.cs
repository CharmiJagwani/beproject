using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBackToStartMenu : MonoBehaviour , TimedInputHandler {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void HandleTimedInput()
	{
		Application.LoadLevel ("StartMenu");
	}
}
