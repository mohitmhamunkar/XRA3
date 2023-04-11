using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class coliderCode : MonoBehaviour
{
    public Collider door;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LeftController" || other.gameObject.tag == "RightController") {
            Physics.IgnoreCollision(door, other, true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "LeftController" || other.gameObject.tag == "RightController")
        {
            Physics.IgnoreCollision(door, other, false);
        }
    }

    }
