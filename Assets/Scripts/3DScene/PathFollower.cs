using UnityEngine;
using System.Collections;

public class PathFollower : MonoBehaviour {

    private Rigidbody rigidbody;

    private Vector3 target;

    private Vector4 bounds = new Vector4(120, 407, 84, 371);

    private float goalDistance = 0.5f;

    private float goalDistanceSquared;

    private float movementSpeed;

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
        goalDistanceSquared = goalDistance * goalDistance;
        getNewTarget();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = target - transform.position;
        direction.y = 0;

	    if(direction.sqrMagnitude < goalDistanceSquared)
        {
            getNewTarget();
        }
        else
        {
            direction.Normalize();
            rigidbody.velocity = direction * movementSpeed;

        }
	}

    private void getNewTarget()
    {
        target.x = Random.Range(bounds[0], bounds[1]);
        target.z = Random.Range(bounds[2], bounds[3]);
        movementSpeed = Random.Range(4.0f, 15.0f);
    }
}
