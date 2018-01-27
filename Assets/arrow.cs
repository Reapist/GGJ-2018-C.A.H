using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{

    Vector2 startPos;
    Vector3 force;
    GameObject sphere;


    // Use this for initialization
    void Start()
    {
        sphere = GameObject.Find("PlayerCell");
        // スケールを0にすることで画面から消す
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        transform.localPosition = new Vector3(-50, 50, 50);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            //transform.localPosition = new Vector3(0, 0, 0);
            startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            Vector2 endPos = Input.mousePosition;

            // 力ベクトルを算出
            force.x = endPos.x - startPos.x;
            force.z = endPos.y - startPos.y;
            force.Normalize();

            // 矢印の角度を変える
            Vector3 spPos = sphere.transform.position;

            int arrowLength = 2;
            float arrDis = arrowLength * transform.localScale.x;
            float sphereDis = sphere.transform.localScale.x;

            this.transform.localPosition =
                spPos - (sphereDis + arrDis) * 0.5f * force;



             float angle = Mathf.Atan2(force.x, force.z) * Mathf.Rad2Deg;
            // transform.eulerAngles = new Vector3(angle, angle, angle);
            transform.rotation = Quaternion.Euler(0.0f, 90+angle, 90);

            //transform.localPosition.normalized

            // 矢印の大きさを変える
            //transform.localScale = new Vector3(force.magnitude / 40, force.magnitude / 40, 1);

        }
        else if (Input.GetMouseButtonUp(0))
        {
            // スケールを0にすることで画面から消す
            //transform.localScale = new Vector3(0, 0, 0);
            transform.localPosition = new Vector3(-50, 50, 50);

        }
    }
}

