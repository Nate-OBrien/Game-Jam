using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score = 0;
    public GameObject enemy;
    public GameObject player;

    private bool enemySpawned = false;
    void Update()
    {
        score = Mathf.FloorToInt(Time.timeSinceLevelLoad);
        scoreText.text = $"Score: {score}";

        if(score % 4 == 0 && !enemySpawned){
            for (int i = 0; i < 3; i++) // Loop to spawn 3 enemies
            {
                Instantiate(enemy, player.transform.position + new Vector3(Random.Range(-250, 250), Random.Range(-250, 250), Random.Range(-250, 250)), Quaternion.identity);
            }
            enemySpawned = true; // Set to true after spawning 3 enemies
        } 
        else if (score % 4 != 0) {
            enemySpawned = false; // Reset for the next spawn cycle
        }
    }
}