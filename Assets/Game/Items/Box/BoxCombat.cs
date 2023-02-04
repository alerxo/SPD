using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCombat : MonoBehaviour
{
    public void Dead()
    {
        Destroy(gameObject);
    }
}
