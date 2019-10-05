using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Simply moves a game object
/// </summary>
public class MoveScript : MonoBehaviour
{
    /// <summary>
    /// 1 - Object speed
    /// </summary>
    public Vector2 speed = new Vector2(10, 10);

    /// <summary>
    /// Moving direction 
    /// </summary>
    public Vector2 direction = new Vector2(-1, 0);

    // 2 - Store the movement and the component
    private Vector2 movement;
    private Rigidbody2D rigidbodyComponent;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 4 - Movement
        movement = new Vector2(
            speed.x * direction.x,
            speed.y * direction.y);
    }

    private void FixedUpdate()
    {
        // 5 - Get the component and store the reference
        if (rigidbodyComponent == null) rigidbodyComponent = GetComponent<Rigidbody2D>();

        // 6 - apply movement to the rigidbody
        rigidbodyComponent.velocity = movement;
    }
}
