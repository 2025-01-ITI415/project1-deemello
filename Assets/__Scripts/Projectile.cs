using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Don't destroy if it hits the player
        if (collision.collider.CompareTag("Player"))
        {
            return;
        }

        // Don't destroy if it hits a hazard (falling block)
        if (collision.collider.CompareTag("Hazard"))
        {
            return;
        }

        // Destroy projectile on any other collision (platforms, ground, etc.)
        Destroy(gameObject);
    }
}
