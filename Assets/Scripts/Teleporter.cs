using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {

	public Teleporter teleportTo;
	public float cooldownTimer = 3.0f;
	public float destOffsetX = 0.0f;
	public float destOffsetY = 1.0f;
	public bool portalLocked = false;

	private bool canTeleport = true;
	private Animator animator;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		if(portalLocked ==false)
			animator.SetInteger ("AnimState", 1);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void unlockTeleporter (){
		animator.SetInteger ("AnimState", 1);
		portalLocked = false;
	}
	
	public void lockTeleporter (){
		animator.SetInteger ("AnimState", 0);
		portalLocked = true;
	}

	void OnCollisionEnter2D(Collision2D target){
		if (portalLocked)
			return;

		if(canTeleport)
			target.transform.position = new Vector3(teleportTo.transform.position.x + destOffsetX,
		                                        teleportTo.transform.position.y + destOffsetY, 
			                                    teleportTo.transform.position.z);
			canTeleport = false;
			StartCoroutine (ResetNow ());
	}

	void ToggleTeleport(){
		canTeleport = !canTeleport;
	}


	private IEnumerator ResetNow(){
		yield return new WaitForSeconds(cooldownTimer);
		ToggleTeleport();
	}

}
