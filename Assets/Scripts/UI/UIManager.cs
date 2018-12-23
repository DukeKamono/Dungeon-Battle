using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	public Slider healthBar;
	public Text HPText;
	public Text classText;
	public Text strText;
	public Text agiText;
	public Text intText;

	private Stats playerStats;
	private ClassController playerClass;
	private static bool UIExists;

	// Use this for initialization
	void Start()
	{
		if (!UIExists)
		{
			UIExists = true;
			DontDestroyOnLoad(transform.gameObject);
		}
		else
		{
			Destroy(gameObject);
		}

		//Find the player (if any) and focus on it. Should be updated for multiple players
		var player = GameObject.FindGameObjectWithTag("Player");
		if (player)
		{
			playerStats = player.GetComponent<Stats>();
			playerClass = player.GetComponent<ClassController>();
		}
	}

	// Update is called once per frame
	void Update()
	{
		healthBar.maxValue = playerStats.maxHealth;
		healthBar.value = playerStats.health;
		HPText.text = "HP: " + playerStats.health + "/" + playerStats.maxHealth;
		classText.text = "Class: " + playerClass.chosenClass;
		strText.text = "Str: " + playerStats.strength;
		agiText.text = "Agi: " + playerStats.agility;
		intText.text = "Int: " + playerStats.intelligence;
	}
}
