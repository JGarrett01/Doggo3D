using UnityEngine;
using System.Collections;

public class scr_Kiki : MonoBehaviour {

    public scr_PlayerController playerController;
    public bool hasItem = false;
    public GameObject inMouth;
    public bool hasCompleted = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (playerController.currPickup == null)
        {
            hasItem = false;

        }



        inMouth = playerController.currPickup;



        if (inMouth.tag == "Pickup" || inMouth.tag == "TennisBall" && playerController.currPickup != null)
        {

            hasItem = true;

        }




    }

    void Interactions()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && hasItem == false && hasCompleted == false)
        {
            Fungus.Flowchart.BroadcastFungusMessage("Kiki");
        }




        if (other.gameObject.tag == "Player" && hasItem == true)
        {
            Fungus.Flowchart.BroadcastFungusMessage("Kiki2");
            hasCompleted = true;

        }

        if (other.gameObject.tag == "Player" && hasCompleted == true)
        {
            Fungus.Flowchart.BroadcastFungusMessage("Kiki2");


        }


    }
}