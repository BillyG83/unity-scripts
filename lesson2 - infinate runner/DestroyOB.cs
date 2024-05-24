using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOB : MonoBehaviour
{
    public float leftBoundary = -10;
    // Update is called once per frame
    void Update() {
        if (transform.position.x < leftBoundary) {
            Destroy(gameObject);
        }
    }
}
