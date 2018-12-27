using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AttackButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	private float timeHeldStart;
	private AttackManager playerAttack;

    // Start is called before the first frame update
    void Start()
    {
		var player = GameObject.FindGameObjectWithTag("Player");
		if (player)
		{
			playerAttack = player.GetComponent<AttackManager>();
		}
    }

	public void AttackPressed(float timeReleased)
    {
		playerAttack.Attack(timeReleased);
    }

	//The the pointer is down clicked
	public void OnPointerDown(PointerEventData eventData)
	{
		timeHeldStart = Time.time;
	}

	public void OnPointerUp(PointerEventData eventData)
	{
		var timeReleased = Time.time - timeHeldStart;

		//Don't count for more than 5 secs of holding for an attack.
		timeReleased = timeReleased > 5 ? 5 : timeReleased;

		AttackPressed(timeReleased);
	}
}
