using UnityEngine;
using System.Collections;

public class NodeBehavior : MonoBehaviour {

	public GameObject cube;
	public GameObject node1;

	// Use this for initialization
	void Start () {
		
		Vector3 cubeOrigin = cube.transform.localPosition;
		float scale = cube.transform.localScale.x / 2;
		//Vector3 newPos = Vector3(cubeOrigin.x, cubeOrigin.y, cubeOrigin.z - scale); 
		node1.transform.localPosition = new Vector3(cubeOrigin.x, cubeOrigin.y, cubeOrigin.z + scale);

	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 cubeOrigin = cube.transform.localPosition;
		float scale = cube.transform.localScale.x / 2;
		//Vector3 newPos = Vector3(cubeOrigin.x, cubeOrigin.y, cubeOrigin.z - scale);
		node1.transform.localPosition = new Vector3(cubeOrigin.x, cubeOrigin.y, cubeOrigin.z + scale);
		transform.RotateAround (cubeOrigin, Vector3.up, 20 * Time.deltaTime);

	}
}
