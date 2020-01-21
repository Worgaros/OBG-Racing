using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;
    
    Vector2 direction;
    [SerializeField] float speed;
    const float inverse = -1;
    bool isMoving = false;

    bool isOnFloor = true;
    
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
        }

        body.velocity = direction;
    }

//    private void OnTriggerExit2D(Collider2D other)
//    {
//        if(other.CompareTag("Floor"))
//        {
//            Debug.Log("Out");
//        }
//    }
}
