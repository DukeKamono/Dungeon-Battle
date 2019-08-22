using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	private GameObject target; //the enemy's target
	public float moveSpeed = 5; //move speed
	public float rotationSpeed = 5; //speed of turning
	//private Rigidbody2D rb;

	// Start is called before the first frame update
	void Start()
    {
		//rb = GetComponent<Rigidbody2D>();

		var player = GameObject.FindGameObjectWithTag("Player");
		if (player)
		{
			target = player;
		}
	}

    // Update is called once per frame
    void Update()
    {
		transform.right = target.transform.position - transform.position;
		transform.position += transform.right * Time.deltaTime * moveSpeed;

		//// These two circle the player. I want to use this later. Could be good for a flyer before they attack, or some sort of missle.
		//transform.up = Vector3.Lerp(transform.up, (target.transform.position - transform.position), rotationSpeed);
		//transform.position += transform.right * Time.deltaTime * moveSpeed;
	}
}
