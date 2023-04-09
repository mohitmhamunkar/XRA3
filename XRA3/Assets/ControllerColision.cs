using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerColision : MonoBehaviour
{
    public AudioSource audiosource;

    private void OnCollisionEnter(Collision other)
    {
        audiosource.Play();
    }
}
