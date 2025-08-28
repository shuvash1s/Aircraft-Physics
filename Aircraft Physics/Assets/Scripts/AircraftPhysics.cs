using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftPhysics : MonoBehaviour
{
    private Rigidbody rb;

    public Transform centerOfMass;

    public Transform forcesParent;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SetupDynamics();
    }

    void SetupDynamics()
    {
        rb.centerOfMass = centerOfMass.position;
        Vector3 CenterOfPressure;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        // Loop through all child transforms
        foreach (Transform child in forcesParent)
        {
            Gizmos.DrawWireSphere(child.position, .1f);
        }
    }
}
