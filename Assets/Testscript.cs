using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testscript : MonoBehaviour {

	public Rigidbody rb;
	public GameObject GO;
	void Start()
	{
		GO = GameObject.Find("Sphere");
		rb = GO.GetComponent<Rigidbody>();
		rb.velocity = new Vector3(0, 0, 10);
	}
}
