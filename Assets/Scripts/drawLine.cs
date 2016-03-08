using UnityEngine;
using System.Collections.Generic;

public class drawLine : MonoBehaviour
{
    GameObject raycaster; 
    RayCaster ray;

    private LineRenderer lineRenderer;
    private float counter;
    private float dist;

    //public GameObject Origin;
    //public GameObject Destination;

    public float lineDrawSpeed = 6f;

	// Use this for initialization
	void Start ()
    {
        raycaster = GameObject.Find("FirstPersonCharacter");
        ray = raycaster.GetComponent<RayCaster>();

        lineRenderer = GetComponent<LineRenderer>();
        //lineRenderer.SetPositions(new[] { Origin.transform.position, Destination.transform.position });
        lineRenderer.SetWidth(.45f, .45f);

        //dist = Vector3.Distance(Origin.transform.position, Destination.transform.position);
	}
	
	// Update is called once per frame
	void Update ()
    {

        /*Vector3 pointA = Origin.transform.position;
        Vector3 pointB = Destination.transform.position;
        Vector3[] points = new[] { pointA, pointB };
        lineRenderer.SetPositions(points);
        */

        Vector3[] points = GenerateArray(ray.list);
        if (points.Length > 1)
        {
            lineRenderer.SetPositions(points);
            lineRenderer.enabled = true;
        }
        else
        {
            lineRenderer.enabled = false;
        }

    }

    Vector3[] GenerateArray(List<GameObject> nodes)
    {
        Vector3[] array = new Vector3[nodes.Count];
        
        for(int i = 0; i < 3; i++)
        {
            array[i] = nodes[i].transform.position;
        }
        return array;
    } 
}
/*if(counter < dist)
        {
            counter += .1f / lineDrawSpeed;

            float x = Mathf.Lerp(0, dist, counter);

            Vector3 pointA = Origin.transform.position;
            Vector3 pointB = Destination.transform.position;
            Vector3[] points = new[] { pointA, pointB };

            Vector3 pointAlongLine = x * Vector3.Normalize(pointB - pointA) + pointA;

            lineRenderer.SetPositions(points);
        }*/
