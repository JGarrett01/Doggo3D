using UnityEngine;
using System.Collections;

public class scr_Owner2Fetch : MonoBehaviour {

	public GameObject ballLaunch;
	public Rigidbody rb;
	public float thrust;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "TennisBall2")
		{
			rb = other.GetComponent<Rigidbody> ();
			other.gameObject.transform.position = ballLaunch.transform.position;

			rb.AddForce (transform.forward * thrust);
		}
	}
}
