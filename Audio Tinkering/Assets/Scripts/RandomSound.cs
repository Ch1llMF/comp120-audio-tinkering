using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
// This means that the script will only run if it is placed on a button.
[RequireComponent(typeof(Button))]
public class RandomSound : MonoBehaviour
{
    // this allows me to attach an audio clip to the script in the unity editor.
    public AudioClip sound;
    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    private int startingPitch = 1;
    void Start()
    {

        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false; // stops the audio playing on start.

        button.onClick.AddListener(() => PlaySound()); // This sends the code to void PlaySound()
        source.pitch = startingPitch; // this sets the pitch to the default pitch that is set.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlaySound()
    {
        source.pitch = Random.Range(0.1f, 2f); // This make the pitch change randomly every time the button is pressed.
        source.PlayOneShot(sound); // This plays the audio source that is attached to the script.

    }


}


