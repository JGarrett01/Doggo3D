using UnityEngine;
using System.Collections;

public class scr_PlayerController : MonoBehaviour {

	public bool canPickup = true;
	public bool hasPickup = false;
	public GameObject mouthHole;
	public GameObject currPickup;
	public GameObject player;
	public CapsuleCollider capCol;
	public CharacterJoint joint;


	void Start () 
	{
		capCol = GetComponent<CapsuleCollider> ();
		joint = GetComponentInChildren<CharacterJoint> ();
	}

	void LateUpdate () 
	{
	//	currPickup.GetComponent<Collider> ().enabled = true;
		PickupController ();


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
		}
	}

	void OnTriggerStay(Collider other)
	{
		if (currPickup == null) 
		{
			if (other.gameObject.tag == "Pickup")
			{
				currPickup = other.gameObject;
			}
		}

			
	}

//	void OnTriggerExit(Collider other)
//	{
//		currPickup = null;
//	}
}
