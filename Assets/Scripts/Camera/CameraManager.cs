using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
	public float moveSpeed;
	public BoxCollider2D boundBox;

	private GameObject followTarget;
	private Vector3 targetPos;
	private static bool cameraExists;
	private Vector3 minBounds;
	private Vector3 maxBounds;
	private Camera theCamera;
	private float halfHeight;
	private float halfWidth;

	// Use this for initialization
	void Start()
	{
		//If this camera doesn't exists yet, make it true and don't destroy it.
		if (!cameraExists)
		{
			cameraExists = true;
			DontDestroyOnLoad(transform.gameObject);
		}
		else
		{
			Destroy(gameObject);//Destroy camera is one already exists
		}

		//find the bounds if any and set it up. Camera won't follow outside of it.
		if (boundBox == null)
		{
			boundBox = FindObjectOfType<CameraBounds>().GetComponent<BoxCollider2D>();
			minBounds = boundBox.bounds.min;
			maxBounds = boundBox.bounds.max;

			theCamera = GetComponent<Camera>();
			halfHeight = theCamera.orthographicSize;
			halfWidth = halfHeight * Screen.width / Screen.height;
		}

		//Find the player (if any) and focus on it. Should be updated for multiple players
		var player = GameObject.FindGameObjectWithTag("Player");
		if (player)
		{
			followTarget = player;
		}
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		//Camera does stuff in Vector3
		targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z);
		transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);

		if (boundBox != null)//Only do this if we have a boundbox pls
		{
			//Stay within the bounds camera!
			float clampedX = Mathf.Clamp(transform.position.x, minBounds.x + halfWidth, maxBounds.x - halfWidth);
			float clampedY = Mathf.Clamp(transform.position.y, minBounds.y + halfHeight, maxBounds.y - halfHeight);
			transform.position = new Vector3(clampedX, clampedY, transform.position.z);
		}
	}

	public void SetBounds(BoxCollider2D newBounds)
	{
		boundBox = newBounds;

		minBounds = boundBox.bounds.min;
		maxBounds = boundBox.bounds.max;
	}
}
