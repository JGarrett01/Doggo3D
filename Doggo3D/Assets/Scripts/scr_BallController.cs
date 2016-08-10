using UnityEngine;
using System.Collections;

public class scr_BallController : MonoBehaviour {

	public GameObject ballSpawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "BallExit") 
		{
			this.transform.position = ballSpawn.transform.position;
		}
	}


}
