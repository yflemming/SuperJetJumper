using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

	private bool activeCheckpoint = false;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Player") {
			activeCheckpoint = true;
		}
	}
}
