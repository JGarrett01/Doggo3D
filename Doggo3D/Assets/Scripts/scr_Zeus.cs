using UnityEngine;
using System.Collections;
using Fungus;

public class scr_Zeus : MonoBehaviour {

    public bool hasGreeted = false;
    public float timer = 5;
    public int Rand;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (hasGreeted == true)
        {


            timer -= Time.deltaTime;

        }

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player" && hasGreeted == false)
        {
            Fungus.Flowchart.BroadcastFungusMessage("Zeus");
            hasGreeted = true;

        }

        if (other.gameObject.tag == "Player" && hasGreeted == true && timer <= 0)
        {

            Rand = Random.Range(0, 4);

            if (Rand == 1)
            {

                Fungus.Flowchart.BroadcastFungusMessage("Zeus2");
                timer = 3.0f;
            }

            if (Rand == 2)
            {

                Fungus.Flowchart.BroadcastFungusMessage("Zeus3");
                timer = 3.0f;
            }

            if (Rand == 3)
            {

                Fungus.Flowchart.BroadcastFungusMessage("Zeus4");
                timer = 3.0f;
            }



        }

    }
}
