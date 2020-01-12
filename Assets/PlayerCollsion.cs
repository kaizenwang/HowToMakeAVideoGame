using UnityEngine;

public class PlayerCollsion : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle") 
		{
            movement.enabled = false;
		}
    }
}
