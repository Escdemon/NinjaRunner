using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaController : MonoBehaviour {

	public float moveSpeed; // 1
	public float jumpForce; // 2

	private Rigidbody2D rb; // 1

	public bool grounded; // 3
	public LayerMask ground; // 3

	private Collider2D collider; // 3

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>(); // 1

		collider = GetComponent<Collider2D> (); // 3
	}
	
	// Update is called once per frame
	void Update () {

		grounded = Physics2D.IsTouchingLayers (collider, ground); // 3

		rb.velocity = new Vector2 (moveSpeed, rb.velocity.y); // 1

		if (Input.GetKeyDown (KeyCode.Space)) { // 2
			if (grounded) { // 3
				rb.velocity = new Vector2 (rb.velocity.x, jumpForce); // 2
			}
		}
	}
}
