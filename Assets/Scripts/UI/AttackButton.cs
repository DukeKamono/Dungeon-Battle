using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AttackButton : MonoBehaviour, IPointerDownHandler
{
	private PlayerAttack playerAttack;

    // Start is called before the first frame update
    void Start()
    {
		var player = GameObject.FindGameObjectWithTag("Player");
		if (player)
		{
			playerAttack = player.GetComponent<PlayerAttack>();
		}
    }

	public void AttackPressed()
    {
		playerAttack.Attack();
    }

	//The the pointer is down clicked
	public void OnPointerDown(PointerEventData eventData)
	{
		//Main mouse button is clicked
		if (Input.GetMouseButtonDown(0))
		{
			AttackPressed();
		}

		//Check if Input has registered more than zero touches
		else if (Input.touchCount > 0)
		{
			//Input.multiTouchEnabled = false;

			for (int i = 0; i < Input.touchCount; ++i)
			{
				Touch myTouch = Input.touches[i];

				//As soon as you begin a touch attack. Might change if we do a charge attack or something
				if (myTouch.phase == TouchPhase.Began)
				{
					AttackPressed();
				}

				//If we are holding the touch down or moveing (like a swipe)
				if (myTouch.phase == TouchPhase.Stationary || myTouch.phase == TouchPhase.Moved)
				{

				}

				if (myTouch.phase == TouchPhase.Ended)
				{

				}
			}
		}
	}
}
