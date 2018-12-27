using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerUpHandler
{
	public float speed;
	public Vector2 facingDirection;

	private Rigidbody2D currentRigidbody2D;
	private Vector2 vector2Input;
	private Vector2 touchOrigin = -Vector2.one; //Used to store location of screen touch origin for mobile controls.

	// Use this for initialization
	void Start ()
	{
		var player = GameObject.FindGameObjectWithTag("Player");
		if (player)
		{
			currentRigidbody2D = player.GetComponent<Rigidbody2D>();
		}
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		touchOrigin = eventData.position;
	}

	public void OnDrag(PointerEventData eventData)
	{
		Vector2 touchEnd = eventData.position;
		float newTouchX = touchEnd.x - touchOrigin.x;
		float newTouchY = touchEnd.y - touchOrigin.y;
		vector2Input = new Vector2(newTouchX, newTouchY).normalized;
		currentRigidbody2D.velocity = new Vector2(vector2Input.x * speed, vector2Input.y * speed);
		facingDirection = vector2Input;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		touchOrigin = eventData.position;
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		currentRigidbody2D.velocity = Vector2.zero;
	}
}
