using UnityEngine;
using System.Collections;

public class Scr_Diolouge : MonoBehaviour {

    public bool isTalking = false;
    public GameObject UI_Talk;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if (isTalking == true)
        {

            UI_Talk.SetActive(true);


        }

        if(isTalking == false)
        {


            UI_Talk.SetActive(false);

        }

	}

    void OnTriggerEnter(Collider other)
    {


        if(other.tag == "Talkable")
        {

            isTalking = true;


        }


    }

    void OnTriggerExit(Collider other)
    {

        if (other.tag == "Talkable")
        {

            isTalking = false;
        }

    }
}
