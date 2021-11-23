using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlller : MonoBehaviour
{
    public GameObject obstacle;
    public float spawnTime;
    float m_spawnTime;
    bool m_isGameOver;
    int m_score;

    public int Score { get => m_score; set => m_score = value; }

    // Start is called before the first frame update
    void Start()
    {
        m_spawnTime = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (m_isGameOver)
        {
            m_spawnTime = 0;
            return;
        }

        m_spawnTime -= Time.deltaTime;
        if(m_spawnTime <= 0)
        {
            SpawnObstacle();
            m_spawnTime = spawnTime;
        }
    }

    public void SpawnObstacle()
    {
        float randYpos = Random.Range(-2.75f, -1f);
        Vector2 spawnPos = new Vector2(11, randYpos);
        if (obstacle)
        {
            Instantiate(obstacle, spawnPos, Quaternion.identity);
        }
    }

    public void SetScore(int value)
    {
        m_score = value;
    }

    public int GetScore()
    {
        return m_score;
    }


    public void ScoreIncrement()
    {
        m_score++;
    }

    public bool IsGameOver()
    {
        return m_isGameOver;
    }

    public void setGameoverState(bool state)
    {
        m_isGameOver = state;
    }


}
