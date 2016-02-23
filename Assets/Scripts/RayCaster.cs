﻿using UnityEngine;
using System.Collections;

public class RayCaster : MonoBehaviour {

	Transform Effect;
	RaycastHit hit;
	public float multiplier = 10f;
	//GameObject[] cube = GameObject.FindGameObjectsWithTag("rotatable");
	// Use this for initialization
	void Start () {
		//Renderer rend = GetComponent<Renderer> ();
	}

	// Update is called once per frame
	void Update () {

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		//Vector3 fwd = transform.TransformDirection(Vector3.forward);

		if (Input.GetMouseButtonDown (0)) {

			if (Physics.Raycast(ray, out hit, 100)) {

				Debug.Log ("You hit");

				if (hit.collider.gameObject.CompareTag("node")) {
					Debug.Log ("You hit again!");
				hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;
				}
			}
		

		}
	}
}