using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private Animator animator;

    private string RunR = "RunRight";
    private string RunL = "RunLeft";
    private string RunG = "RunGo1";
    private string RunB = "RunBack";
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            this.animator.SetBool(RunR, true);
        }
        else
        {
            this.animator.SetBool(RunR, false);
        }
        
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            this.animator.SetBool(RunL, true);
        }
        else
        {
            this.animator.SetBool(RunL, false);
        }
        
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            this.animator.SetBool(RunG, true);
        }
        else
        {
            this.animator.SetBool(RunG, false);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            this.animator.SetBool(RunB, true);
        }
        else
        {
            this.animator.SetBool(RunB, false);
        }
        
    }
}
