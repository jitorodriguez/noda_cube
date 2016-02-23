using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	 float horizontalSpeed = 10;
	 float verticleSpeed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float h =(horizontalSpeed * Input.GetAxis ("Mouse X"));
		float v = verticleSpeed * Input.GetAxis ("Mouse Y");
		transform.Rotate (-v, h, 0);
	}
}
