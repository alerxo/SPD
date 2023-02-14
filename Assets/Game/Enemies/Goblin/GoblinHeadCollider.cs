using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinHeadCollider : MonoBehaviour
{
    private GameObject parent;

    private void Awake()
    {
        parent = transform.parent.gameObject;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Destroy(parent.GetComponent<GoblinCombat>());
            parent.GetComponent<GoblinCombat>().Dead();
            collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            collision.gameObject.GetComponent<Rigidbody2D>().angularVelocity = 0;
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 300, 0));
        }
    }
}
