using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour {

    public static Spawner spawn;

    /// <summary>
    /// Booundaries for spawning
    /// </summary>
    public Vector4 bounds;

    /// <summary>
    /// How many items to spawn/how many items are left
    /// </summary>
    private int items = 1;

    public GameObject itemPrefab;

	// Use this for initialization
	void Start () {
        spawn = this;
        if (SceneManager.GetActiveScene().name.Equals("3DLevel"))
        {
            spawnItems();
        }
        else
        {
            items = GameObject.FindGameObjectsWithTag("Item").Length;
        }
	}

    public void spawnItems()
    {
        for(int e = 0; e < items; ++e)
        {
            Instantiate(itemPrefab, new Vector3(Random.Range(bounds[0], bounds[1]), 22, Random.Range(bounds[2], bounds[3])), Quaternion.identity);
        }
    }
	
	public void gotItem()
    {
        if(--items == 0)
        {
            spawn = null;            
            if (SceneManager.GetActiveScene().name.Equals("3DLevel"))
            {
                SceneManager.LoadScene("2DLevel");
            }
            else if(SceneManager.GetActiveScene().name.Equals("2DLevel"))
            {
                SceneManager.LoadScene("2DLevel2");
            }
            else if (SceneManager.GetActiveScene().name.Equals("2DLevel2"))
            {
                SceneManager.LoadScene("1DLevel");
            }
        }
    }
}
