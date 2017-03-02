using UnityEngine;
using System.Collections;

public class MoveDoor : MonoBehaviour {
	public Transform OpenPosition;
	private bool isOpen = false;
	private Transform DefaultPosition;
	// Use this for initialization
	void Start () {
		DefaultPosition = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}



}
