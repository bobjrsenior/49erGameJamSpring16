using UnityEngine;
using System.Collections;

public class UpDown : MonoBehaviour {

    private float time = 0.0f;

    public float offsetRadians = 0.0f;

    public float factor = 0.8f;

    private float initialY;

    void Start()
    {
        initialY = transform.position.y;
    }

	// Update is called once per frame
	void FixedUpdate () {
        time += Time.fixedDeltaTime;
        transform.position = new Vector3(transform.position.x, initialY + 5 * Mathf.Sin(offsetRadians + Mathf.PI * time * factor), 0);
	}
}
