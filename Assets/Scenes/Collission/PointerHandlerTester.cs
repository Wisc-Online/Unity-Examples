using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerHandlerTester : MonoBehaviour {
    private Rigidbody rb;
    private Renderer theRenderer;

    private void Start()
    {
        this.rb = GetComponent<Rigidbody>();
        this.theRenderer = GetComponent<Renderer>();
    }

    public void MoveUp()
    {
        rb.velocity = Vector3.up * 5;
    }

    public Material hoverMaterial, downMaterial, upMaterial, exitMaterial;

    public void Enter()
    {
        theRenderer.material = hoverMaterial;
    }

    public void Exit()
    {
        theRenderer.material = exitMaterial;
    }

    public void Up()
    {
        theRenderer.material = upMaterial;
    }

    public void Down()
    {
        theRenderer.material = downMaterial;
    }
}
