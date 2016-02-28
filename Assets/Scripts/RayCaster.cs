using UnityEngine;
using System.Collections.Generic;

public class RayCaster : MonoBehaviour {

    public List<GameObject> list = new List<GameObject>(1);
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

                    if (noder.GetComponent<Renderer> ().material.color == Color.green)
                    {

                        RemoveGameObject(list, noder);
						noder.GetComponent<Renderer> ().material.color = Color.white;

					}
                    else
                    {
                        AddGameObject(list, noder);
						noder.GetComponent<Renderer>().material.color = Color.green;
					}

				}
			}
		

		}

	}

    List<GameObject> AddGameObject(List<GameObject> nodelist, GameObject obj)
    {
        nodelist.Add(obj);
        return nodelist;
    }

    List<GameObject> RemoveGameObject(List<GameObject> nodelist, GameObject obj)
    {
        nodelist.Remove(obj);
        return nodelist;
    }
}
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
