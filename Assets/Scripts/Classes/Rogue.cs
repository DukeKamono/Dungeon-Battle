using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : Class
{
	public Rogue(float classHealth = 7, float classStrength = 3, float classAgility = 5, float classIntelligence = 1)
	{
		ClassHealth = classHealth;
		ClassStrength = classStrength;
		ClassAgility = classAgility;
		ClassIntelligence = classIntelligence;
	}

	public override float Attack(float timeReleased, float currentStrength)
	{

		//Animations here

		var total = timeReleased + currentStrength;

		return total;
	}
}
