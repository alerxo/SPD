using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour
{
    private int totalCoinAmount;

    private int currentCoinAmount = 0;

    private GameObject portal;

    private void Awake()
    {
        portal = GameObject.FindGameObjectWithTag("Portal");
        portal.SetActive(false);

        totalCoinAmount = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    public void IncreaseCoin(int increaseAmount)
    {
        currentCoinAmount += increaseAmount;

        if(currentCoinAmount == totalCoinAmount)
        {
            QuestCompleted();
        }
    }

    private void QuestCompleted()
    {
        portal.SetActive(true);
    }
}
