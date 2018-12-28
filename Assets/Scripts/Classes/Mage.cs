using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Class
{
	public Mage(float classHealth = 5, float classStrength = 1, float classAgility = 3, float classIntelligence = 5)
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
