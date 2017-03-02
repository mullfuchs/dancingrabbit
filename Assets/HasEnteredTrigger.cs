using UnityEngine;
using System.Collections;

public class HasEnteredTrigger : MonoBehaviour {

	public bool enteredTrigger = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter(){
		enteredTrigger = true;
		print ("game object entered trigger");
	}

	void OnTriggerExit(){
		enteredTrigger = false;
		print ("game object exited trigger");
	}
}
