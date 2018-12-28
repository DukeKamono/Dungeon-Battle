using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
	public string ChosenClass;

	private Stats CurrentStats;
	private Class CurrentClass;

    // Start is called before the first frame update
    void Start()
    {
		CurrentStats = new Stats();

		ClassController classController = new ClassController();
		CurrentClass = classController.GetClass(ChosenClass);
		CurrentStats.UpdateStatsByClass(CurrentClass);
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
