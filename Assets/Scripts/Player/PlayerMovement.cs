﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed;
	public bool isPlayerMoving;
	public Vector2 facingDirection;

	private Rigidbody2D currentRigidbody2D;
	private Vector2 vector2Input;
	private Vector2 touchOrigin = -Vector2.one; //Used to store location of screen touch origin for mobile controls.

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
			//Check if we are running either in the Unity editor or in a standalone build.
			#if UNITY_STANDALONE || UNITY_WEBPLAYER

			vector2Input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

			//If an input was pressed.
			if (vector2Input != Vector2.zero)
			{
				currentRigidbody2D.velocity = new Vector2 (vector2Input.x * speed, vector2Input.y * speed);
				facingDirection = vector2Input;
			}
			else
			{
				currentRigidbody2D.velocity = Vector2.zero;
			}

			//Check if we are running on iOS, Android, Windows Phone 8 or Unity iPhone
			#elif UNITY_IOS || UNITY_ANDROID || UNITY_WP8 || UNITY_IPHONE

			//Check if Input has registered more than zero touches
			if (Input.touchCount > 0)
			{
				//Store the first touch detected.
				Touch myTouch = Input.touches[0];

				//Check if the phase of that touch equals Began
				if (myTouch.phase == TouchPhase.Began)
				{
					//If so, set touchOrigin to the position of that touch
					touchOrigin = myTouch.position;
				}

				//If the touch phase is not Began, and instead is equal to Ended and the x of touchOrigin is greater or equal to zero:
				else if (myTouch.phase == TouchPhase.Ended && touchOrigin.x >= 0)
				{
					//Set touchEnd to equal the position of this touch
					Vector2 touchEnd = myTouch.position;

					//Calculate the difference between the beginning and end of the touch on the x axis.
					float x = touchEnd.x - touchOrigin.x;

					//Calculate the difference between the beginning and end of the touch on the y axis.
					float y = touchEnd.y - touchOrigin.y;

					//Set touchOrigin.x to -1 so that our else if statement will evaluate false and not repeat immediately.
					touchOrigin.x = -1;

					vector2Input = new Vector2(y, x).normalized;

					//If an input was pressed.
					if (vector2Input != Vector2.zero)
					{
						currentRigidbody2D.velocity = new Vector2 (vector2Input.x * speed, vector2Input.y * speed);
						facingDirection = vector2Input;
					}
					else
					{
						currentRigidbody2D.velocity = Vector2.zero;
					}
				}
			}

			#endif //End of mobile platform dependendent compilation section started above with #elif
		}
	}
}
