using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    
     public GameObject obstacle;
     public Transform spawnPoint;
     int score = 0;

    public TextMeshProUGUI scoreText;
    public GameObject playButton;
    public GameObject player;


    // art is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator SpawnObstacle()
    {
        while (true)
        {
            float waitTime = Random.Range(0.7f, 2f);

            yield return new WaitForSeconds(waitTime);

            Instantiate(obstacle, spawnPoint.position, Quaternion.identity);

        }

    }


    void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }


    public void GameStart()
    {
        playButton.SetActive(true);
        playButton.SetActive(false);

        StartCoroutine(SpawnObstacle());
        InvokeRepeating("UpdateScore", 2f, 1f);

    }
}
