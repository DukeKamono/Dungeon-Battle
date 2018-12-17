using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {
	//Assign a player object in inspector
	public GameObject player;

	//Load a scene by name
	public void LoadScene(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}

	//Load the first scene when choosing a class.
	//We might want to update this later when we go multiplayer
	public void LoadStartScene(string className)
	{
		//Should update posistion to starting posistion.
		GameObject chosenPlayer = Instantiate(player, Vector3.zero, Quaternion.Euler(Vector3.zero));
		chosenPlayer.GetComponent<ClassController>().chosenClass = className;
		DontDestroyOnLoad(chosenPlayer);

		SceneManager.LoadScene("BeginningScene");
	}
}
