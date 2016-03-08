using UnityEngine;
using System.Collections.Generic;

public class RayCaster : MonoBehaviour {
    GameObject[] lines;
    public List<GameObject> list = new List<GameObject>();
    int lastIndex;
	Transform Effect;
	RaycastHit hit;
	public float multiplier = 10f;
	//GameObject[] cube = GameObject.FindGameObjectsWithTag("rotatable");
	// Use this for initialization
	void Start () {
        lastIndex = 0;
		//Renderer rend = GetComponent<Renderer> ();
	}

    

    // Update is called once per frame
    void Update () {

        //CreateLines(list);

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
                        noder.GetComponent<Renderer>().material.color = Color.green;
                        AddGameObject(list, noder);
						
					}

				}
			}
		

		}

        lines = GameObject.FindGameObjectsWithTag("line");

        AdjustLines(list, lines);

        if (list.Count > 1)
        {
            //CreateLines(points);
            //lineRenderer.SetPositions(points);
            //lineRenderer.enabled = true;
        }
        else
        {
            //lineRenderer.enabled = false;
        }

    }

    List<GameObject> AddGameObject(List<GameObject> nodelist, GameObject obj)
    {
        nodelist.Add(obj);
        CreateLines(nodelist);
        Debug.Log("Ready to return");
        return nodelist;
    }

    List<GameObject> RemoveGameObject(List<GameObject> nodelist, GameObject obj)
    {
        nodelist.Remove(obj);
        return nodelist;
    }

    void CreateLines(List<GameObject> points)
    {
        for (int i = 0; i < points.Count - 1; i++)
        {
            Vector3 start = points[i].transform.position;
            Vector3 end = points[i + 1].transform.position;


            GameObject line = (GameObject)Instantiate(Resources.Load("beam"));
            Debug.Log("Errors here");
            line.GetComponent<LineRenderer>().SetPositions(new Vector3[] { start, end });

            //Create Line with start and end points.
        }
        return;
    }

    void AdjustLines(List<GameObject> points, GameObject[] lines)
    {
        for(int i=0; i < points.Count - 1; i++)
        {
            lines[i].GetComponent<LineRenderer>().SetPositions(new Vector3[] { points[i].transform.position, points[i + 1].transform.position });
        }
        return;
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
