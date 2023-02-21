using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxInteraction : MonoBehaviour
{
    [SerializeField] private LayerMask boxMask;

    private List<BoxMovement> boxes = new List<BoxMovement>();

    private void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            GetBox();
        }

        else if(boxes.Count > 0)
        {
            RemoveBox();
        }
    }

    private void GetBox()
    {
        RaycastHit2D left = Physics2D.Raycast(transform.position, Vector2.left, 0.3f, boxMask);
        RaycastHit2D right = Physics2D.Raycast(transform.position, Vector2.right, 0.3f, boxMask);

        if (left.collider != null && left.collider.transform.CompareTag("Box"))
        {
            left.collider.gameObject.GetComponent<BoxMovement>().Move(transform);
            SlowMovementSpeed();
        }

        if (right.collider != null && right.collider.transform.CompareTag("Box"))
        {
            right.collider.gameObject.GetComponent<BoxMovement>().Move(transform);
            SlowMovementSpeed();
        }
    }

    private void SlowMovementSpeed()
    {
        gameObject.GetComponent<PlayerMovement>().ChangeMovementSpeed(3f);
    }

    public void AddBox(BoxMovement box)
    {
        boxes.Add(box);
    }

    private void RemoveBox()
    {
        foreach(BoxMovement box in boxes)
        {
            box.ClearParent();
        }

        boxes = new List<BoxMovement>();

        gameObject.GetComponent<PlayerMovement>().ResetMovementSpeed();
    }
}
