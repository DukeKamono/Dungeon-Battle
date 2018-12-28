using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : BasicClass
{
	public Mage(float classHealth = 5, float classStrength = 1, float classAgility = 3, float classIntelligence = 5)
	{
		ClassHealth = classHealth;
		ClassStrength = classStrength;
		ClassAgility = classAgility;
		ClassIntelligence = classIntelligence;
	}
}
