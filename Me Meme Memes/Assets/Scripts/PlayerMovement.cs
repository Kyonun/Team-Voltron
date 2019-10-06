using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;
    public float jumpForce = 5f;
    public bool onGround = false;

    private SpriteRenderer playerRenderer;

    void Awake()
    {
        playerRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;

        if (playerRenderer != null)
        {
            if (movement.x > 0.01f)
                playerRenderer.flipX = false;
            else if (movement.x < -0.01f)
                playerRenderer.flipX = true;
        }
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }

    }
}
