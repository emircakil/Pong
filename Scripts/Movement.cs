using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movement : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public Transform transform;
    public float speed;
 

    private void Start()
    {
        rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, 0);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody2D.velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rigidbody2D.velocity = new Vector2(0, speed * -1);
        }
        else
        {
            rigidbody2D.velocity = new Vector2(0, 0);
        }
    }
    


}

