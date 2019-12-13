using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	private GameObject target; //the enemy's target
	public float moveSpeed = 5; //move speed
	public float rotationSpeed = 5; //speed of turning
	public float sightDistance = 10.0f;
	public Vector2 sightDirection = Vector2.left;

	// Start is called before the first frame update
	void Start()
    {
		var player = GameObject.FindGameObjectWithTag("Player");
		if (player)
		{
			target = player;
		}
	}

    // Update is called once per frame
    void Update()
    {
		if (SeeTarget())
		{
			transform.position = Vector2.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
		}

		//// These two circle the player. I want to use this later. Could be good for a flyer before they attack, or some sort of missle.
		//transform.up = Vector3.Lerp(transform.up, (target.transform.position - transform.position), rotationSpeed);
		//transform.position += transform.right * Time.deltaTime * moveSpeed;
	}

	bool SeeTarget()
	{
		// https://answers.unity.com/questions/8715/how-do-i-use-layermasks.html
		int maskLayer = 1 << target.layer;


		Debug.DrawRay(transform.position, sightDirection, Color.green);
		RaycastHit2D hit = Physics2D.Raycast(transform.position, sightDirection, sightDistance, maskLayer);
		if (hit.collider != null)
		{
			return true;
		}

		return false;
	}
}
