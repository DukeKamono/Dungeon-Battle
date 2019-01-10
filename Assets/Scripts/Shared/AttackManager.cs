using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
	private float Damage;
	private PlayerManager CurrentPlayer;
	
	// Start is called before the first frame update
	void Start()
	{
		CurrentPlayer = GetComponent<PlayerManager>();
	}
	
	public void Attack(float timeReleased)
	{
		//I did ceiling instead of round, because I can.
		var totalDamage = Mathf.Ceil(CalculateDamage(timeReleased));
		Debug.Log("Player Attacked! " + totalDamage);
		Debug.Log("Time Released: " + timeReleased);
		CurrentPlayer.gameObject.GetComponentInChildren<Animator>().SetTrigger("Attack");
	}

	private float ClassAttack(float timeReleased, float currentStrength)
	{
		return CurrentPlayer.GetClass().Attack(timeReleased, currentStrength);
	}

	private float CalculateDamage(float timeReleased)
	{
		//Modifiers and stuff. Maybe this isn't just Strength based.
		var currentStrength = CurrentPlayer.GetStats().GetStrength();

		var classModifier = ClassAttack(timeReleased, currentStrength);

		Debug.Log(CurrentPlayer.GetClass());

		return classModifier;
	}
}
