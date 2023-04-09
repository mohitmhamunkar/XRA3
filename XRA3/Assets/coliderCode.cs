using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coliderCode : MonoBehaviour
{
    public GameObject musicGameObject;
    public AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("GameController"))
        {
            musicGameObject.GetComponent<BackGroudMusic>().playNewMusic(audiosource);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
