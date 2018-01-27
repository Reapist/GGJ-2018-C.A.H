using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{

    Vector2 startPos;
    Vector3 force;



    // Use this for initialization
    void Start()
    {

        // スケールを0にすることで画面から消す
        transform.localScale = new Vector3(1, 1, 1);
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

            // 矢印の角度を変える
            transform.localPosition = new Vector3(-force.x/400, 0, -force.z/400);
            // float angle = Mathf.Atan2(force.x, force.y) * Mathf.Rad2Deg;
            // transform.eulerAngles = new Vector3(angle, angle, angle);
            //transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle);

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

