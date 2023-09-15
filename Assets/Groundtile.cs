using UnityEngine;

public class Groundtile : MonoBehaviour {

    Groundspawner Groundspawner;

    private void Start() {
        Groundspawner = GameObject.FindObjectOfType<Groundspawner>();        
    }

    private void OnTriggerExit (Collider other)
    {
        Groundspawner.SpawnTile();
        Destroy(gameObject, 2);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
