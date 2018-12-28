using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AttackButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	private float TimeHeldStart;
	private AttackManager PlayerAttack;

    // Start is called before the first frame update
    void Start()
    {
		var player = GameObject.FindGameObjectWithTag("Player");
		if (player)
		{
			PlayerAttack = player.GetComponent<AttackManager>();
		}
    }

	public void AttackPressed(float timeReleased)
    {
		PlayerAttack.Attack(timeReleased);
    }

	//The the pointer is down clicked
	public void OnPointerDown(PointerEventData eventData)
	{
		TimeHeldStart = Time.time;
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		var timeReleased = Time.time - TimeHeldStart;

		//Don't count for more than 5 secs of holding for an attack.
		timeReleased = timeReleased > 5 ? 5 : timeReleased;

		AttackPressed(timeReleased);
	}
}
