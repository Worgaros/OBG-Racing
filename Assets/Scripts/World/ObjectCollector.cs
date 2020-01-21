using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.CompareTag("Coin"))
        {
            Destroy(gameObject);
        }
        
        else if (gameObject.CompareTag("Trap"))
        {
            Destroy(gameObject);
        }
        
        else if (gameObject.CompareTag("Cup"))
        {
            Destroy(gameObject);
        }
    }
}
