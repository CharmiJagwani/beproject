using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedInputObjectO4 : MonoBehaviour , TimedInputHandler {
	TimedInputObjectO1 right = new TimedInputObjectO1 ();
	public GameObject target1;  
	public GameObject target2;
	public GameObject target3;
	public GameObject target4;
	public GameObject target5;
	public int Score;

	GvrReticle scoreScript = new GvrReticle();

	void Start () {
		GetComponent<Renderer> ().material.color = Color.white;

	}

	// Update is called once per frame
	void Update () {

	}
	public void HandleTimedInput()
	{
		string Scenename = Application.loadedLevelName;
		if (Scenename == "SolarVRQuestion1") {
			target1.GetComponent<Renderer> ().material.color = Color.green;
			this.gameObject.GetComponent<Renderer> ().material.color = Color.red;
			PlayerPrefs.SetInt ("flag1", 1);
		}
		if (Scenename == "SolarVRQuestion2") {
			target2.GetComponent<Renderer> ().material.color = Color.green;
			this.gameObject.GetComponent<Renderer> ().material.color = Color.red;
			PlayerPrefs.SetInt ("flag2", 1);
		}
		if (Scenename == "SolarVRQuestion3") {
			target3.GetComponent<Renderer> ().material.color = Color.green;
			this.gameObject.GetComponent<Renderer> ().material.color = Color.red;
			PlayerPrefs.SetInt ("flag3", 1);
		}
		if (Scenename == "SolarVRQuestion4") {
			this.gameObject.GetComponent<Renderer> ().material.color = Color.green;
			Score = PlayerPrefs.GetInt ("PlayerScore");
			Score = Score + 1;
			PlayerPrefs.SetInt ("PlayerScore", Score);
			PlayerPrefs.SetInt ("flag4", 1);
		}
		if (Scenename == "SolarVRQuestion5") {
			target5.GetComponent<Renderer> ().material.color = Color.green;
			this.gameObject.GetComponent<Renderer> ().material.color = Color.red;
			PlayerPrefs.SetInt ("flag5", 1);
		}

	}
}