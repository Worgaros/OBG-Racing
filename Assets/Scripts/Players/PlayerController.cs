using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;
    
    Vector2 direction;
    [SerializeField] float speed;
    [SerializeField] float inverse = -1;
    [SerializeField] private bool isMoving = false;
    
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    
    void Update()
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
}
