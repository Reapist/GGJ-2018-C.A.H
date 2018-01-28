using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
			foreach (Material m in collider.GetComponent<Renderer>().materials)
			{
				m.color = Color.red;
			}
		}
		else if (gameObject.tag == "PlayerB" && (collider.tag == "ControlledA" || collider.tag == "Neutral"))
		{
			collider.tag = "ControlledB";
			foreach (Material m in collider.GetComponent<Renderer>().materials)
			{
				m.color = Color.blue;
			}
		}
	}
}
