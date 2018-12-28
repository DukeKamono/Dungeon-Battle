using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : BasicClass
{
	public Warrior(float classHealth = 10, float classStrength = 5, float classAgility = 3, float classIntelligence = 1)
    {
		ClassHealth = classHealth;
		ClassStrength = classStrength;
		ClassAgility = classAgility;
		ClassIntelligence = classIntelligence;
    }
}
