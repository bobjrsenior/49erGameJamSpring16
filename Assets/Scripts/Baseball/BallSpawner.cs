using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    public bool pitch = false;

    private float timer = 5.0f;

    public GameObject baseballPrefab;

    public Transform mound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        timer -= Time.fixedDeltaTime;
        if (timer <= 0)
        {
            timer = Random.Range(2.5f, 8.0f);
            if (pitch)
            {

            }
            else
            {
                Instantiate(baseballPrefab, transform.position, Quaternion.identity);
            }
        }
	}
}
