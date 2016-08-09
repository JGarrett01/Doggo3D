using UnityEngine;
using System.Collections;

public class scr_Princess : MonoBehaviour {

    public scr_PlayerController playerController;
    public bool hasBone = false;
    public GameObject inMouth;

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

        if (playerController.currPickup != null)
        {
            inMouth = playerController.currPickup;
            
        }

        if (inMouth.tag == "Pickup" && playerController.currPickup != null)
        {

            hasBone = true;
            Debug.Log("Set");
        }

        


    }

    void Interactions()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && hasBone == false)
        {
            Fungus.Flowchart.BroadcastFungusMessage("Princess");
        }




        if (other.gameObject.tag == "Player" && hasBone == true)
        {
            Fungus.Flowchart.BroadcastFungusMessage("Princess2");
  

        }




    }
}
