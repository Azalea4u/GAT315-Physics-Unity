using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public KeyCode spawnKey = KeyCode.Space;

    void Update()
    {
        if (Input.GetKeyDown(spawnKey))
        {
            SpawnPrefab();
        }
    }

    void SpawnPrefab()
    {
        if (prefab != null)
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
        else
        {
            Debug.LogError("Prefab to spawn is not assigned!");
        }
    }
}
