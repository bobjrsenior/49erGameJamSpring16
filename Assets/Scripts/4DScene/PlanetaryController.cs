using UnityEngine;
using System.Collections;

public class PlanetaryController : MonoBehaviour {

    public Gravity[] planets;

    public double GRAVITY_CONSTANT = 5000000000;

	// Use this for initialization
	void Start () {
        planets = GameObject.FindObjectsOfType<Gravity>();
        for(int e = 0; e < planets.Length; ++e)
        {
            planets[e].planetaryIndex = e;
            planets[e].controller = this;
        }
	}
}
