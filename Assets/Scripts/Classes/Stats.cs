using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
	public float health;
	public float strength;
	public float agility;
	public float intelligence;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	//If there is a class attached as well, then update stats with that class.
	public void UpdateStatsByClass(Class classType)
	{
		health = health + classType.classHealth;
		strength = strength + classType.classStrength;
		agility = agility + classType.classAgility;
		intelligence = intelligence + classType.classIntelligence;
	}
}
