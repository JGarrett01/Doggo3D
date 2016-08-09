using UnityEngine;
using System.Collections;

public class scr_Princess : MonoBehaviour {

    public scr_PlayerController playerController;
    public bool hasBone = false;
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
            hasBone = false;

        }

        
        
            inMouth = playerController.currPickup;
            
        

        if (inMouth.tag == "Pickup" && playerController.currPickup != null)
        {

            hasBone = true;
            
        }

        


    }

    void Interactions()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && hasBone == false && hasCompleted == false)
        {
            Fungus.Flowchart.BroadcastFungusMessage("Princess");
        }




        if (other.gameObject.tag == "Player" && hasBone == true)
        {
            Fungus.Flowchart.BroadcastFungusMessage("Princess2");
            hasCompleted = true;

        }

        if (other.gameObject.tag == "Player" && hasCompleted == true)
        {
            Fungus.Flowchart.BroadcastFungusMessage("Princess2");
            

        }


    }
}
