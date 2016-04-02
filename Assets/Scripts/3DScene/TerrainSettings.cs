using UnityEngine;
using System.Collections;

public class TerrainSettings : MonoBehaviour {

    /// <summary>
    /// The terrain component on this object
    /// </summary>
    private Terrain terrain;

    private float terrainQuality;

	// Use this for initialization
	void Awake () {
        terrain = GetComponent<Terrain>();
        terrainQuality = QualitySettings.quality.terrainDetailDistance;
        terrain.detailObjectDistance = terrainQuality;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("TerrainDraw")) {
            terrain.detailObjectDistance += Input.GetAxis("TerrainDraw") * 5;
            terrainQuality = terrain.detailObjectDistance;
            QualitySettings.quality.terrainDetailDistance = terrainQuality;
        }

        if(terrainQuality != QualitySettings.quality.terrainDetailDistance)
        {
            terrainQuality = QualitySettings.quality.terrainDetailDistance;
            terrain.detailObjectDistance = terrainQuality;
        }
    }
}
