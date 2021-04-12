
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Rigidbody rb;
    public PlayerMovement movement;
    //public float forwardForce = 2000f;


    void OnCollisionEnter (Collision collisionInfo) {

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
