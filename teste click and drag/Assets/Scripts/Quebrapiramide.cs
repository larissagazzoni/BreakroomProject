using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quebrapiramide : MonoBehaviour {

	public GameObject CuboQuebrado;
	public GameObject CuboInteiro;



	void Start () {
		CuboQuebrado.SetActive(false);
		CuboInteiro.SetActive(true);
	}

	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Objetos"){
			CuboQuebrado.transform.position = CuboInteiro.transform.position;
			CuboQuebrado.SetActive(true);
			CuboInteiro.SetActive(false);
		}
	}
}
