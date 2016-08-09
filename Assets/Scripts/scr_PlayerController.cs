using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Fungus;

public class scr_PlayerController : MonoBehaviour {

	public Flowchart flowchart;
	public List<GameObject> dogList;

	public bool canPickup = true;
	public bool hasPickup = false;
	public GameObject mouthHole;
	public GameObject currPickup;
	public GameObject player;
	public CapsuleCollider capCol;
	public CharacterJoint joint;

	//-------------------- Dog Interaction

	public scr_DogInteraction dogInteraction;



	void Start () 
	{
		capCol = GetComponent<CapsuleCollider> ();
		joint = GetComponentInChildren<CharacterJoint> ();
		dogInteraction = GetComponent<scr_DogInteraction> ();
	}

	void LateUpdate () 
	{
	//	currPickup.GetComponent<Collider> ().enabled = true;
		PickupController ();

		if (Input.GetKeyDown(KeyCode.Joystick1Button1))
		{
			dogList.Clear ();

		}

		//InteractWithDogs ();
	}


	//Pickup Controller decided whether an object can be picked up


	void PickupController()
	{
		if (currPickup != null && Input.GetAxis ("RightTrigger") >= 0.2) 
		{
			currPickup.transform.position = mouthHole.transform.position;
			joint.connectedBody = currPickup.GetComponent<Rigidbody>() ;

//			if (!currPickup.transform.IsChildOf(player.transform))
//				{
//					currPickup.transform.parent = player.transform;
//				}

			currPickup.GetComponent<Collider> ().enabled = false;

			capCol.enabled = false;
		}



		if (currPickup != null && Input.GetAxis ("RightTrigger") < 0.2) 
		{
			//currPickup.transform.parent = null;
			currPickup.GetComponent<Collider> ().enabled = true;
			currPickup = null;
			capCol.enabled = true;
			joint.connectedBody = null;
			dogInteraction.jaxTennisBall = false;
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (currPickup == null) 
		{
			if (other.gameObject.tag == "Pickup" || other.gameObject.tag == "TennisBall")
			{
				currPickup = other.gameObject;
			}
		}
	}

	void OnTriggerEnter(Collider doggy) {
		if (doggy.gameObject.tag == "Talkable") {
			dogList.Add (doggy.gameObject);

//-----------------Dog Interactions---------------------------------
		}
	}

	void OnTriggerExit(Collider doggy) {
		if (doggy.gameObject.tag == "Talkable") {
			dogList.Clear ();
		}
	}

//	public void InteractWithDogs() {
//		if (FindClosestDog () != null) {
//			if (FindClosestDog ().gameObject.name == "Jax" && dogInteraction.jaxTennisBall) {
//				Fungus.Flowchart.BroadcastFungusMessage ("JaxTennisBall");
//			} else
//			Fungus.Flowchart.BroadcastFungusMessage (FindClosestDog ().gameObject.name);
//		}
			
//	}

	GameObject FindClosestDog() {
		GameObject closestDog = null;
		float closestDistance = 10000000000.0f;

		foreach (GameObject dog in dogList) {
			if (closestDog == null)
				closestDog = dog;
			else {
				if (Vector3.Distance (this.transform.position, dog.transform.position) < closestDistance) {
					closestDog = dog;
					closestDistance = Vector3.Distance (this.transform.position, dog.transform.position);
				}
			}
			closestDistance = Vector3.Distance (this.transform.position, closestDog.transform.position);
		}
		return closestDog;
	}
}
