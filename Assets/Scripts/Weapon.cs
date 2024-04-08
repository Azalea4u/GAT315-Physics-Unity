using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] GameObject ammo;
    [SerializeField] Transform emission;
    [SerializeField] AudioSource audioSource;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetMouseButtonDown(0) ||Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Play();
            Instantiate(ammo, emission.position, emission.rotation);
        }
    }
}
