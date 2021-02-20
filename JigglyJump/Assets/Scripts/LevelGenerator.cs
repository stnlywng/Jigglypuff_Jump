using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject platformPrefab;

    public int numberOfPlatforms;
    float levelWidth = 45f;
    float minY = 5f;
    float maxY = 10f;

    // Start is called before the first frame update
    void Start()
    {

        Vector3 spawnPosition = new Vector3(0, 7, 0);
        for (int i=0;i<numberOfPlatforms;i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            spawnPosition.z = 8f;
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
