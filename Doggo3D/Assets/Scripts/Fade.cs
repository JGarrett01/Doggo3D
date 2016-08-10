using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Fade : MonoBehaviour {

    public Image image;

	// Use this for initialization
	void Start () {

        image.CrossFadeAlpha(0, 2, false);

    }
	
	// Update is called once per frame
	void Update () {
	


	}
}
