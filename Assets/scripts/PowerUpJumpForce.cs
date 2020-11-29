using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpJumpForce : MonoBehaviour
{
    public float multiplier = 2f;

    public GameObject pickupEffect;

    void OnTriggerEnter2D (Collider2D other)
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
        CharacterMove move = player.GetComponent<CharacterMove>();
        move.m_JumpForce *= multiplier;

        // Remove Powerup
        Destroy(gameObject);
    }

}
