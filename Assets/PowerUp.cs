using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float multiplier = 1.1f;
    public GameObject pickupEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Pickup(collision);
        }
    }

    void Pickup (Collider2D player)
    {
        Debug.Log("PowerUp picked up");

        //Spawn a cool effect
        Instantiate(pickupEffect, transform.position, transform.rotation);

        //Apply effect to the player
        player.transform.localScale *= multiplier;

        //Remove power up object
        Destroy(gameObject);
    }
}
