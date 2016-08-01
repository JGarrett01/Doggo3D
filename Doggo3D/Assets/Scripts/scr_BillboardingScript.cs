using UnityEngine;
using System.Collections;

public class scr_BillboardingScript : MonoBehaviour {

    //this script just makes anything you want look at the player. Just using it temp for the dogs.
		
	public GameObject dog;

        void Update()
        {
			transform.LookAt(dog.transform.position, Vector3.up);
        }
    }
