using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
   public int score;
    public static GameManager inst;

    public Text scoreText;
    public PlayerMovement playerMovement;

    public void AddScore()
    {
        score++;
        scoreText.text = "SCORE: " + score;
      
        playerMovement.speed += playerMovement.speedIncrease;
    }


    private void Awake()
    {
        inst = this;
    }

  
}
