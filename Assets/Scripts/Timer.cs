using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	private float startTime;
	private float elapsedTime;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

	void Awake(){ startTime = 0; 
	}
	
	void Update () {
		
		if (startTime >= 0)
		{
			elapsedTime = Time.time - startTime;
		}
	}
	
	void OnTriggerEnter(){ startTime = Time.time; }
	
	void OnTriggerExit(){ startTime = 0; }
	
	void OnGUI(){ GUI.Label(new Rect(300, 100, 100, 20), (elapsedTime.ToString())); } 
}
