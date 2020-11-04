using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody;

    private float movementSpeed = 50f;
    private float jumpStrength = 60f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(new Vector2(-10f * movementSpeed * Time.deltaTime, 0f));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(new Vector2(10f * movementSpeed * Time.deltaTime, 0f));
        }
    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidbody.AddForce(new Vector2(0f, 10f * jumpStrength * Time.deltaTime));
        }
    }
}



