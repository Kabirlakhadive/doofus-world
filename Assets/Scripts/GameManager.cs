using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject firstFloor;
    private GameObject currentFloor;

    

    public float floorLifetime = 5.5f; 
    public static float currentFloorLife; 
    
    private int gameScore = 0; // Game score
    
    // Start is called before the first frame update
    void Start()
    {
        currentFloor = Instantiate(firstFloor, new Vector3(0, 0, 0), Quaternion.identity);
        currentFloor.SetActive(true);
        //currentFloorLife = floorLifetime;
        StartCoroutine(HandleFloorTransition()); 
    }

    void Update()
    {
        // Decrease the current floor life
        if (currentFloorLife > 0)
        {
            currentFloorLife -= Time.deltaTime;
        }
    }

    
    private IEnumerator HandleFloorTransition()
    {
        while (true) 
        {
            yield return new WaitForSeconds(5f); // 5 seconds

            // Spawn a new floor
            GameObject nextFloor = currentFloor.GetComponent<Floor>().SpawnFloor();

            yield return new WaitForSeconds(2.5f); //  2.5 seconds

            Destroy(currentFloor); // Destroy the current floor 
            
            currentFloor = nextFloor; // Update currentFloor 

            currentFloorLife = floorLifetime; // Reset floor life
            ScoreManager.scoreCount +=1; // Increase game score
            
            
        }
    }

    public float GetCurrentFloorLife()
    {
        return currentFloorLife;
    }

    // Method to get the current game score
    public int GetGameScore()
    {
        return gameScore;
    }
}
