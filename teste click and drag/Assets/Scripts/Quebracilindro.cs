using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quebracilindro : MonoBehaviour {

	public GameObject cilindroquebrado;
	public GameObject cilindrointeiro;



	void Start () {
		cilindroquebrado.SetActive(false);
		cilindrointeiro.SetActive(true);
	}

	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Objetos"){
			cilindroquebrado.transform.position = cilindrointeiro.transform.position;
			cilindroquebrado.SetActive(true);
			cilindrointeiro.SetActive(false);
		}
	}
}
