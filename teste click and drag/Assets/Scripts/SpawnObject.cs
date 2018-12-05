using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    public Vector3 SpawnPosition;
    public float SpawnWaitSeconds;

    public void spawnaObject(GameObject newObject, Transform parent, Quaternion rotation){
        
        StartCoroutine(RespawnObject(newObject, parent, rotation));

    }

    IEnumerator RespawnObject(GameObject newObject, Transform parent, Quaternion rotation)
    {
        GameObject respawnObject = Instantiate(newObject, SpawnPosition, rotation, parent.transform);
        respawnObject.SetActive(false);

        yield return new WaitForSeconds(SpawnWaitSeconds);

        respawnObject.SetActive(true);

    }

}