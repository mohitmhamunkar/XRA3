using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroudMusic : MonoBehaviour
{
    public AudioSource audiosource;
    static AudioSource previousAudioSource;
    void Start()
    {



        // Play the sound
        audiosource.loop = true;

        audiosource.Play();
    }
    public void playNewMusic(AudioSource newAudiosource)
    {
        if (previousAudioSource != null) {
            previousAudioSource.Stop();
        }
        previousAudioSource = newAudiosource;
        audiosource.Stop();
        newAudiosource.loop = true;

        newAudiosource.Play();
    }


}
