using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawaner : MonoBehaviour
{
    public GameObject[] playObjects;
    public Transform[] points;
    public Light pLight;

    public void onBeatStart()
    {
        GameObject pObject = Instantiate(playObjects[Random.Range(0,3)], points[Random.Range(0,3)]);
        pObject.SetActive(true);
        
        pLight.color = pObject.GetComponent<Renderer>().material.color;

        pObject.transform.localPosition = Vector3.zero;
        if (pObject.gameObject.tag == "Door") {
            pObject.gameObject.transform.position = new Vector3(pObject.gameObject.transform.position.x, -0.69f, pObject.gameObject.transform.position.z);
            pObject.gameObject.transform.localScale = new Vector3(Random.Range(1, 10)*0.1f, Random.Range(8, 12) * 0.1f,1f);

        }
       
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
