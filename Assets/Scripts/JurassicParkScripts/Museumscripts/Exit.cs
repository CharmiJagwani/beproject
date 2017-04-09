using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {
	AudioSource audio;
	public void OnTriggerEnter()
	{
		audio = GetComponent<AudioSource> ();
		audio.Stop ();

	}
}
