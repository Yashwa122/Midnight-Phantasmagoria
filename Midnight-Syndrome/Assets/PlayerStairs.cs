using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStairs : MonoBehaviour
{
    private GameObject currentStair;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentStair != null)
            {
                transform.position = currentStair.GetComponent<Stairs>().GetDestination().position;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Stair"))
        {
            currentStair = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Stair"))
        {
            if (collision.gameObject == currentStair)
            {
                currentStair = null;
            }
        }
    }

}
