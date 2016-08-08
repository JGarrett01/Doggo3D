using UnityEngine;
using System.Collections;
using Fungus;
public class scr_DogInteraction : MonoBehaviour {

	public bool jaxTennisBall = false;
	public scr_PlayerController playerController;

	// Use this for initialization
	void Start () {
		playerController = GetComponent<scr_PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "TennisBall") 
		{
			jaxTennisBall = true;
		}
	}
}
