using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    public bool pitch = false;

    private float timer = 5.0f;

    public GameObject baseballPrefab;

    public Transform mound;
	
	// Update is called once per frame
	void FixedUpdate () {
        timer -= Time.fixedDeltaTime;
        if (timer <= 0)
        {
            timer = Random.Range(2.5f, 8.0f);
            if (pitch)
            {
                (Instantiate(baseballPrefab, mound.position, Quaternion.identity) as GameObject).GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-90.0f, -70.0f), Random.Range(2.0f, 3.0f), 0); ;
            }
            else
            {
                Instantiate(baseballPrefab, transform.position, Quaternion.identity);
            }
        }
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            pitch = !pitch;
        }
    }
}
