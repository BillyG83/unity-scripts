using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private readonly float speed = 10.0f;
    private PlayerController playerControllerScript;

    void Start() {
        // getting a reference to the ./PlayerController.cs code
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.isGameOver == false) {
            // speed x time (so not once per frame) x left value
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }
    }
}
