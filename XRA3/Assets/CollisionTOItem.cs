using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTOItem : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {

        List<string> controllers = new List<string>() { "LeftController", "RightController" };
        List<string> objects = new List<string>() { "Left", "Right" };
        //if (other.gameObject.CompareTag(gameObject.tag+ "Controller"))
        //{
        //    //Destroy(gameObject, 1f);
        //    //instan

        //}
        //else if (controllers.Contains(other.gameObject.tag))
        //{
        //    GetComponent<MoveForward>().enabled=false;
        //    if (other.gameObject.tag == "LeftController")
        //    {

        //        Vector3 velocity = OVRInput.GetLocalControllerVelocity(OVRInput.Controller.LTouch); // get the velocity of the controller
        //        float force = velocity.magnitude * 20f; // calculate the force based on the velocity
        //        gameObject.GetComponent<Rigidbody>().AddForce(velocity.normalized * force);
        //        //Destroy(gameObject, 1f);

        //    }
        //    else
        //    {
        //        Vector3 velocity = OVRInput.GetLocalControllerVelocity(OVRInput.Controller.RTouch); // get the velocity of the controller
        //        float force = velocity.magnitude * 20f; // calculate the force based on the velocity
        //        gameObject.GetComponent<Rigidbody>().AddForce(velocity.normalized * force);
        //        //Destroy(gameObject, 1f);
        //    }

        //}
        if (objects.Contains(other.gameObject.tag))
        {
            Destroy(gameObject);
        }

    }
}
