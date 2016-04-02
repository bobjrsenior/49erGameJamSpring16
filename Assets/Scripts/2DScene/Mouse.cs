using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {

    /// <summary>
    /// How much to accelerate mouse movement
    /// </summary>
    private float movementScale = 16.0f;

    // Update is called once per frame
    void FixedUpdate () {
        transform.Translate(new Vector3(Input.GetAxis("Mouse X") * movementScale * Time.fixedDeltaTime, Input.GetAxis("Mouse Y") * movementScale * Time.fixedDeltaTime, 0));
	}
}
