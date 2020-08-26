using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;

    [SerializeField]
    int forceInZ;

    [SerializeField]
    int forceInX;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forceInZ * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-forceInX * Time.fixedDeltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(forceInX * Time.fixedDeltaTime, 0, 0);
        }
    }
}
