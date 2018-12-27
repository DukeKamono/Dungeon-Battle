using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackManager : MonoBehaviour
{
	private float damage;
	private Stats currentStats;
	private ClassController currentClass;
	
	// Start is called before the first frame update
	void Start()
	{
		currentStats = GetComponent<Stats>();
		currentClass = GetComponent<ClassController>();
	}
	
	public void Attack(float timeReleased)
	{
		var totalDamage = CalculateDamage();
		Debug.Log("Player Attacked! " + totalDamage);
		Debug.Log("Time Released: " + timeReleased);
	}

	private Class test()
	{
		return currentClass.CurrentClass;
	}

	private float CalculateDamage()
	{
		//Modifiers and stuff. Maybe this isn't just Strength based.
		return currentStats.strength;
	}
}
