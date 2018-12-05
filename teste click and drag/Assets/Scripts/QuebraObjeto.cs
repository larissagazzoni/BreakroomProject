using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuebraObjeto : MonoBehaviour {

    public GameObject ObjetoQuebrado;
    public GameObject ObjetoInteiro;

    private Transform parent;
    private Quaternion rotation;
    private GameObject gameManager;


    // Use this for initialization
    void Start () {
        parent = this.gameObject.transform.parent;
        rotation = this.rotation;
        gameManager = GameObject.Find("GameManager");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Objetos")
        {
            // Quebra o Objeto
            Instantiate(ObjetoQuebrado, this.transform.position, this.transform.rotation, this.transform.parent);
            ObjetoQuebrado.SetActive(true);

            // respawna o cubo
            if(this.gameObject.tag == "Cubo")
            {
                gameManager.GetComponent<SpawnObject>().spawnaObject(ObjetoInteiro, parent, rotation);
            }

            Destroy(this.gameObject);

        }
    }

}
