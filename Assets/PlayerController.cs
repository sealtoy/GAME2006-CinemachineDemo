using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10.0f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Basic Movement Logic 
        float dt = Time.deltaTime;
        float dirY = 0.0f;
        float dirX = 0.0f;

        // W to move Pos in the Y axis
        if (Input.GetKey(KeyCode.W))
        {
            dirY = 1.0f;
        }
        // S to move Neg in the Y axis
        else if (Input.GetKey(KeyCode.S))
        {
            dirY = -1.0f;
        }
        // D to move Pos in the X axis
        if (Input.GetKey(KeyCode.D))
        {
            dirX = 1.0f;
        }
        // A to move Neg in the X axis
        else if (Input.GetKey(KeyCode.A))
        {
            dirX = -1.0f;
        }

        // Changes Player position Speed based off of the speed, direction, and deltatime
        float dx = speed * dirX * dt;
        float dy = speed * dirY * dt;
        transform.position = transform.position + new Vector3(dx, dy, 0.0f);
    }
}
