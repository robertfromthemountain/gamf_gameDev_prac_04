using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = 5.0f * Vector3.down;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = rb.velocity.normalized * 6.0f;
    }
}
