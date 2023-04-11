using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckAudioSource : MonoBehaviour
{
    public AudioSource audioSource;
    public TextMeshProUGUI endLevelText;
    public GameObject endGameObject;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (audioSource.time >= audioSource.clip.length)
        {
            endLevelText.text = "Level Finished";
            ControllerColision.endGame = true;
            endGameObject.SetActive(true);

        }

    }
}
