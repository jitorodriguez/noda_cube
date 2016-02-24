using UnityEngine;
using System.Collections;

public class Rotating : MonoBehaviour {

	public GameObject cube;
	//public GameObject node1;
	public float multiplier = 10f;
	// Use this for initialization
	void Start () {

		//Get Location of Cube


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDrag(){

		Debug.Log ("Your draging");
		cube.transform.Rotate (Input.GetAxis ("Mouse Y") * multiplier, -Input.GetAxis ("Mouse X") * multiplier, 0, Space.World);
		
	}
}
