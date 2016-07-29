using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class scr_OwnerController : MonoBehaviour {

	public float thrust;
	public Rigidbody rb;
	public List<GameObject> spheres;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		FindAllSpheres ();
		Debug.Log(spheres.Count);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			rb.AddForce(transform.forward * thrust);
		}
	}

	void FindAllSpheres () {
		GameObject[] sphoreos = UnityEngine.Object.FindObjectsOfType<GameObject>() ;
		for(var i = 0; i < sphoreos.Length; ++i)
		{
			if(sphoreos[i].name == "Sphere")
			{
				spheres.Add (sphoreos [i]);
			}
		}
	}
}
