using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
	public Slider HealthBar;
	public Text HPText;
	public Text ClassText;
	public Text StrText;
	public Text AgiText;
	public Text IntText;

	private PlayerManager CurrentPlayer;
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
			CurrentPlayer = player.GetComponent<PlayerManager>();
		}
	}

	// Update is called once per frame
	void Update()
	{
		Stats playerStats = CurrentPlayer.GetStats();
		BasicClass playerClass = CurrentPlayer.GetClass ();

		HealthBar.maxValue = playerStats.GetMaxHealth();
		HealthBar.value = playerStats.GetHealth();
		HPText.text = "HP: " + playerStats.GetHealth() + "/" + playerStats.GetMaxHealth();
		ClassText.text = "Class: " + playerClass.ToString();
		StrText.text = "Str: " + playerStats.GetStrength();
		AgiText.text = "Agi: " + playerStats.GetAgility();
		IntText.text = "Int: " + playerStats.GetIntelligence();
	}
}
