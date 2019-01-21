using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassController
{
	//Prob make a enum later
	private readonly string[] classList =
	{
		"Warrior",
		"Rogue",
		"Mage"
	};

	public Class GetClass(string chosenClass)
	{
		if (chosenClass == classList[0])
		{
			return new Warrior();
		}
		else if (chosenClass == classList[1])
		{
			return new Rogue();
		}
		else if (chosenClass == classList[2])
		{
			return new Mage();
		}
		else
		{
			return new Class();//Basic no specific class
		}
	}
}
