using UnityEngine;
using System.Collections;

public class LookUp : MonoBehaviour {

    /// <summary>
    /// Rotation Speed in Degrees/Second
    /// </summary>
    private float rotationSpeed = 20.0f;

    public float minAngle = -90.0f;

    public float maxAngle = 75.0f;

    void Start()
    {
        minAngle = 360 - minAngle;
    }

    // Update is called once per frame
    void FixedUpdate () {

        transform.Rotate(new Vector3(-Input.GetAxis("Mouse Y") * rotationSpeed * Time.fixedDeltaTime, 0, 0));

    }
}
