using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	public AudioClip pickupSound;
	private Meter meter;

	// Use this for initialization
	void Start () {
		meter = GameObject.FindObjectOfType<Meter> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Player") {
			meter.air += 2f;
			if(pickupSound)
				AudioSource.PlayClipAtPoint(pickupSound, transform.position);
			Destroy (gameObject);
		}
	}
}
