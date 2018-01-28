using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonDirector : MonoBehaviour {

    float speed = 0.15f;
    int countdown = 0;
    
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        countdown++;
        if(countdown > 24)
        {
            this.speed *= -1;
            countdown = 0;
        }

        transform.Translate(0, this.speed, 0);

    }
}
