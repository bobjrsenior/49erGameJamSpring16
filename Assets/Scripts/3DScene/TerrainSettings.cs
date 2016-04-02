using UnityEngine;
using System.Collections;

public class TerrainSettings : MonoBehaviour {

    /// <summary>
    /// The terrain component on this object
    /// </summary>
    private Terrain terrain;

	// Use this for initialization
	void Awake () {
        terrain = GetComponent<Terrain>();
        terrain.detailObjectDistance = QualitySettings.quality.terrainDetailDistance;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("TerrainDraw")) {
            terrain.detailObjectDistance += Input.GetAxis("TerrainDraw") * 5;
        }
	}
}
