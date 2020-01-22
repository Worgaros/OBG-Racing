using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;
    SpriteRenderer spriteRenderer;
    
    Vector2 direction;
    [SerializeField] float speed;
    const float inverse = -1.0f;
    bool isMoving = false;
    bool isLookingLeft = true;
    
    bool isOnFloor = true;

    [SerializeField] GameObject controlsPanel;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        PlayerMovements();
    }

    void PlayerMovements()
    {
        if (Input.GetButtonDown("ChangeDirection") && !isMoving)
        {
            direction = new Vector2( speed * inverse, speed);
            isMoving = true;
            controlsPanel.SetActive(false);
        }
        else if (Input.GetButtonDown("ChangeDirection") && isMoving && isLookingLeft && Time.timeScale > 0)
        {
            direction = new Vector2(body.velocity.x * inverse, body.velocity.y);
            transform.Rotate (Vector3.forward * -90);
            isLookingLeft = false;
        }
        else if (Input.GetButtonDown("ChangeDirection") && isMoving && !isLookingLeft && Time.timeScale > 0)
        {
            direction = new Vector2(body.velocity.x * inverse, body.velocity.y);
            transform.Rotate (Vector3.forward * 90);
            isLookingLeft = true;
        }

        body.velocity = direction;
    }
}
