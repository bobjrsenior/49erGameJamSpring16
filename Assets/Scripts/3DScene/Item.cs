using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        Spawner.spawn.gotItem();
        Destroy(this.gameObject);
    }
}
