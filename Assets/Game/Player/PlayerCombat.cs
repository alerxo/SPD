using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCombat : MonoBehaviour
{
    private float maxHealth = 5f;
    private float health;

    private Vector2 spawnPoint;

    private void Awake()
    {
        health = maxHealth;

        spawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint").transform.position;
        transform.position = spawnPoint;
    }

    public void Heal(float healAmount)
    {
        float tempHealth = health + healAmount;

        health = Mathf.Clamp(tempHealth, 0, maxHealth);
    }

    public void DamageTaken(float damageAmount)
    {
        health -= damageAmount;

        if(health <= 0)
        {
            Dead();
        }
    }

    private void Dead()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
