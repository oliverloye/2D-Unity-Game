using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 10;
    public int enemyDamage = 5;
    public GameObject deathEffect;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    public void Attack (int damage)
    {
        //Do dmg on collision with Player object
    }

    private void OnCollisionEnter2D(Collision2D _colInfo)
    {
        CharacterController2D _player = _colInfo.collider.GetComponent<CharacterController2D>();
        if (_player != null)
        {
            _player.DamagePlayer(enemyDamage);
            Debug.Log("Player got hit by " + enemyDamage + " damage!");
        }
    }

    void Die ()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
