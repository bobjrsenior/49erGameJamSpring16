using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Wall : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
