using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCamera : MonoBehaviour
{
    private Vector3 angle;
    public float speed = 10.0f;
    void Start()
    {
        angle = transform.eulerAngles;
    }

    void Update()
    {
        //W,Sキーで上下回転、A,Dキーで左右移動
        if(Input.GetKey(KeyCode.W))
        {
            angle.x-= 0.5f;
            transform.eulerAngles = new Vector3(angle.x, transform.root.eulerAngles.y, 0);
           
        }
        else if(Input.GetKey(KeyCode.S))
        {
            angle.x += 0.5f;
            transform.eulerAngles = new Vector3(angle.x, transform.root.eulerAngles.y, 0);
            
        }
        else if(Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
    }
}
