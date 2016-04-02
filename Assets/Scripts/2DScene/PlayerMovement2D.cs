using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerMovement2D : MonoBehaviour {

    /// <summary>
    /// Movement speed in Units/Second
    /// </summary>
    private float movementSpeed = 5.0f;

    /// <summary>
    /// How fast jumping moves you up in Units/Second
    /// </summary>
    private float jumpSpeed = 7.5f;

    /// <summary>
    /// The maximum possible vertical speed in Units/Second
    /// </summary>
    public float maxJumpSpeed = 8.0f;

    /// <summary>
    /// This object's rigidbody2D
    /// </summary>
    private Rigidbody2D rigidbody;

    /// <summary>
    /// How much horizontal speed you lose in %/Second (1.00 = 100%/Second)
    /// </summary>
    private float speedLossPercent = 5.00f;

    /// <summary>
    /// Can the object jump?
    /// </summary>
    private bool canJump = true;

	// Use this for initialization
	void Awake () {
        rigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //Grabbing velocity preserves velocity components not used
        Vector3 velocity = rigidbody.velocity;
        if (Input.GetButton("Horizontal"))
        {
            velocity.x += Input.GetAxis("Horizontal") * movementSpeed * 5 * Time.fixedDeltaTime;
        }
        else if (velocity.x != 0)
        {
            //Lose velocity at a rate of speedLossPercent of total velocity per second
            velocity.x -= velocity.x * speedLossPercent * Time.fixedDeltaTime;
            //Make sure to stop completely at some point
            if (Mathf.Abs(velocity.x) < 0.1f)
            {
                velocity.x = 0;
            }
        }

        if (canJump && Input.GetButton("Jump"))
        {
            velocity.y += jumpSpeed;
            canJump = false;
        }

        //Cap the maximum vertical velocity
        if (velocity.y > maxJumpSpeed)
        {
            velocity.y = maxJumpSpeed;
        }


        rigidbody.velocity = velocity;
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        canJump = true;
    }


}
