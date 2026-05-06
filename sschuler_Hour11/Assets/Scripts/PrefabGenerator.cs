using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        // Spawn 10 prefabs in a line
        for (int i = 0; i < 10; i++)
        {
            // Modify position so each one is spaced apart
            Vector3 spawnPosition = transform.position + new Vector3(i * 2f, 0, 0);

            Instantiate(prefab, spawnPosition, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Whenever we hit the B key we will generate a prefab at the
        // position of the original prefab
        // Whenever we hit the space key, we will generate a prefab at the
        // position of the spawn object that this script is attached to
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
