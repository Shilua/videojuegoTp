using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDeath : MonoBehaviour
{
    public int score;
    private ScoreManager scoreManager;

    public void Awake()
    {

        GameObject manager = GameObject.Find("Manager");
        if (manager != null)
            scoreManager = manager.GetComponent<ScoreManager>();
    }

    public void Mori()
    {
        scoreManager.score += score;
    }
}
