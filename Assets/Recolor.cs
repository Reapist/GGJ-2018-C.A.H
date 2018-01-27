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
		//collision.gameObject.GetComponent<Renderer>().material.color = Color.green;
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
		//if (collision.gameObject.tag == "bullet")
		//{
		//	audioplayer.PlayOneShot(hitsound, Random.Range(0.5f, 1.0f));
		//	Destroy(collision.gameObject);
		//	GameObject boom = burst();
		//	Destroy(boom, 1);
		//	hp--;
		//	float ratio = (float)hp / (float)maxhp;
		//	hpbar.transform.localScale = new Vector3(1.2f * (ratio), 0.15f, 1.0f);
		//}
	}
}
