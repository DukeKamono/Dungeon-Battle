using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class
{
	public float classHealth;
	public float classStrength;
	public float classAgility;
	public float classIntelligence;

	//Current list of classes. Prob change to an enum later.
	private readonly string[] classList =
	{
		"Warrior",
		"Rogue",
		"Mage"
	};

	//Might be a better way to get this. Returns the class based on the string passed in.
	public Class GetClass(string classToGet)
	{
		if (classToGet == classList[0])
		{
			return new Warrior();
		}
		else if (classToGet == classList[1])
		{
			return new Rogue();
		}
		else if (classToGet == classList[2])
		{
			return new Mage();
		}
		else
		{
			return new Class();//Basic no specific class
		}
	}
}
