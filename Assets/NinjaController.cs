using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaController : MonoBehaviour {

	public float moveSpeed; // 1
	public float jumpForce; // 2

	private Rigidbody2D rb; // 1

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>(); // 1
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector2 (moveSpeed, rb.velocity.y); // 1

		if (Input.GetKeyDown (KeyCode.Space)) { // 2
			rb.velocity = new Vector2 (rb.velocity.x, jumpForce); // 2
		}
	}
}
