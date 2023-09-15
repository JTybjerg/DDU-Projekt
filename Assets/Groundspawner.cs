using UnityEngine;

public class Groundspawner : MonoBehaviour {

    public GameObject groundTile;
    Vector3 nextSpawnPoint;

    public void SpawnTile () 
    {
        GameObject temp = instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    private void Start () {
        for (int i=0; i < 10; i++) {
            SpawnTile();
        }
    }
}       
    