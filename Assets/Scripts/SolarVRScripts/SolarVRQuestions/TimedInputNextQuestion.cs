using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedInputNextQuestion : MonoBehaviour , TimedInputHandler {
	GvrReticle scoreScript = new GvrReticle();
	public int Score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void HandleTimedInput()
	{
		string Scenename = Application.loadedLevelName;
		if (Scenename == "SolarVRQuestion1" &&  PlayerPrefs.GetInt ("flag1") == 1) {
			Application.LoadLevel ("SolarVRQuestion2");
		}
		if (Scenename == "SolarVRQuestion2" &&  PlayerPrefs.GetInt ("flag2") == 1) {
			Application.LoadLevel ("SolarVRQuestion3");
		}
		if (Scenename == "SolarVRQuestion3" &&  PlayerPrefs.GetInt ("flag3") == 1) {
			Application.LoadLevel ("SolarVRQuestion4");
		}
		if (Scenename == "SolarVRQuestion4" &&  PlayerPrefs.GetInt ("flag4") == 1) {
			Application.LoadLevel ("SolarVRQuestion5");
		}
		if (Scenename == "SolarVRQuestion5" &&  PlayerPrefs.GetInt ("flag5") == 1) {
			Application.LoadLevel ("SolarVRQuestionsScore");
		}
	}
}
