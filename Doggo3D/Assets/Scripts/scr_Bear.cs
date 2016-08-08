using UnityEngine;
using System.Collections;
using Fungus;

public class scr_Bear : MonoBehaviour {
    public bool hasGreeted = false;
    public float timer = 5;


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
            Fungus.Flowchart.BroadcastFungusMessage("Bear");
            hasGreeted = true;

        }

        if (other.gameObject.tag == "Player" && hasGreeted == true && timer <= 0)
        {
            Fungus.Flowchart.BroadcastFungusMessage("Bear2");
        }

    }
}
