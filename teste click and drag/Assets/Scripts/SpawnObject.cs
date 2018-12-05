using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    public Vector3 spawnPos;

	public void spawnaCuboObject(GameObject brokenObject){
        
        StartCoroutine(spawnWait(brokenObject, "Cubos"));

    }

    // cria uma função pra cada bichinho que for quebrar com seu relativo pai
    public void spawnaVasoObject(GameObject brokenObject)
    {
        StartCoroutine(spawnWait(brokenObject, "Vasos"));
    }

    IEnumerator spawnWait(GameObject brokenObject, string parentName){

        yield return new WaitForSeconds(1f);

        GameObject item = GameObject.Instantiate(brokenObject, spawnPos, brokenObject.transform.rotation, GameObject.Find(parentName).transform);

        item.SetActive(true);

        Destroy(brokenObject);
    }
}