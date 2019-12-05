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
        StartCoroutine(GoToMenu());
    }

    IEnumerator GoToMenu()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Menu");
    }
}
