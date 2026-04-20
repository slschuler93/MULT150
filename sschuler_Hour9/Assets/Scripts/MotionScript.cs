using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0f, moveZ);

        rb.velocity = movement * speed;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "LTrigger" || other.gameObject.name == "RTrigger")
        {
            Debug.Log("Entered trigger: " + other.gameObject.name);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "LTrigger" || other.gameObject.name == "RTrigger")
        {
            Debug.Log("Staying in trigger: " + other.gameObject.name);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "LTrigger" || other.gameObject.name == "RTrigger")
        {
            Debug.Log("Exited trigger: " + other.gameObject.name);
        }
    }
}
