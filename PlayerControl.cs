using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float runSpeed = 1;
	public float jumpHeight = 5;
	private Rigidbody2D myRigidBody;

	// Use this for initialization
	void Start () {
		myRigidBody = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			myRigidBody.velocity = new Vector2 (-runSpeed, 0);
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			myRigidBody.velocity = new Vector2 (runSpeed, 0);
		} else {
			myRigidBody.velocity = new Vector2(0, myRigidBody.velocity.y);
		}

		if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.Space)) {
			myRigidBody.velocity = new Vector2(myRigidBody.velocity.x,jumpHeight);
		}
	}
}
