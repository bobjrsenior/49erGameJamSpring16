using UnityEngine;
using System.Collections;

public class Lighting3D : MonoBehaviour {

    private float rotationSpeed = 5.0f;

    private Light light;

    public int lightIndex = 0;

    private float intensity;
	
    void Start()
    {
        light = GetComponent<Light>();

        if (lightIndex == 1)
        {
            transform.Rotate(0, 0, 180.0f);
            intensity = light.intensity / 2;
        }
    }

	// Update is called once per frame
	void Update () {
        if (QualitySettings.quality.qualityLevel.Equals("SuperMaximum") || QualitySettings.quality.qualityLevel.Equals("High"))
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
            if(lightIndex == 1)
            {
                light.intensity = intensity;
            }
        }
        
	}
}
