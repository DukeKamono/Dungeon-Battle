using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGameObject : MonoBehaviour
{
	//Set this on an object with a click event, then set the gameobject as what to be set as inactive.
	//Example is the hiddenMenu and menu button
   public void Toggle (GameObject gameObject)
	{
		gameObject.SetActive(!gameObject.activeSelf);
	}
}
