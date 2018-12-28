using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerUpHandler
{
	public float Speed;
	public Vector2 FacingDirection;

	private Rigidbody2D CurrentRigidbody2D;
	private Vector2 Vector2Input;
	private Vector2 TouchOrigin = -Vector2.one; //Used to store location of screen touch origin for mobile controls.

	// Use this for initialization
	void Start ()
	{
		var player = GameObject.FindGameObjectWithTag("Player");
		if (player)
		{
			CurrentRigidbody2D = player.GetComponent<Rigidbody2D>();
		}
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		TouchOrigin = eventData.position;
	}

	public void OnDrag(PointerEventData eventData)
	{
		Vector2 touchEnd = eventData.position;
		float newTouchX = touchEnd.x - TouchOrigin.x;
		float newTouchY = touchEnd.y - TouchOrigin.y;
		Vector2Input = new Vector2(newTouchX, newTouchY).normalized;
		CurrentRigidbody2D.velocity = new Vector2(Vector2Input.x * Speed, Vector2Input.y * Speed);
		FacingDirection = Vector2Input;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		TouchOrigin = eventData.position;
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		CurrentRigidbody2D.velocity = Vector2.zero;
	}
}
