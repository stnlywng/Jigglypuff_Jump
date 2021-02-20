using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public TextMesh scoreText;

    private int curScore = 0;

    public Score(int curScore, Vector3 newPos)
    {
        //scoreText.text = "" + curScore;
        //gameObject.GetComponent<Transform>().position.Set(newPos.x, newPos.y, newPos.z);
    }


    public void display(Vector3 newPos)
    {
        curScore += 10;
        scoreText.text = "" + curScore;
        scoreText.color = Color.white;

        gameObject.transform.position = newPos;
        //StartCoroutine(ExampleCoroutine());
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
        scoreText.color = new Color(0, 0, 0, 0);
    }

    public int getScore()
    {
        return curScore;
    }
}
