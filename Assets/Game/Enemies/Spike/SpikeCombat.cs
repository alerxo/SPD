using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeCombat : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            collision.gameObject.SendMessage("Dead");
        }
    }

    public void Dead()
    {
        Destroy(gameObject);
    }
}
