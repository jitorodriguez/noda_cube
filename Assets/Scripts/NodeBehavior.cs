using UnityEngine;
using System.Collections;

public class NodeBehavior : MonoBehaviour {

	public GameObject cube;
	public GameObject node1;
    public GameObject node2;
    public GameObject node3;
    public GameObject node4;
    GameObject[] nodeList;

	// Use this for initialization
	void Start () {
		
		Vector3 cubeOrigin = cube.transform.localPosition;
		float scale = cube.transform.localScale.x / 4;
		//Vector3 newPos = Vector3(cubeOrigin.x, cubeOrigin.y, cubeOrigin.z - scale); 
		node1.transform.localPosition = new Vector3((scale / 4), (scale / 4), (scale / 2));
        node2.transform.localPosition = new Vector3((scale / 4), -(scale / 4), (scale / 2));
        node3.transform.localPosition = new Vector3(-(scale / 4), (scale / 4), (scale / 2));
        node4.transform.localPosition = new Vector3(-(scale / 4), -(scale / 4), (scale / 2));
        nodeList[0] = node1;
        nodeList[1] = node2;
        nodeList[2] = node3;
        nodeList[3] = node4;
        //node1.transform.localPosition = new Vector3(cubeOrigin.x + (scale / 4), cubeOrigin.y + (scale / 4), cubeOrigin.z + scale / 2);
        //node1.transform.parent = cube.transform;


    }
	
	// Update is called once per frame
	void Update () {
	
		Vector3 cubeOrigin = cube.transform.localPosition;
		//float scale = cube.transform.localScale.x / 2;
        node1.transform.parent = cube.transform;
        node2.transform.parent = cube.transform;
        node3.transform.parent = cube.transform;
        node4.transform.parent = cube.transform;

        //if(nodeList[0].GetComponent<Renderer>().material.color == Color.green && )

    }
}
