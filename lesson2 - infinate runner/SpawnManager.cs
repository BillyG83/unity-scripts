using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new(25, 0, 0);
    private readonly float startDelay = 2;
    private readonly float repeatRate = 2;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start() {
        // repeating spawner
        InvokeRepeating(nameof(SpawnObstacle), startDelay, repeatRate);
        // getting a reference to the ./PlayerController.cs code
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObstacle() {
        if(playerControllerScript.isGameOver == false) {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
