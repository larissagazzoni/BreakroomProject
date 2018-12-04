using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    public Vector3 spawnCuboPos;
    //public GameObject spawnee;

	public void spawnaCuboObject(GameObject brokenObject){
        
        StartCoroutine(spawnWait(brokenObject, spawnCuboPos));

    }

    IEnumerator spawnWait(GameObject brokenObject, Vector3 spawnPos){

        yield return new WaitForSeconds(1f);
		//brokenObject.transform.position = spawnPos;
		GameObject go = GameObject.Instantiate(brokenObject);

		go.GetComponent<Quebraquadrado>().CuboQuebrado.SetActive(false);
		go.GetComponent<Quebraquadrado>().CuboInteiro.SetActive(true);
        //GameObject.Instantiate(brokenObject, spawnPos);
    }
}