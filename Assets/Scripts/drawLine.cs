using UnityEngine;
using System.Collections;

public class drawLine : MonoBehaviour
{

    private LineRenderer lineRenderer;
    private float counter;
    private float dist;

    public GameObject Origin;
    public GameObject Destination;

    public float lineDrawSpeed = 6f;

	// Use this for initialization
	void Start ()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPositions(new[] { Origin.transform.position, Destination.transform.position });
        lineRenderer.SetWidth(.45f, .45f);

        dist = Vector3.Distance(Origin.transform.position, Destination.transform.position);
	}
	
	// Update is called once per frame
	void Update ()
    {

        Vector3 pointA = Origin.transform.position;
        Vector3 pointB = Destination.transform.position;
        Vector3[] points = new[] { pointA, pointB };
        lineRenderer.SetPositions(points);

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

    }
}
