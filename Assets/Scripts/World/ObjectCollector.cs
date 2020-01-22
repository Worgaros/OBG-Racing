using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollector : MonoBehaviour
{
    [SerializeField] GameObject player;
    Rigidbody2D playerBody;

    int coinsNumber = 0;
    
    [SerializeField] GameObject victoryPanel;
    
    [SerializeField] AudioSource coinSound;

    private void Start()
    {
        playerBody = player.GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.CompareTag("Coin"))
        {
            coinsNumber++;
            coinSound.Play();
            Destroy(gameObject);
        }
        
        else if (gameObject.CompareTag("Trap"))
        {
            Destroy(gameObject);
        }
        
        else if (gameObject.CompareTag("Cup"))
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            victoryPanel.SetActive(true);
        }
    }
}
