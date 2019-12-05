using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GoToPlay());
    }

    IEnumerator GoToPlay()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Play");
    }
}
