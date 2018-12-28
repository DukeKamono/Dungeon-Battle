using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : BasicClass
{
	public Rogue(float classHealth = 7, float classStrength = 3, float classAgility = 5, float classIntelligence = 1)
	{
		ClassHealth = classHealth;
		ClassStrength = classStrength;
		ClassAgility = classAgility;
		ClassIntelligence = classIntelligence;
	}
}
