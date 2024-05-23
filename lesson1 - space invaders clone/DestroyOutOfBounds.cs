using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBoundary = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Destroy is built in C# functionality
    // gameObject is equal to "this"
    // the object that calls the script
    void Update()
    {
        // to destroy projectile going up z axis
        if(transform.position.z > topBoundary) {
            Destroy(gameObject);
        }

        // to destroy NPCs down up z axis
        if(transform.position.z < -topBoundary) {
            Destroy(gameObject);
        }
    }
}
