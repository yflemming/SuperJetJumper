using UnityEngine;
using System.Collections;

public class ExitLevel : MonoBehaviour {

	public string scene;
	private GameObject[] artifacts;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		artifacts = GameObject.FindGameObjectsWithTag ("Artifact");
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Player" && artifacts.Length == 0) {
			Destroy(target.gameObject);
			Application.LoadLevel(scene);
		}
	}
}
