using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quebra01 : MonoBehaviour {

	public GameObject CuboQuebrado;
	public GameObject CuboInteiro;

	void Start () {
		CuboQuebrado.SetActive(false);
		CuboInteiro.SetActive(true);
	}

	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Objetos"){
			CuboQuebrado.SetActive(true);
			CuboInteiro.SetActive(false);
		}
	}
}
