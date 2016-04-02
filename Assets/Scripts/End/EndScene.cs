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
	}
}
