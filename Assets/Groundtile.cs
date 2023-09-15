using UnityEngine;

public class Groundtile : MonoBehaviour {

    Groundspawner Groundspawner;

    privat void Start() {
        Groundspawner = GameObject.FindObjectOfType<Groundspawner>();        
    }

    privat void OnTriggerExit (Collider other)
    {
        Groundspawner.SpawnTile();
        Destroy(GameObject, 2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
