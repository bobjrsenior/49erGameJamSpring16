using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private float time = 0.0f;

    private Text text;

    void Start()
    {
        text = GetComponent<Text>();
        text.text = "0.00";
    }
	
	// Update is called once per frame
	void Update () {
	    time += Time.deltaTime;
        text.text = "" + ((int)(time * 100)) / 100.0f;
    }
}
