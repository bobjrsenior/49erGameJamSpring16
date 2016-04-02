using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Star : MonoBehaviour {

    public GameObject particleSystemPrefab;

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        GetComponent<Gravity>().act = false;
        GameObject obj = Instantiate(particleSystemPrefab, transform.position, Quaternion.identity) as GameObject;
        StartCoroutine(finishLevel(obj));
    }

    IEnumerator finishLevel(GameObject obj)
    {
        float timer = 0;
        while(timer < 8.2f)
        {
            timer += Time.deltaTime;
            yield return null;
        }
        Destroy(obj.gameObject);
        SceneManager.LoadScene("3DLevel");
    }

}
