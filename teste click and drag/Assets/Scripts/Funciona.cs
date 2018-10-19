using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Funciona : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Cancel")) {
			Application.Quit ();
		}
		if (Input.GetButtonDown ("Restart")) {
			SceneManager.LoadScene("Level Design");
		}
	}
}
