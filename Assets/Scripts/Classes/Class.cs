using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class
{
	public float ClassHealth;
	public float ClassStrength;
	public float ClassAgility;
	public float ClassIntelligence;

	public Class(float classHealth = 0, float classStrength = 0, float classAgility = 0, float classIntelligence = 0)
	{
		ClassHealth = classHealth;
		ClassStrength = classStrength;
		ClassAgility = classAgility;
		ClassIntelligence = classIntelligence;
	}

	public virtual float Attack(float timeReleased, float currentStrength)
	{

		//Animations here

		var total = timeReleased + currentStrength;

		return total;
	}
}
