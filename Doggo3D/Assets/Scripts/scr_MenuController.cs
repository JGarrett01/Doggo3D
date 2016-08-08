using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class scr_MenuController : MonoBehaviour {

    

	// Use this for initialization
	void Start () {

	}

    //This lets you start the game.
    public void StartGame()
    {
		SceneManager.LoadScene ("ParkScene");
    }

	public void About()
	{
		SceneManager.LoadScene ("AboutScene");
	}

    public void QuitGame()
    {
        Application.Quit();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
