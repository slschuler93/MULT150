using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int healthpoints = 3992;

    void Start()
    {
        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);

        healthpoints = UsePotion(healthpoints);
        Debug.Log(healthpoints);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int UsePotion(int health)
    {
        health += 400;
        return health;
    }
}
