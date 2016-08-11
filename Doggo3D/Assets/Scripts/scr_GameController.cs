using UnityEngine;
using System.Collections;
using Fungus;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scr_GameController : MonoBehaviour
{

    public scr_Maple mapleScript;
    public scr_Jax jaxScript;
    public scr_Kiki kikiScript;
    public scr_Princess princessScript;
    public scr_Zeus zeusScript;
    public scr_Bear bearScript;

    public bool allDone = false;
    public float endTimer = 5.0f;

    public GUITexture FadeToBlack;

    public float fadeTime = 4.0f;
    float rate;
    float progressive = 0.0f;



    // Use this for initialization
    void Start()
    {
        rate = 1.0f / fadeTime;
    }

    // Update is called once per frame
    void Update()
    {


        if (mapleScript.hasGreeted && jaxScript.hasCompleted && kikiScript.hasCompleted && princessScript.hasCompleted && zeusScript.hasGreeted && bearScript.hasGreeted)
        {
            allDone = true;
        }


        if (allDone)
        {


            Fungus.Flowchart.BroadcastFungusMessage("endGame");

            endTimer -= Time.deltaTime;

            

            progressive += rate * Time.deltaTime;

            FadeToBlack.color = Color.Lerp(Color.clear, Color.black, progressive);

            


            if (endTimer <= 0)
            {

                //endGame here

                SceneManager.LoadScene("CreditScene");



            }


        }



    }
}
