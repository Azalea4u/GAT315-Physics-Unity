using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidbodyMover : MonoBehaviour
{
    [SerializeField] Vector3 force;
    [SerializeField] ForceMode mode;
    [SerializeField] Vector3 torque;
    [SerializeField] ForceMode torqueMode;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(force, mode);
            rb.AddTorque(torque, torqueMode);
        }
    }
}
