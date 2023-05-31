using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LazerAttack : MonoBehaviour
{
    public GameObject phantom;
    public GameObject cat;
    public GameObject respawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Character")
        {
            phantom.transform.position = respawn.transform.position;
            cat.transform.position = respawn.transform.position;
        }
    }
}
