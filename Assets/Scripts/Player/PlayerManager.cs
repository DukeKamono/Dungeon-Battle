using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
	public string ChosenClass;

	private Stats CurrentStats;
	private Class CurrentClass;
	private EquipmentController CurrentEquipment;

    // Start is called before the first frame update
    void Start()
    {
		bool newPlayer = true; //this will be changed. Later.
		
		if (newPlayer)
		{
			CurrentStats = new Stats();

			ClassController classController = new ClassController();
			CurrentClass = classController.GetClass(ChosenClass);
			CurrentStats.UpdateStatsByClass(CurrentClass);

			CurrentEquipment = new EquipmentController();
		}

		//Load stuff and add it to the exisiting player?
		
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public Stats GetStats()
	{
		return CurrentStats;
	}

	public Class GetClass()
	{
		return CurrentClass;
	}
}
