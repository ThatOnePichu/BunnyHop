using UnityEngine;
using System.Collections;

public class Bunny : MonoBehaviour {

	public float runSpeed;
	private Rigidbody2D body;

	// Use this for initialization
	void Start () {
		body = this.GetComponent<Rigidbody2D> ();	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow)) {
			body.velocity = new Vector2(-runSpeed, body.velocity.y);
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			body.velocity = new Vector2(runSpeed, body.velocity.y);
		}
	}
}