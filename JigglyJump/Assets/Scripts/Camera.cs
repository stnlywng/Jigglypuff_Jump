using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float smoothSpeed = .1f;
    public Transform target;
    public EndScreen endScreen;

    private bool isStarted = false;
    private Vector3 curVelo;

    void FixedUpdate()
    {
        if (isStarted)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, newPos, smoothSpeed);
            transform.position = smoothedPosition;
        }

        if (gameObject.transform.position.y < 5)
        {
            endScreen.initiate();
        }
    }

    public void getStarted()
    {
        isStarted = true;
    }
}
