using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] alienPrefabs;
    private float spawnRangeX = 10;
    private float spawnPosz = 10;
    public TextMeshProUGUI scoreText;
    private int score;




    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAlien", 2, 1.5f);
        score = 0;
        scoreText.text = "Score:" + score;
        UpdateScore(0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAlien()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosz);
        int alienNumber = Random.Range(0, alienPrefabs.Length);
        Instantiate(alienPrefabs[alienNumber], spawnPos, alienPrefabs[alienNumber].transform.rotation);
    }
   public void UpdateScore(int scoreAddition)
    {
        scoreText.text = "Score: " + score;
        score += scoreAddition;
    }
}

