using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
	private bool IsMainHand;
	private Stats WeaponStats;

    public Weapon()
    {
		WeaponStats = new Stats();
		IsMainHand = true;
    }

    // Update is called once per frame
    void Update()
    {
        //Animation?
    }
}
