using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D _rb2d;


    // Start is called before the first frame update
    void Start()
    {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb2d.velocity = new Vector2(_rb2d.velocity.x, jumpForce * 2 * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");

        _rb2d.velocity = new Vector2(moveInput * speed * Time.fixedDeltaTime, _rb2d.velocity.y);
    }
}
