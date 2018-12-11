using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBounds : MonoBehaviour
{
	private BoxCollider2D cameraBounds;
	private CameraManager cameraManager;

	// Use this for initialization
	void Start()
	{
		cameraBounds = GetComponent<BoxCollider2D>();
		cameraManager = FindObjectOfType<CameraManager>();
		cameraManager.SetBounds(cameraBounds);
	}
}
