using UnityEngine;
using System.Collections;

public class BaseballBat : MonoBehaviour {

    private float rotationSpeed = 25.0f;

    private Rigidbody rigidbody;

    private Quaternion initialAngle;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.maxAngularVelocity = 500;

        initialAngle = rigidbody.rotation;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        //rigidbody.AddRelativeTorque(0, rotationSpeed * Input.GetAxis("Jump"), 0);
        rigidbody.angularVelocity = new Vector3(0, -rotationSpeed * Input.GetAxis("Jump"), 0);
        //rigidbody.MoveRotation(Quaternion.Euler(rigidbody.rotation.eulerAngles + new Vector3(0, -rotationSpeed * Input.GetAxis("Jump"), 0)));

        if(transform.eulerAngles.y < 120)
        {
            rigidbody.angularVelocity = Vector3.zero;
        }

        transform.Translate(0, -2.0f * Input.GetAxis("Vertical") * Time.fixedDeltaTime, 0);
	}

    void Update()
    {

        if (Input.GetButtonUp("Jump"))
        {
            rigidbody.rotation = initialAngle;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
