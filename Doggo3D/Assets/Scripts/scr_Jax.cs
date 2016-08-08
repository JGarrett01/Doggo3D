using UnityEngine;
using System.Collections;
using Fungus;

public class scr_Jax : MonoBehaviour {

	public scr_PlayerController playerController;
	public bool hasBall = false;
	public GameObject inMouth;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (playerController.currPickup != null) 
		{
			inMouth = playerController.currPickup; 
		}


	}

	void Interactions()
	{
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player" && hasBall == false) 
		{
			Fungus.Flowchart.BroadcastFungusMessage ("JaxHello");
		}




		if (other.gameObject.tag == "Player" && other.gameObject.tag == "TennisBall" && hasBall == true) 
		{
			Fungus.Flowchart.BroadcastFungusMessage ("JaxBall");
		}
	}
}
