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
	private float Speed;

	public Stats(float health = 1, float strength = 1, float agility = 1, float intelligence = 1, float speed = 5)
	{
		Health = health;
		Strength = strength;
		Agility = agility;
		Intelligence = intelligence;
		MaxHealth = Health;
		Speed = CalculateSpeed(speed);
	}

	//Update stats with class.
	public void UpdateStatsByClass(Class classType)
	{
		Health = Health + classType.ClassHealth;
		Strength = Strength + classType.ClassStrength;
		Agility = Agility + classType.ClassAgility;
		Intelligence = Intelligence + classType.ClassIntelligence;
		MaxHealth = Health;
		Speed = CalculateSpeed(Speed);
	}

	//Put in a speed, and modify it by the current Agility stat.
	public float CalculateSpeed(float speed)
	{
		return speed + (Agility / 10);
	}

	//Find better way to get these...
	//Combine Getters?
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

	public float GetSpeed()
	{
		return Speed;
	}
}
