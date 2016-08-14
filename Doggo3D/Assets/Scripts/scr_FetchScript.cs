using UnityEngine;
using System.Collections;

public class scr_FetchScript : MonoBehaviour {

	public Transform target;
	public float moveSpeed = 3;
	public float rotSpeed = 3;


	void Start () {
		target = GameObject.FindWithTag ("TennisBall2").transform;

	}
	
	// Update is called once per frame
	void Update () 
	{
		
		
		this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (target.position - this.transform.position), rotSpeed * Time.deltaTime);

		this.transform.position += this.transform.forward * moveSpeed * Time.deltaTime;

	}
		
}
