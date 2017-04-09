using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarVRList : MonoBehaviour {
	TimedInputObjectSun s = new TimedInputObjectSun ();
	int SunFlag = 0,MercuryFlag = 0, VenusFlag = 0, EarthFlag = 0, MarsFlag = 0, JupiterFlag = 0, SaturnFlag = 0, UranusFlag = 0, NeptuneFlag = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (s.sun == SunFlag ) 
		{
			SunFlag = 2;
			s.sun = 1;
			GetComponent <TextMesh> ().text += "Sun \n";
		}
		if (PlayerPrefs.GetInt ("MercuryFlag") == MercuryFlag) 
		{
			MercuryFlag = 2;
			PlayerPrefs.SetInt ("MercuryFlag", 1);
			GetComponent <TextMesh> ().text += "Mercury \n";
		}
		if (PlayerPrefs.GetInt ("VenusFlag") == VenusFlag) 
		{
			VenusFlag = 2;
			PlayerPrefs.SetInt ("VenusFlag", 1);
			GetComponent <TextMesh> ().text += "Venus \n";
		}
		if (PlayerPrefs.GetInt ("EarthFlag") == EarthFlag) 
		{
			EarthFlag = 2;
			PlayerPrefs.SetInt ("EarthFlag", 1);
			GetComponent <TextMesh> ().text += "Earth \n";
		}
		if (PlayerPrefs.GetInt ("MarsFlag") == MarsFlag) 
		{
			MarsFlag = 2;
			PlayerPrefs.SetInt ("MarsFlag", 1);
			GetComponent <TextMesh> ().text += "Mars \n";
		}
		if (PlayerPrefs.GetInt ("JupiterFlag") == JupiterFlag) 
		{
			JupiterFlag = 2;
			PlayerPrefs.SetInt ("JupiterFlag", 1);
			GetComponent <TextMesh> ().text += "Jupiter \n";
		}
		if (PlayerPrefs.GetInt ("SaturnFlag") == SaturnFlag) 
		{
			SaturnFlag = 2;
			PlayerPrefs.SetInt ("SaturnFlag", 1);
			GetComponent <TextMesh> ().text += "Saturn \n";
		}
		if (PlayerPrefs.GetInt ("UranusFlag") == UranusFlag) 
		{
			UranusFlag = 2;
			PlayerPrefs.SetInt ("UranusFlag", 1);
			GetComponent <TextMesh> ().text += "Uranus \n";
		}
		if (PlayerPrefs.GetInt ("NeptuneFlag") == NeptuneFlag) 
		{
			NeptuneFlag = 2;
			PlayerPrefs.SetInt ("NeptuneFlag", 1);
			GetComponent <TextMesh> ().text += "Neptune \n";
		}
		
	}

}
