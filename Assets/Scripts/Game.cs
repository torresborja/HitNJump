﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public static Game obj;

    public int maxLives = 3;

    public bool gamePaused = false;
    public int score = 0;

    private void Awake()
    {
        obj = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        gamePaused = false;
    }

    public void AddScore(int scoreGive)
    {
        score += scoreGive;
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnDestroy()
    {
        obj = null;
    }
}
