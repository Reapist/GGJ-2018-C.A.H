using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {
    
    Vector2 startPos;
    Vector2 endPos;
    Vector3 force;
    Rigidbody rb;
    Vector3 keepPos;
    float width;
    float heigth;
    int cooldown;

    // Use this for initialization
    void Start () {
        force = new Vector3(0, 0, 0);
        this.rb = GetComponent<Rigidbody>();
        width = 4;
        heigth = 2;
        cooldown = 3;

        this.rb.freezeRotation = true;
    }
    
    // Update is called once per frame
    void Update () {
        cooldown--;
        if (cooldown <= 0)
        {
            //Random.
            startPos = new Vector2(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            endPos = new Vector2(Random.Range(-100.0f, 100.0f), Random.Range(-100.0f, 100.0f));
            int forceFactor = 5;
            force.x = forceFactor * (endPos.x - startPos.x);
            force.z = forceFactor * (endPos.y - startPos.y);

            this.rb.AddForce(-force);

            cooldown = 30;
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

        //this.pos.GetComponent<Text>().text = force.ToString("F2");

    }



}
