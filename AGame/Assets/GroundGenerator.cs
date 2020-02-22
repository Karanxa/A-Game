using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour {

    public GameObject theGround;
    public Transform generationpoint;
    public float distanceBetween;

    private float groundWidth;
    // Use this for initialization
    void Start ()
    {
        groundWidth = theGround.GetComponent<BoxCollider>().size.x;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.z < generationpoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + groundWidth + distanceBetween, transform.position.y + groundWidth + distanceBetween, transform.position.z + groundWidth + distanceBetween);

            Instantiate(theGround, transform.position, Quaternion.identity);
        }
		
	}
}
