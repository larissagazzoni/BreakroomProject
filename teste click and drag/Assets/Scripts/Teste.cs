using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teste : MonoBehaviour {

	public GameObject replacement;
	public bool canBreak = false;

	void OnCollisionEnter()
	{
		if (canBreak) {
			GameObject.Instantiate (replacement, transform.position, transform.rotation);

			Destroy (gameObject);
		}
	}
	void OnCollisionExit()
	{
		//canBreak == true;
	}
}
