﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int scoreGive = 100;



    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Game.obj.AddScore(scoreGive);

            AudioManager.obj.PlayCoin();
            FXManager.obj.ShowPop(transform.position);
            gameObject.SetActive(false);
        }
    }
}
