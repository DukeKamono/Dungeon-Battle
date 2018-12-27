using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassController : MonoBehaviour
{
	public string chosenClass;
	public Class CurrentClass
	{
		get
		{
			return _currentClass;
		}
		set
		{
			_currentClass = new Class().GetClass(chosenClass);
		}
	}

	private Stats currentStats;
	private Class _currentClass;

    // Start is called before the first frame update
    void Start()
    {
		//Find the stats component on the current object
		currentStats = GetComponent<Stats>();

		//if there is none make a basic stats
		if (!currentStats)
		{
			currentStats = new Stats()
			{
				health = 20,
				strength = 1,
				agility = 1,
				intelligence = 1
			};
		}

		_currentClass = new Class().GetClass(chosenClass);

		currentStats.UpdateStatsByClass(CurrentClass);
	}

    // Update is called once per frame
    void Update()
    {
        
    }


}
