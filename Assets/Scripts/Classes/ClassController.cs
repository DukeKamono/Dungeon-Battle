using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassController : MonoBehaviour
{
	public string chosenClass;

	private Stats currentStats;
	private Class currentClass;

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

		currentClass = new Class().GetClass(chosenClass);

		currentStats.UpdateStatsByClass(currentClass);
	}

    // Update is called once per frame
    void Update()
    {
        
    }


}
