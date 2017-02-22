using UnityEngine;
using System.Collections;

public class LightAndMusicControls : MonoBehaviour {

	public GameObject switchObject;
	public GameObject lightObject;


	private AudioSource music;
	private float timer;
	private bool isActive = false;

	// Use this for initialization
	void Start () {
		resetTimer ();
		music = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.realtimeSinceStartup;
		if (timer <= 0 && !isActive) {
			activateBox ();
		}

		if (switchObject.GetComponent<HasEnteredTrigger> ().enteredTrigger) {
			deactivateBox ();
		}
	}

	void activateBox(){
		isActive = true;
		music.Play ();
		lightObject.SetActive (true);
	}

	void deactivateBox(){
		music.Pause ();
		lightObject.SetActive (false);
		resetTimer ();
		isActive = false;
	}

	void resetTimer(){
		timer = Random.Range (500, 600);
	}
}
