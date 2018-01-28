using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallRecolor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		var collider = other.gameObject;
		if (gameObject.tag == "PlayerA")
		{
			collider.tag = "ControlledA";
			collider.GetComponent<Renderer>().material.color = Color.red;
		}
		else if (gameObject.tag == "PlayerB" && (collider.tag == "ControlledA" || collider.tag == "Neutral"))
		{
			collider.tag = "ControlledB";
			collider.GetComponent<Renderer>().material.color = Color.blue;
		}
	}
}
