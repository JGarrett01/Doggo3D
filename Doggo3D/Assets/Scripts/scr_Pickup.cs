using UnityEngine;
using System.Collections;

public class scr_Pickup : MonoBehaviour {

	public Collider col;
	public Vector3 scale;
	public Vector3 parentScale = Vector3.zero;
	public GameObject player;

	// Use this for initialization
	void Start () {
		col = GetComponent<Collider> ();

		scale = this.transform.localScale;
		Debug.Log (scale);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (this.transform.IsChildOf (player.transform)) 
		{
			if(parentScale == Vector3.zero)
			parentScale = this.transform.localScale;
			this.transform.localScale = parentScale;
		} else {
			if (this.transform.localScale != scale) {
				this.transform.localScale = scale;
			}
		}
	}

}
