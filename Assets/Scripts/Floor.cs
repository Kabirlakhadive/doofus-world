using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor  : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public GameObject[] spawnPoints;
    // Startis called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

     public GameObject SpawnFloor()
    {
        int rand = Random.Range(0, spawnPoints.Length);
        GameObject selectedPoint = spawnPoints[rand];
        GameObject spawnedObject = Instantiate(prefabToSpawn, selectedPoint.transform.position, Quaternion.identity);
        return spawnedObject; // Return the newly instantiated GameObject
    }
}
