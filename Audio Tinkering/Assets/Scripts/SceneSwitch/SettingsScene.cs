using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
public class SettingsScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GoToSettings()); // this calls the coroutine in the module named "GoToSettings()"
    }

    IEnumerator GoToSettings()
    {
        yield return new WaitForSeconds(1); // delays the code by 1 second
        SceneManager.LoadScene("Settings"); // changes the scene to the "Settings" scene
    }
}
