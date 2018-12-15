using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed;
	public bool isPlayerMoving;
	public Vector2 facingDirection;

	private Rigidbody2D currentRigidbody2D;
	private Vector2 vector2Input;

	// Use this for initialization
	void Start ()
	{
		currentRigidbody2D = GetComponent<Rigidbody2D>();

		isPlayerMoving = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Don't move me if I can't move.
		if (!isPlayerMoving)
		{
			currentRigidbody2D.velocity = Vector2.zero;
		}
		else
		{
			vector2Input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

			//If an input was pressed.
			if (vector2Input != Vector2.zero) {
				currentRigidbody2D.velocity = new Vector2 (vector2Input.x * speed, vector2Input.y * speed);
				facingDirection = vector2Input;
			}
			else
			{
				currentRigidbody2D.velocity = Vector2.zero;
			}
		}
	}
}
