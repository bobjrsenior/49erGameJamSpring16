using UnityEngine;
using System.Collections;

public class QualitySettings : MonoBehaviour {

    public static QualitySettings quality;

    public string qualityLevel = "Medium";

    public int terrainDetailDistance = 80;

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
            setQualityLow();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            setQualityMedium();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            setQualityHigh();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            setQualitySuperMaximum();
        }
    }

    public void setQualitySuperMaximum()
    {
        terrainDetailDistance = 500;
        qualityLevel = "SuperMaximum";
    }

    public void setQualityHigh()
    {
        terrainDetailDistance = 150;
        qualityLevel = "High";
    }

    public void setQualityMedium()
    {
        terrainDetailDistance = 80;
        qualityLevel = "Medium";
    }

    public void setQualityLow()
    {
        terrainDetailDistance = 40;
        qualityLevel = "Low";
    }
}
