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

    bool isOnFloor = true;
    
    Quaternion theRotation;

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
        }
        else if (Input.GetButtonDown("ChangeDirection") && isMoving)
        {
            direction = new Vector2(body.velocity.x * inverse, body.velocity.y);
            transform.Rotate (Vector3.forward * -90);
        }

        body.velocity = direction;
    }
}
