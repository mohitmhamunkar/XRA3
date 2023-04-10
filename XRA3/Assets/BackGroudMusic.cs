using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackGroudMusic : MonoBehaviour
{
    static AudioSource previousAudioSource;
    public static AudioSource newSource;

    void Start()
    {



    
    }
    public void playNewMusic(AudioSource newAudiosource)
    {
      

     
        newSource = newAudiosource;
        SceneManager.LoadScene("PlayScene");

    }


}
