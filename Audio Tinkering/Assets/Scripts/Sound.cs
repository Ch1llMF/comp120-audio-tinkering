using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This means that the script will only run if it is placed on a button.
[RequireComponent(typeof(Button))]
public class Sound : MonoBehaviour
{
    // this allows me to attach an audio clip to the script in the unity editor.
    public AudioClip sound;
    private Button button { get { return GetComponent<Button>(); } }
    private AudioSource source { get { return GetComponent<AudioSource>(); } }

    void Start()
    {
        
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false; // stops the audio playing on start.

        button.onClick.AddListener(() => PlaySound()); // This sends the code to void PlaySound()
    
    }

        // Update is called once per frame
        void Update()
    {

    }

    void PlaySound() {
        source.PlayOneShot(sound); // This plays the audio source that is attached to the script.
    }


}


