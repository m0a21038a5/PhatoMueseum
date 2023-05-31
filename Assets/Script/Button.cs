using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject sphere;
    public GameObject Blocker;

    void Start()
    {
        sphere.SetActive(false);
        Blocker.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Phantom")
        {
            sphere.SetActive(true);
            Blocker.SetActive(true);
        }
    }
}