using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seesaw : MonoBehaviour
{
    public GameObject plane;
    public GameObject Wall;
  
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "under")
        {
            
            Wall.SetActive(false);
        }
    }
}
