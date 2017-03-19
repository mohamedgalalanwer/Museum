using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControll : MonoBehaviour {
    AudioSource play;
    GvrAudioSource stop;

	// Use this for initialization
	void Start () {
       play = GetComponent<AudioSource>();
        //stop = GetComponent<GvrAudioSource>();
	}
	
	// Update is called once per frame
	public void PlayAudio () {
        Debug.Log("method called");
        play.Play();
	}
}
