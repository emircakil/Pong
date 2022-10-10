using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float movementSpeed;
    public string moveCode;
    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw(moveCode);

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movementSpeed;
    }
}
