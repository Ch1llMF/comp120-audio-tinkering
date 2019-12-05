using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
public class MenuScene : MonoBehaviour
{
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GoToMenu()); // this calls the coroutine in the module named "GoToMenu()"
    }

    IEnumerator GoToMenu()
    {
        yield return new WaitForSeconds(1); // delays the code by 1 second
        SceneManager.LoadScene("Menu"); // changes the scene to the "Menu" scene
    }
}
