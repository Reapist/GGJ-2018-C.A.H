using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseControle : MonoBehaviour
{
    Vector2 startPos;
    Vector2     endPos;
    Vector3 force;
    Rigidbody rb;
    Vector3 keepPos;
    Vector3 maxSpeed;
    float width;
    float heigth;
    Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
         force = new Vector3(0, 0, 0);
        rb = GetComponent<Rigidbody>();
        width = 4.5f;
        heigth = 2.5f;
        maxSpeed = new Vector3(700, 700, 700);
        rb.freezeRotation = true;
        //Instantiate(arrow, new Vector3(1.0f, 2.0f, 0.0f), Quaternion.identity);

     }
    // Update is called once per frame
    void Update()
    {
        anim.speed = 10;

        if (Input.GetMouseButtonDown(0))
        {
            //velocity = 0
            startPos = Input.mousePosition;

        }

        else if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition;
            int speedFactor = 3;
            force.x = speedFactor * (endPos.x - startPos.x);
            force.z = speedFactor * (endPos.y - startPos.y);
            if (force.x > maxSpeed.x)
                force.x = maxSpeed.x;
            if (force.z > maxSpeed.z)
                force.z = maxSpeed.z;
            if (force.x < -maxSpeed.x)
                force.x = -maxSpeed.x;
            if (force.z < -maxSpeed.z)
                force.z = -maxSpeed.z;

            this.rb.AddForce(-force);
        }

        if (width < this.rb.position.x)
        {
            keepPos = this.transform.localPosition;
            keepPos.x = width;
            this.transform.localPosition = keepPos;
            Vector3 a;
            a = this.rb.velocity;
            a.x = -a.x;
           this.rb.velocity = a;
        }

        if (-width > this.rb.position.x)
        {
            keepPos = this.transform.localPosition;
            keepPos.x = -width;
            this.transform.localPosition = keepPos;
            Vector3 a;
            a = this.rb.velocity;
            a.x = -a.x;
            this.rb.velocity = a;
        }

        if (heigth < this.rb.position.z)
        {
            keepPos = this.transform.localPosition;
            keepPos.z = heigth;
            this.transform.localPosition = keepPos;
            Vector3 a;
            a = this.rb.velocity;
            a.z = -a.z;
            this.rb.velocity = a;
        }

        if (-heigth > this.rb.position.z)
        {
            keepPos = this.transform.localPosition;
            keepPos.z = -heigth;
            this.transform.localPosition = keepPos;
            Vector3 a;
            a = this.rb.velocity;
            a.z = -a.z;
            this.rb.velocity = a;
        }

      

    }
}
