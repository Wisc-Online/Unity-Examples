using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ActionOnCollisionTester : MonoBehaviour {
    private Rigidbody rb;

    private void Start()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    // Use this for initialization
    public void GoUp()
    {
        rb.velocity = Vector3.up * 10;
    }
}
