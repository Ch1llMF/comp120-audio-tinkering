﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SettingsScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GoToSettings());
    }

    IEnumerator GoToSettings()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Settings");
    }
}
