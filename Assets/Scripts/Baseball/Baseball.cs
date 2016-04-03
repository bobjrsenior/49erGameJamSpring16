using UnityEngine;
using System.Collections;

public class Baseball : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(delayDeath());
	}

    IEnumerator delayDeath()
    {
        yield return new WaitForSeconds(15);
        Destroy(this.gameObject);
    }
}
