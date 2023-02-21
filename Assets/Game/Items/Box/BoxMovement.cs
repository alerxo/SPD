using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    public void Move(Transform parent)
    {
        parent.GetComponent<BoxInteraction>().AddBox(this);
        transform.SetParent(parent);
    }

    public void ClearParent()
    {
        transform.SetParent(null);
    }
}
