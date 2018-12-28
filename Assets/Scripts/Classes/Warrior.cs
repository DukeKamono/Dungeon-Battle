using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Class
{
	public Warrior(float classHealth = 10, float classStrength = 5, float classAgility = 3, float classIntelligence = 1)
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
