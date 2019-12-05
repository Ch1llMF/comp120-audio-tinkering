using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
public class PlayScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GoToPlay()); // this calls the coroutine in the module named "GoToPlay()"
    }

    IEnumerator GoToPlay()
    {
        yield return new WaitForSeconds(1); // delays the code by 1 second
        SceneManager.LoadScene("Play"); // changes the scene to the "Play" scene
    }
}
