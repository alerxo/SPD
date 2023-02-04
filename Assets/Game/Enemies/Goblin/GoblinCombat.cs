using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinCombat : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            collision.gameObject.SendMessage("DamageTaken", 1f);
        }
    }

    public void Dead()
    {
        Destroy(gameObject);
    }
}
