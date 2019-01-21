using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentController
{
	private List<Weapon> EquippedWeapons;
	private Helmet EquippedHelmet;
	private Armor EquippedArmor;

	public EquipmentController() {
		EquippedWeapons = new List<Weapon>();
		EquippedHelmet = new Helmet();
		EquippedArmor = new Armor();
	}

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{

	}

	private void Save()
	{

	}

	private void Load()
	{

	}
}
