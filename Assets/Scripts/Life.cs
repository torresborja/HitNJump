using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    public int scoreGive = 30;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Game.obj.AddScore(scoreGive);
            Player.obj.AddLive();

            FXManager.obj.ShowPop(transform.position);
            gameObject.SetActive(false);
        }
    }
}
