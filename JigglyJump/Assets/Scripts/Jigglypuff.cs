using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Jigglypuff : MonoBehaviour
{

    public float moveSpeed = 4f;

    private const float jumpForce = 59f;
    private float movement = 0f;
    private bool started = false;

    private Rigidbody rb;
    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * moveSpeed;        
    }

    void FixedUpdate()
    {
        Vector3 velocity = rb.velocity;
        velocity.x = movement * 10;
        rb.velocity = velocity;

        animationUpdate(velocity);
    }

    public void getStarted()
    {
        started = true;
        Vector3 velocity = rb.velocity;
        velocity.y = jumpForce;
        rb.velocity = velocity;
        anim.SetBool("started", true);
    }

    void animationUpdate(Vector3 curVelo)
    {
        if (curVelo.y < 0)
        {
            anim.SetBool("isFalling", true);
        }
        else
        {
            anim.SetBool("isFalling", false);
        }
    }

}
