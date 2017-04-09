using System.Collections;
using System.Collections;
using UnityEngine;

public class TimedInputObject : MonoBehaviour, TimedInputHandler {
	void Start () {
		GetComponent<Renderer> ().material.color = Color.white;
	}

	// Update is called once per frame
	void Update () {

	}

	public void HandleTimedInput()
	{
		PlayerPrefs.SetInt ("PlanetCount", 1);
		PlayerPrefs.SetInt ("PlayerScore", 1);
		PlayerPrefs.SetInt ("flag1", 0);
		PlayerPrefs.SetInt ("flag2", 0);
		PlayerPrefs.SetInt ("flag3", 0);
		PlayerPrefs.SetInt ("flag4", 0);
		PlayerPrefs.SetInt ("flag5", 0);
		Application.LoadLevel ("SolarVR");
	}
}
