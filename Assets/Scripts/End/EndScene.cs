using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene(0);
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            SceneManager.LoadScene("Baseball");
        }
    }
}
