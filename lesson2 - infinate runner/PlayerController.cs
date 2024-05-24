using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;
    public ParticleSystem smokeExplosion;
    public float jumpForce = 6.0f;
    public float gravityModifier = 1.5f;
    public bool isOnGround = true;
    public bool isGameOver = false;

    void Start() {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update() {
        // space is pressed and player is touching the ground
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !isGameOver) {
            // JUMP!
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
        }
    }

    // reset isOnGround when player touches ground
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Ground")) {
            isOnGround = true;
        } else if (collision.gameObject.CompareTag("Obstacle")) {
            Debug.Log("GAME OVER!");
            isGameOver = true;
            smokeExplosion.Play();
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
        }
    }
}
