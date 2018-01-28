using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodCellMovement : MonoBehaviour {


	// Update is called once per frame
	void Update () {

		float translation;
		var xPlus = 0;
		var xMinus = 0;
		var yPlus = 0;
		var yMinus = 0;

		if ((Random.value < .5f) && (yMinus < 4))
		{
			translation = Time.deltaTime * -.1f;
			yMinus++;
			if (yPlus > 0)
				yPlus--;
		}
		else
		{
			translation = Time.deltaTime * .1f;
			yPlus++;
			if (yMinus > 0)
				yMinus--;
		}
		transform.Translate(0, translation, 0);

		if ((Random.value < .5f) && (xMinus < 5))
		{
			translation = Time.deltaTime * -.1f;
			xMinus++;
			if (xPlus > 0)
				xPlus--;
		}
		else
		{
			translation = Time.deltaTime * .1f;
			xPlus++;
			if (xMinus > 0)
				xMinus--;
		}
		transform.Translate(translation, 0, 0);
	}
}
