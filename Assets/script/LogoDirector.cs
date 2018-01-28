using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class LogoDirector : MonoBehaviour {
    int countdown = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        countdown++;
        if (countdown >= 600)
        {
            SceneManager.LoadScene("TitleScene");

        }


    }
}
