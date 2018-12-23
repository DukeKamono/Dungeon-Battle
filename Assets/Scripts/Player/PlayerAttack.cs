using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
	private float damage;
	private Stats playerStats;

    // Start is called before the first frame update
    void Start()
    {
		playerStats = GetComponent<Stats>();
    }

	public void Attack()
	{
		var totalDamage = CalculateDamage();
		Debug.Log("Player Attacked! " + totalDamage);
	}

	private float CalculateDamage()
	{
		//Modifiers and stuff. Maybe this isn't just Strength based.
		return playerStats.strength;
	}
}
