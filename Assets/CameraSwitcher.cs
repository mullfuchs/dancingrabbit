using UnityEngine;
using System.Collections;

public class CameraSwitcher : MonoBehaviour {
	public Camera camera1;
	public Camera camera2;


	// Use this for initialization
	void Start () {
		camera1.enabled = true;
		camera2.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(){
		switchCameras ();
	}

	void OnTriggerExit(){
		switchCameras ();
	}

	void switchCameras (){
		camera1.enabled = !camera1.enabled;
		camera2.enabled = !camera2.enabled;
		setPrimaryCamera (camera1);
		setPrimaryCamera (camera2);
	}

	void setPrimaryCamera(Camera inCamera){
		if (inCamera.enabled) {
			inCamera.tag = "MainCamera";
		} else {
			inCamera.tag = "Untagged";
		}
	}
}
