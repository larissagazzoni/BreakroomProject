using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quebracadeira : MonoBehaviour {

	public GameObject CadeiraInteira;
	public GameObject CadeiraQuebrada;



	void Start () {
		CadeiraQuebrada.SetActive(false);
		CadeiraInteira.SetActive(true);
	}

	void OnCollisionEnter (Collision col){
		if (col.gameObject.tag == "Objetos"){
			CadeiraQuebrada.transform.position = CadeiraInteira.transform.position;
			CadeiraQuebrada.SetActive(true);
			CadeiraInteira.SetActive(false);
		}
	}
}
