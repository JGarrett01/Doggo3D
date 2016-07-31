using UnityEngine;
using System.Collections;

public class scr_BillboardingScript : MonoBehaviour {

    //this script just makes anything you want look at the player. Just using it temp for the dogs.

        void Update()
        {
            transform.LookAt(Camera.main.transform.position, Vector3.up);
        }
    }
