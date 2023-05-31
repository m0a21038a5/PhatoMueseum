using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Readup : MonoBehaviour
{
    public GameObject FadeOutScript;
    void Start()
    {
        FadeOutScript.GetComponent<FadeController>().enabled = false;
    }

    void Update()
    {
        transform.Translate(0.0f, 10.0f * Time.deltaTime, 0.0f);
        if(transform.position.y >= 90)
        {
            FadeOutScript.GetComponent<FadeController>().enabled = true;
        }
       if (transform.position.y >= 155 || Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("SampleScene 1");
        }
    }
}
