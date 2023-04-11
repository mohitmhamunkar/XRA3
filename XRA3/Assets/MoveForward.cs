using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using Oculus.Platform;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private Rigidbody rigidbody;
    private float speed=8f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed += Time.deltaTime * 1f;
        Vector3 direction = transform.forward; // get the forward direction of the object
        rigidbody.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
    }  
}
