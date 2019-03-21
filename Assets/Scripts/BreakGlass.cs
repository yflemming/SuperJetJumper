using UnityEngine;
using System.Collections;

public class BreakGlass : MonoBehaviour {
	
	public LabTubeShards shards;
	public int totalParts;
	public bool breakGlass = false;
	public AudioClip shatteringGlass;

	private Animator animator;
	
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D target){
		if (!breakGlass)
			return;

		if (target.gameObject.tag == "Player") {
			breakGlass = false;
			DestroyGlass();
		}
		
	}

	public void DestroyGlass(){
		animator.SetInteger ("AnimState", 2);
		var t = transform;
		AudioSource.PlayClipAtPoint (shatteringGlass, t.position);
		
		for (int i = 0; i < totalParts; i++) {
			LabTubeShards clone = Instantiate(shards, t.position, Quaternion.identity) as LabTubeShards;
			clone.GetComponent<Rigidbody2D>().AddForce(Vector3.right * (Random.Range (-50, 50)));
			clone.GetComponent<Rigidbody2D>().AddForce(Vector3.up * Random.Range(10, 200));
		}
		
	}

}
