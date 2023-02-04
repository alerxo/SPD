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
            parent.GetComponent<GoblinCombat>().Dead();
        }
    }
}
