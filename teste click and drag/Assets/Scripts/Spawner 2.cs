﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner 2 : MonoBehaviour {

public Transform spawnPos;
public GameObject spawnee;

	
	// Update is called once per frame
	void Update () {
    if (Input.GetMouseButton(0))
    {
        Instantiate(spawnee, spawnPos.Position, spawnPos.Rotation);
    }
	}
}