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

	public void UpdateEquipment(List<Weapon> newWeapons, Helmet newHelmet, Armor newArmor)
	{
		foreach (var newWeapon in newWeapons) {
			if (newWeapon != null) {
				//Update weapon
			}
		}

		if (newHelmet != null) {
			//Update helmet
		}

		if (newArmor != null) {
			//update armor
		}
	}

	private void Save()
	{

	}

	public EquipmentController Load()
	{
		return new EquipmentController();
	}
}
