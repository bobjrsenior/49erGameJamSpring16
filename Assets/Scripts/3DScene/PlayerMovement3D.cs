using UnityEngine;
using System.Collections;

public class PlayerMovement3D : MonoBehaviour {


    /// <summary>
    /// Maximum Movement speed in Units/Second
    /// </summary>
    private float maxMovementSpeed = 10.0f;

    /// <summary>
    /// Acceleration in Units/Second/Second
    /// </summary>
    private float acceleration = 20.0f;

    /// <summary>
    /// Rotation Speed in Degrees/Second
    /// </summary>
    private float rotationSpeed = 30.0f;

    private Rigidbody rigidbody;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();

        Cursor.lockState = CursorLockMode.Locked;
    }

	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Vector3 velocity = rigidbody.velocity;

        if(Mathf.Abs(velocity.x) > maxMovementSpeed)
        {
            velocity.x = maxMovementSpeed * Mathf.Sign(velocity.x);
        }
 

        if (Mathf.Abs(velocity.z) > maxMovementSpeed)
        {
            velocity.z = maxMovementSpeed * Mathf.Sign(velocity.z);
        }

        if (!Input.GetButton("Horizontal") && !Input.GetButton("Vertical"))
        {
            velocity.x *= 0.9f;
            if (velocity.x < 0.01f)
            {
                velocity.x = 0;
            }

            velocity.z *= 0.9f;
            if (velocity.z < 0.01f)
            {
                velocity.z = 0;
            }
        }


        transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X") * rotationSpeed * Time.fixedDeltaTime, 0));

        rigidbody.velocity = velocity;

        rigidbody.AddRelativeForce(new Vector3(acceleration * Input.GetAxis("Horizontal"), 0, acceleration * Input.GetAxis("Vertical")));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
