using UnityEngine;
using System.Collections;

public class LeftRight : MonoBehaviour {

    private float time = 0.0f;

    public float offsetRadians = 0.0f;
    private float initialX;

    void Start()
    {
        initialX = transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.fixedDeltaTime;
        transform.position = new Vector3(initialX + 5 * Mathf.Sin(offsetRadians + Mathf.PI * time * 0.3f), transform.position.y, 0);
    }
}
