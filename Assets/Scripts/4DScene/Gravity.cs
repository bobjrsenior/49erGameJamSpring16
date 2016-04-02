using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour {

    public int planetaryIndex;

    public PlanetaryController controller;

    private double mass = 1.0f;

    public float density = 1.0f;

    public Vector3 initialVelocity = Vector3.zero;

    private Rigidbody rigidbody;

    public bool act = true;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();

        mass = Mathf.PI * transform.lossyScale.x * transform.lossyScale.y * density;
        rigidbody.mass = (float) mass;
        rigidbody.velocity = initialVelocity;

    }

	// Update is called once per frame
	void FixedUpdate () {
        if (act)
        {
            Gravity[] planets = controller.planets;

            Vector3 force = Vector3.zero;

            for (int e = 0; e < planets.Length; ++e)
            {
                if (e != planetaryIndex)
                {
                    Gravity planet = planets[e];

                    Vector3 direction = planet.transform.position - transform.position;


                    force += (float)(controller.GRAVITY_CONSTANT * ((mass * planet.mass) / direction.sqrMagnitude)) * direction.normalized;
                }
            }
            rigidbody.AddForce(force);
        }
	}
}
