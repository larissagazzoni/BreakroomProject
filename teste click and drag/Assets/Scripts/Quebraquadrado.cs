using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quebraquadrado : MonoBehaviour {

	public GameObject CuboQuebrado;
	public GameObject CuboInteiro;

	public GameObject scriptObject; // e isso aqui

	/*void Start () {
		CuboQuebrado.SetActive(false);
		CuboInteiro.SetActive(true);
	}*/

	/*void OnCollisionEnter (Collision col){
		
		if (col.gameObject.tag == "Objetos"){
			CuboQuebrado.transform.position = CuboInteiro.transform.position;

           // scriptObject.GetComponent<SpawnObject>().spawnaCuboObject(this.gameObject); // isso aqui

            CuboQuebrado.SetActive(true);
			CuboInteiro.SetActive(false);

			FindObjectOfType<AudioGerente>().Play("Madeira 1"); 

		}
	}*/
}
