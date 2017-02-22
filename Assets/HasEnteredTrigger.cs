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
	}

	void OnTriggerExit(){
		enteredTrigger = false;
	}
}
