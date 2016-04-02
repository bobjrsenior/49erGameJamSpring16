using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour {

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SceneManager.LoadScene("3DLevel");
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
