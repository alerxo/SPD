using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinMovement : MonoBehaviour
{
    [SerializeField]
    private Transform walkPoint1;
    [SerializeField]
    private Transform walkPoint2;

    private Vector2 point1;
    private Vector2 point2;

    private Vector2 movement = new Vector2(1, 0);

    private void Awake()
    {
        point1 = walkPoint1.transform.position;
        point2 = walkPoint2.transform.position;
    }

    private void Update()
    {
        if(transform.position.x <= point1.x)
        {
            movement = new Vector2(1, 0);
        }

        else if (transform.position.x >= point2.x)
        {
            movement = new Vector2(-1, 0);
        }

        gameObject.transform.Translate(movement * Time.deltaTime * 1f);
    }
}
