using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawaner : MonoBehaviour
{
    public GameObject[] playObjects;
    public Transform[] points;


    public void onBeatStart()
    {
        GameObject pObject = Instantiate(playObjects[Random.Range(0,3)], points[Random.Range(0,3)]);
        pObject.SetActive(true);
        if (pObject.gameObject.tag == "Door") {
            pObject.gameObject.transform.localScale = new Vector3(Random.Range(3, 8)*0.1f, Random.Range(6, 8) * 0.1f,1f);

        }
        pObject.transform.localPosition = Vector3.zero;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
