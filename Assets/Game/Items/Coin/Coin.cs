using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private GameObject questObj;

    private void Awake()
    {
        questObj = GameObject.FindGameObjectWithTag("Quest");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            questObj.GetComponent<Quest>().IncreaseCoin(1);

            Destroy(gameObject);
        }
    }
}
