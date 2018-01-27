using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recolor : MonoBehaviour {

	public Renderer Renderer;
	public GameObject GO;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "PlayerA")
		{
			gameObject.tag = "ControlledA";
			gameObject.GetComponent<Renderer>().material.color = Color.red;
		}
		else if (collision.gameObject.tag == "PlayerB") 
		{
			gameObject.tag = "ControlledB";
			gameObject.GetComponent<Renderer>().material.color = Color.blue;
		}
	}

	void OnTriggerEnter(Collision collision)
	{
		if (collision.gameObject.tag == "PlayerA")
		{
			gameObject.tag = "ControlledA";
			gameObject.GetComponent<Renderer>().material.color = Color.red;
		}
		else if (collision.gameObject.tag == "PlayerB")
		{
			gameObject.tag = "ControlledB";
			gameObject.GetComponent<Renderer>().material.color = Color.blue;
		}
	}
}
