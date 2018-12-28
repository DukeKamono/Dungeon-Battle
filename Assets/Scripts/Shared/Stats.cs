using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{
	private float MaxHealth;
	private float Health;
	private float Strength;
	private float Agility;
	private float Intelligence;

	public Stats(float health = 1, float strength = 1, float agility = 1, float intelligence = 1)
	{
		Health = health;
		Strength = strength;
		Agility = agility;
		Intelligence = intelligence;
	}

    // Start is called before the first frame update
    void Start()
    {
		MaxHealth = Health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	//If there is a class attached as well, then update stats with that class.
	public void UpdateStatsByClass(BasicClass classType)
	{
		Health = Health + classType.ClassHealth;
		Strength = Strength + classType.ClassStrength;
		Agility = Agility + classType.ClassAgility;
		Intelligence = Intelligence + classType.ClassIntelligence;
	}

	//Find better way to get these...
	public float GetMaxHealth()
	{
		return MaxHealth;
	}

	public float GetHealth()
	{
		return Health;
	}

	public float GetStrength()
	{
		return Strength;
	}

	public float GetAgility()
	{
		return Agility;
	}

	public float GetIntelligence()
	{
		return Intelligence;
	}
}
