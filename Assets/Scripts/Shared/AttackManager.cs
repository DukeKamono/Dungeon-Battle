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
		var totalDamage = CalculateDamage();
		Debug.Log("Player Attacked! " + totalDamage);
		Debug.Log("Time Released: " + timeReleased);
	}

	private string test()
	{
		return CurrentPlayer.ChosenClass;
	}

	private float CalculateDamage()
	{
		//Modifiers and stuff. Maybe this isn't just Strength based.
		return  CurrentPlayer.GetStats().GetStrength();
	}
}
