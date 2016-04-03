using UnityEngine;
using System.Collections;

public class Homerun : MonoBehaviour {

    public Transform particleLocation;

    public GameObject particlesPrefab;

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        StartCoroutine(homerunParticles());
    }

    IEnumerator homerunParticles()
    {
        float timer = 5.0f;

        GameObject particles = Instantiate(particlesPrefab, particleLocation.position, Quaternion.identity) as GameObject;

        while(timer > 0)
        {
            timer -= Time.deltaTime;
            yield return null;
        }
        Destroy(particles);
    }


}
