using UnityEngine;
using System.Collections;

public class QualitySettings : MonoBehaviour {

    public static QualitySettings quality;

    public string qualityLevel = "SuperMinimum";

    public float terrainDetailDistance = 80;

    void Awake()
    {
        if(quality != null)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            quality = this;
            DontDestroyOnLoad(this.gameObject);

            qualityLevel = "Medium";

            terrainDetailDistance = 80;
        }
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            setQualitySuperMinimum();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            setQualityLow();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            setQualityMedium();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            setQualityHigh();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            setQualitySuperMaximum();
        }
    }

    public void setQualitySuperMaximum()
    {
        qualityLevel = "SuperMaximum";
        terrainDetailDistance = 500;
        RenderSettings.fog = true;
        Camera.main.farClipPlane = 1000;
    }

    public void setQualityHigh()
    {
        qualityLevel = "High";
        terrainDetailDistance = 150;
        RenderSettings.fog = false;
        Camera.main.farClipPlane = 1000;
    }

    public void setQualityMedium()
    {
        qualityLevel = "Medium";
        terrainDetailDistance = 80;
        RenderSettings.fog = false;
        Camera.main.farClipPlane = 1000;
    }

    public void setQualityLow()
    {
        qualityLevel = "Low";
        terrainDetailDistance = 40;
        RenderSettings.fog = false;
        Camera.main.farClipPlane = 500;
    }

    public void setQualitySuperMinimum()
    {
        qualityLevel = "SuperMinimum";
        terrainDetailDistance = 0;
        RenderSettings.fog = false;
        Camera.main.farClipPlane = 250;
    }
}
