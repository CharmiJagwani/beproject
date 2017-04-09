using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour {
	AudioSource audio;
	public void OnTriggerEnter()
	{
		audio = GetComponent<AudioSource> ();
		audio.Play ();
	}


}
