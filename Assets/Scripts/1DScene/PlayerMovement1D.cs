using UnityEngine;
using System.Collections;

public class PlayerMovement1D : MonoBehaviour {

    /// <summary>
    /// Movement speed in Units/Second
    /// </summary>
    private float movementSpeed = 7.0f;

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
        if (!frozen) { 
            rigidbody.velocity = new Vector3(Input.GetAxis("Horizontal") * movementSpeed, 0, 0);
        }

        Camera.main.transform.position = new Vector3(transform.position.x, 0, Camera.main.transform.position.z);
	}

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            frozen = true;

            collider.enabled = false;
            renderer.enabled = false;
            rigidbody.velocity = Vector2.zero;
        }
        else if (Input.GetButtonUp("Jump"))
        {
            frozen = false;

            collider.enabled = true;
            renderer.enabled = true;
        }
    }
}
