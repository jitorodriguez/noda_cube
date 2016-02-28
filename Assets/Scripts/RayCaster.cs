using UnityEngine;
using System.Collections;

public class RayCaster : MonoBehaviour {

    public GameObject mainCube;

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

            if (Physics.Raycast(ray, out hit, 1000)) {

				Debug.Log ("You hit");

				if (hit.collider.gameObject.CompareTag("node")) {
					GameObject noder = hit.collider.gameObject;

                    //LINE RENDERER???
                    /* Temporary Plan to incorporate node relationship with Raycaster
                    if(noder.power == false)
                    {
                        //Check nodes connected by wire of current node
                           for all nodes in question connected by a wire
                           {
                           --- if checked node is on
                               {
                           --- --- noder.power == true;
                           --- --- wire in question.power == true; EVENT HANDLER: Wire script must turn on node
                                    continue;                      *ASSUMING ONLY ONE VALID OPTION*
                               }
                           }
                        if noder.power == true && noder == finalnode
                        {
                            Run Win state();
                        }
                    */


                    if (noder.GetComponent<Renderer> ().material.color == Color.green) {
						
						noder.GetComponent<Renderer> ().material.color = Color.white;

					} else {
						noder.GetComponent<Renderer>().material.color = Color.green;
					}

				}
			}
		

		}

        else if(Input.GetMouseButtonDown(1))
        {

        }
	}
}
