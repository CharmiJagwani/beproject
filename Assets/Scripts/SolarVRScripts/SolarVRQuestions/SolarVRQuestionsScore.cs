using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarVRQuestionsScore : MonoBehaviour {
	// Use this for initialization
	GvrReticle scoreScript = new GvrReticle();
	public int Score;
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Score = PlayerPrefs.GetInt ("PlayerScore");
		GetComponent <TextMesh> ().text = Score.ToString();
		
	}


}
