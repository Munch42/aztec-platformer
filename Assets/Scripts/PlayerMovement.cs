using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    [Range(1,50)]
    public float jumpForce;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;
    private float moveInput;
    private bool jumping;

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
            _rb2d.velocity = Vector2.up * jumpForce; //new Vector2(_rb2d.velocity.x, jumpForce * 2 * Time.deltaTime);
        }

        if (_rb2d.velocity.y < 0)
        {
            _rb2d.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }

        /*if (Input.GetKeyDown(KeyCode.Space))
        { 
            jumping = true;
        }
        else
        {
            jumping = false;
        }*/
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");

        _rb2d.velocity = new Vector2(moveInput * speed * Time.fixedDeltaTime, _rb2d.velocity.y);

        /*if (jumping == true)
        {
            _rb2d.velocity = new Vector2(_rb2d.velocity.x, jumpForce * 2 * Time.fixedDeltaTime);
        }*/
    }
}
