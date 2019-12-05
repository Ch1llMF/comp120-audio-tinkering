using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void QuitGame()
    {
        Debug.Log("Quit"); // this prints a message in the console that says "Quit"
        Application.Quit(); // This will quit the application but will only work if it was built. 
    }
}
