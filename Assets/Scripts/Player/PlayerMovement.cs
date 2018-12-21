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
			#endif

			//Check if we are running on iOS, Android
			#if UNITY_IOS || UNITY_ANDROID

			//Check if Input has registered more than zero touches
			if (Input.touchCount > 0)
			{
				Input.multiTouchEnabled = false;
				for (int i = 0; i < Input.touchCount; ++i)
				{
					Touch myTouch = Input.touches[i];

					if (i > 0)
					{
						touchOrigin = Input.touches[i-1].position;
					}

					if (myTouch.phase == TouchPhase.Began)
					{
						touchOrigin = myTouch.position;
					}
					if (myTouch.phase == TouchPhase.Stationary || myTouch.phase == TouchPhase.Moved)
					{
						Vector2 touchEnd = myTouch.position;
						float newTouchX = touchEnd.x - touchOrigin.x;
						float newTouchY = touchEnd.y - touchOrigin.y;
						vector2Input = new Vector2(newTouchX, newTouchY).normalized;

						if (vector2Input != Vector2.zero) {
							currentRigidbody2D.velocity = new Vector2 (vector2Input.x * speed, vector2Input.y * speed);
							facingDirection = vector2Input;
						}
						else
						{
							currentRigidbody2D.velocity = Vector2.zero;
						}
					}
					if (myTouch.phase == TouchPhase.Ended)
					{
						currentRigidbody2D.velocity = Vector2.zero;
					}
				}
			}
			#endif
		}
	}
}
