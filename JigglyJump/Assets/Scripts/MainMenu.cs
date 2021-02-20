using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public Jigglypuff jigglypuff;
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        //camera = GetComponent<>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            jigglypuff.getStarted();
            camera.getStarted();
            Destroy(gameObject);
        }
    }
}
