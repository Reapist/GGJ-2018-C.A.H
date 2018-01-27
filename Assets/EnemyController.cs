using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {


    Vector2 startPos;
    Vector2 endPos;
    Vector3 force;
    Rigidbody rigidbody;
    Vector3 keepPos;
    GameObject pos;
    float width;
    float heigth;
    //GameObject arrow;
    bool mouseState;
    //bool wasMouseState;
    int cooldown;
    int randomize;

    // Use this for initialization
    void Start () {
        force = new Vector3(0, 0, 0);
        this.rigidbody = GetComponent<Rigidbody>();
        pos = GameObject.Find("Text");
        width = 4;
        heigth = 2;
        //Instantiate(arrow, new Vector3(1.0f, 2.0f, 0.0f), Quaternion.identity);
        mouseState = false;
        //wasMouseState = false;
        cooldown = 3;
        randomize = 1;
    }

    // Update is called once per frame
    void Update () {
        /*
        int rand1 = random
        if(time since last change > rand1 seconds)
        {

        }

    */




        cooldown--;
        if (cooldown <= 0)
        {
            randomize = (int)Random.Range(0.0f, 1.0f);
            cooldown = 30;
        }
        //wasMouseState = mouseState;
        if (randomize == 0)
        {
            mouseState = false;
        }
        else if (randomize == 1)
        {
            mouseState = true;
        }

        if (mouseState == true)
        {
            //velocity = 0
            startPos = new Vector2(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            mouseState = false;

        }

       if (mouseState == false )//&&
        //    mouseState != wasMouseState)
        {
            endPos = new Vector2(Random.Range(-100.0f, 100.0f), Random.Range(-100.0f, 100.0f));
            //force = endPos - startPos;
            force.x = endPos.x - startPos.x;
            force.z = endPos.y - startPos.y;


            this.rigidbody.AddForce(-force);
        }

        if (width < this.rigidbody.position.x)
        {
            keepPos = this.transform.localPosition;
            keepPos.x = width;
            this.transform.localPosition = keepPos;
            Vector3 a;
            a = this.rigidbody.velocity;
            a.x = -a.x;
            this.rigidbody.velocity = a;
        }

        if (-width > this.rigidbody.position.x)
        {
            keepPos = this.transform.localPosition;
            keepPos.x = -width;
            this.transform.localPosition = keepPos;
            Vector3 a;
            a = this.rigidbody.velocity;
            a.x = -a.x;
            this.rigidbody.velocity = a;
        }

        if (heigth < this.rigidbody.position.z)
        {
            keepPos = this.transform.localPosition;
            keepPos.z = heigth;
            this.transform.localPosition = keepPos;
            Vector3 a;
            a = this.rigidbody.velocity;
            a.z = -a.z;
            this.rigidbody.velocity = a;
        }

        if (-heigth > this.rigidbody.position.z)
        {
            keepPos = this.transform.localPosition;
            keepPos.z = -heigth;
            this.transform.localPosition = keepPos;
            Vector3 a;
            a = this.rigidbody.velocity;
            a.z = -a.z;
            this.rigidbody.velocity = a;
        }

        //this.pos.GetComponent<Text>().text = force.ToString("F2");
        ;

    }



}
