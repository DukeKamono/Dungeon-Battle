using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackButton : MonoBehaviour
{
	private PlayerAttack playerAttack;
    // Start is called before the first frame update
    void Start()
    {
		var player = GameObject.FindGameObjectWithTag("Player");
		if (player)
		{
			playerAttack = player.GetComponent<PlayerAttack>();
		}
    }

    // Update is called once per frame
	void Update()
	{
		//Check for input by touch
		//Then runn AttackPressed()
	}

    public void AttackPressed()
    {
		playerAttack.Attack();
    }
}
