using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	public bool shootUp = false;
	public bool shootLeft = false;
	public bool shootRight = false;

	// Use this for initialization
	void Start () {
		if(shootUp)
			transform.position = transform.position + new Vector3(0.0f, 0.2f, 0.0f);
		if(shootLeft)
			transform.position = transform.position + new Vector3(-0.1f, 0.0f, 0.0f);
		if(shootRight)
			transform.position = transform.position + new Vector3(0.1f, 0.0f, 0.0f);
		else
			transform.position = transform.position + new Vector3(0.0f, -0.1f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if(shootUp)
			ShootUp();
		if(shootLeft)
			ShootLeft();
		if(shootRight)
			ShootRight();
	
	}

	void OnCollisionEnter2D(Collision2D target){
		Destroy (gameObject);
	}

	void ShootLeft(){
		transform.position = new Vector3 (transform.position.x - 0.1f, transform.position.y, 0);
	}

	void ShootRight(){
		transform.position = new Vector3 (transform.position.x + 0.1f, transform.position.y, 0);
	}

	void ShootUp(){
		transform.position = new Vector3 (transform.position.x, transform.position.y + 0.1f, 0);
	}
}
