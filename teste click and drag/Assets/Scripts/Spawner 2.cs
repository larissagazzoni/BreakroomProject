using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner2 : MonoBehaviour {

    public Transform spawnPos;
    //public GameObject spawnee;

	public void spawnaObject(GameObject brokenObject){
        
        StartCoroutine(spawnWait(brokenObject));

    }

    IEnumerator spawnWait(GameObject brokenObject){

        yield return new WaitForSeconds(1f);
        GameObject.Instantiate(brokenObject, spawnPos.position, spawnPos.rotation);
    }
}
