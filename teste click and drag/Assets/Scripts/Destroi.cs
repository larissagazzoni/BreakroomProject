using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroi : MonoBehaviour
{

    public GameObject destroyedVersion;


    void OnMouseDown()
    {
		Instantiate(destroyedVersion, this.transform.position, this.transform.rotation);
        Destroy(gameObject);
    }








}


