using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOutOfMap : MonoBehaviour
{
    void Start()
    {

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Floor"))
        {
            Debug.Log("Out");
        }
    }
}