using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavierBoxes : MonoBehaviour
{
    Rigidbody2D rb;
    float dirx, mvspd = 15f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }
    // Update is called once per frame
    void Update()
    {
        dirx = Input.GetAxisRaw("Horizontal") * mvspd;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirx, rb.velocity.y);    
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("PinkPlat"))
            this.transform.parent = collision.transform;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("PinkPlat"))
            this.transform.parent = null;
    }
}
