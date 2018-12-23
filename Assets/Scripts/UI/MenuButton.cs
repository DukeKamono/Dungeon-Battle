using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
	public GameObject hiddenMenu;

    // Start is called before the first frame update
    void Start()
    {
		
	}

	public void ToggleMenu()
	{
		if (hiddenMenu.activeSelf == true)
		{
			hiddenMenu.SetActive(false);
		}
		else
		{
			hiddenMenu.SetActive(true);
		}
	}
}
