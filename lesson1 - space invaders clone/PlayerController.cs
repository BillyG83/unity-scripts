using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput = 0.0f;
    public float speed = 12.0f;
    public float xRange = 12.0f;

    // set in unity to reference the prefab projectile (wine bottle)    
    public  GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        // stops player leaving screen by resetting its x position
        if (transform.position.x < -xRange) {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange) {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // input ranges from -1 to +1
        horizontalInput = Input.GetAxis("Horizontal");
        // transform player position move player left or right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
