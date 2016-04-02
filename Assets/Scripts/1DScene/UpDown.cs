using UnityEngine;
using System.Collections;

public class UpDown : MonoBehaviour {

    private float time = 0.0f;

    private float initialY;

    void Start()
    {
        initialY = transform.position.y;
    }

	// Update is called once per frame
	void FixedUpdate () {
        time += Time.fixedDeltaTime;
        transform.position = new Vector3(0, initialY + 5 * Mathf.Sin(Mathf.PI * time * 0.8f), 0);
	}
}
