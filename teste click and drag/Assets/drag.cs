﻿using UnityEngine;
using System.Collections;

public class drag : MonoBehaviour {
	//float distance = 10;
    float throwForce = 600;
    Vector3 objectPos;
    float distance;

    public bool canHold = true;
    public GameObject item;
    public GameObject tempParent;
    public bool isHolding = false;

    void Update()
    {
        //check isHolding
        if(isHolding==true)
        {
            item.GetComponent<Rigidbody>().velocity = Vector3.zero;
            item.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            item.transform.SetParent(tempParent.transform);

            if(Input.GetMouseButtonDown(1))
            {
                //throw
            }
            else
            {
                objectPos = item.transform.position;
                item.transform.SetParent(null);
                item.GetComponent<Rigidbody>().useGravity = true;
                item.transform.position = objectPos;
            }
        }
    }

    void OnMouseDown()
    {
        isHolding = true;
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().detectCollisions = true;
    }

    private void OnMouseUp()
    {
        isHolding = false;
    }

    //void OnMouseDrag(){
    //	Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
    //	Vector3 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
    //	transform.position = objPosition;
    //}
}
