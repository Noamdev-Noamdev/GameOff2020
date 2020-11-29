using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : MonoBehaviour
{
    public float multiplier = 1.9f;

    public GameObject pickupEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider2D player)
    {
        // Effect
        Instantiate(pickupEffect, transform.position, transform.rotation);

        // Play Effect
        PlayerMovement run = player.GetComponent<PlayerMovement>();
        run.runSpeed *= multiplier;

        // Remove Powerup
        Destroy(gameObject);
    }

}
