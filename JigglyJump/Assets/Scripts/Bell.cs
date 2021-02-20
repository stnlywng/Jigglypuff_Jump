using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell : MonoBehaviour
{
    private const float jumpForce = 59f;
    public GameObject camera;
    public ParticleSystem explosion;
    public Score score;

    private const int distanceUnderCameraToDelete = 30;


    void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
        if (rb != null)
        {
            Vector3 velocity = rb.velocity;
            velocity.y = jumpForce;
            rb.velocity = velocity;
        }
        Instantiate(explosion, gameObject.GetComponent<Transform>().position, Quaternion.identity);
        score.display(gameObject.GetComponent<Transform>().position);
        Destroy(gameObject);
    }

    void FixedUpdate()
    {
        if (camera.GetComponent<Transform>().position.y > gameObject.GetComponent<Transform>().position.y + distanceUnderCameraToDelete)
        {
            Destroy(gameObject);
        }
    }

}
