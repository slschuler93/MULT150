using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float poisonDamage = 125.5f;
        float health = 1004f;
        Debug.Log(health);
        Debug.Log(poisonDamage);
        while (health > 0)
        {
            Debug.Log("Still alive! Health: " + health);
            health -= poisonDamage;

            if (health < 0)
                health = 0;
        }

        Debug.Log("Health reached zero. Game over.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
