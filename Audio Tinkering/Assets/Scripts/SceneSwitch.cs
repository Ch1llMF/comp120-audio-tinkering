using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitch : MonoBehaviour
{
	public void GoToMenuScene () 
	{
		SceneManager.LoadScene("Menu");
	}

	public void GoToPlayScene ()
	{
		SceneManager.LoadScene("Play");
	}

	public void GoToSettingsScene ()
	{
		SceneManager.LoadScene("Settings");
	}
}
