using UnityEngine;
using System.Collections;

public class LightAndMusicControls : MonoBehaviour {

	public GameObject switchObject;
	public GameObject lightObject;
	public GameObject DanceFloorObject;


	private AudioSource music;
	private float timer;
	private float pitchAmount = 0;
	private float danceTimer = 5;
	private bool isActive = false;
	private float danceFloorRotation = 1;

	// Use this for initialization
	void Start () {
		resetTimer ();
		music = GetComponent<AudioSource> ();
		music.pitch = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0 && !isActive) {
			activateBox ();
		}

		if (switchObject.GetComponent<HasEnteredTrigger> ().enteredTrigger && isActive) {
			//danceFloorRotation = 1;
			DanceFloorObject.transform.Rotate (0, 0, danceFloorRotation);
			danceTimer -= Time.deltaTime;

		}

		if (isActive && danceTimer <= 0) {
			deactivateBox ();
		}

		if (isActive) {
			if (music.pitch < 1) {
				music.pitch += Mathf.Lerp (0, 1, Time.deltaTime * 0.5f);
			}
			 
		}

		if (!isActive) {
			if (music.pitch > 0) {
				music.pitch -= Mathf.Lerp (0, 1, Time.deltaTime * 0.2f);
			} else {
				music.Pause ();
			}
		}
	}

	void activateBox(){
		isActive = true;
		music.Play ();
		lightObject.SetActive (true);
		danceTimer = 5;
	}

	void deactivateBox(){
		//music.Pause ();
		lightObject.SetActive (false);
		resetTimer ();
		isActive = false;
	}

	void resetTimer(){
		timer = Random.Range (10, 20);
	}
}
