using UnityEngine;
using System.Collections;

public class PlayerMovement1D : MonoBehaviour {

    /// <summary>
    /// Movement speed in Units/Second
    /// </summary>
    private float movementSpeed = 4.0f;

    /// <summary>
    /// This gameobject's Rigidbody2D
    /// </summary>
    private Rigidbody2D rigidbody;

    /// <summary>
    /// This gameobject's BoxCollider2D
    /// </summary>
    private BoxCollider2D collider;

    /// <summary>
    /// This gameobject's SpriteRenderer
    /// </summary>
    private SpriteRenderer renderer;

    private bool frozen = false;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (Input.GetButtonDown("Jump"))
        {
            frozen = !frozen;
            if (frozen)
            {
                collider.enabled = false;
                renderer.enabled = false;
                rigidbody.velocity = Vector2.zero;
            }
            else
            {
                collider.enabled = true;
                renderer.enabled = true;
            }
        }

        if (!frozen) { 
            rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * movementSpeed, 0, 0);
        }

        Camera.main.transform.position = new Vector3(transform.position.x, 0, Camera.main.transform.position.z);
	}
}
