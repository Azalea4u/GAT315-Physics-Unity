using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class Block : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] TMP_Text pointsUI;

    public int points;

    public int Points 
    { 
        get { return points; }
        set
        {
            points = value;
            pointsUI.text = "Points: " + points.ToString();
        }
    }
    
    Rigidbody rb;
    bool destroyed = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (rb.velocity.magnitude > 2f || rb.angularVelocity.magnitude > 2f)
        {
            audioSource.Play();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (!destroyed && other.CompareTag("Kill") 
            && rb.velocity.magnitude == 0 
            && rb.angularVelocity.magnitude == 0)
        {
            destroyed = true;
            Points += 100;
            Destroy(gameObject);
        }
    }
}
