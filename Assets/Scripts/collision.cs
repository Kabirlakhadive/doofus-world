using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour

{
    public GameOverScript gameOver;
   void OnTriggerEnter(Collider other)
   {
        gameOver.Setup(ScoreManager.scoreCount);
        //Time.timeScale = 0f; // Stop all gameplay
        Debug.Log("Game Over");

   }
}
