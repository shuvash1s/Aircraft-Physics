using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AircraftPhysics : MonoBehaviour
{
    private Rigidbody rb;

    public Transform centerOfMass;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetupDynamics()
    {
        rb.centerOfMass = centerOfMass.position;
        Vector3 CenterOfPressure;
    }
}
