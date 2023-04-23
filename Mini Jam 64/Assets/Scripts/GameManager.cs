using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;

    Player player;

    public TextMeshProUGUI scoreTXT;
    private float timer = 0f;
    public float delayAmount;

    public GameObject gameOverGUI;

    private void Awake()
    {
        player = FindObjectOfType<Player>();
    }
    void Update()
    {
        if (player != null)
        {
            timer += Time.deltaTime;

            if (timer >= delayAmount)
            {
                timer = 0f;
                score++;
                scoreTXT.text = score.ToString();
            }
        }
        else
        {
            gameOverGUI.SetActive(true);
        }
    }
}
