using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingScript : MonoBehaviour
{
    public float amplitude = 1.0f;
    public float frequency = 1.0f;
    public float offsetY = 0.0f;
    public GameObject floor;
    private Rigidbody rb;
    private float time = 0.0f;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        time += Time.deltaTime;

        // Calculate sinusoidal force based on time and position relative to floor
        float floorY = floor.transform.position.y + offsetY;
        float positionY = transform.position.y;
        float forceY = amplitude * Mathf.Sin(1.0f * Mathf.PI * frequency * time) * Mathf.Abs(positionY - floorY);
        Vector3 force = new Vector3(0.0f, forceY, 0.0f);

        // Apply force to Rigidbody
        rb.AddForce(force);
    }
}
