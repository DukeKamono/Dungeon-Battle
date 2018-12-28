using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassController
{
	public BasicClass CurrentClass;

	private Stats CurrentStats;

	private readonly string[] classList =
	{
		"Warrior",
		"Rogue",
		"Mage"
	};

    // Start is called before the first frame update
    void Start()
    {
		
	}

	public BasicClass GetClass(string chosenClass)
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
			return new BasicClass();//Basic no specific class
		}
	}
}
