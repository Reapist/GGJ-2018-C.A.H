﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseControle : MonoBehaviour
{
    Vector2 startPos;
    Vector2     endPos;
    Vector3 force;
    Rigidbody rigidbody;
    Vector3 keepPos;
    GameObject pos;
    float width;
    float heigth;
    GameObject arrow;

    // Use this for initialization
    void Start()
    {
        force = new Vector3(0, 0, 0);
        this.rigidbody = GetComponent<Rigidbody>();
        pos = GameObject.Find("Text");
        width = 4;
        heigth = 2;
        Instantiate(arrow, new Vector3(1.0f, 2.0f, 0.0f), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //velocity = 0
            startPos = Input.mousePosition;

        }

        else if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
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

        this.pos.GetComponent<Text>().text = force.ToString("F2");
        ;

    }
}
