using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour
{

    public Text scoreText;
    public Score score;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    public void initiate()
    {
        scoreText.text = "Final Score: " + score.getScore();
        gameObject.SetActive(true);
    }
}
