using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public GameObject BreakWall;
    public GameObject sphere;
    public GameObject Blocker;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += new Vector3(-2.0f * Time.deltaTime, 0f, 0f);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "BreakWall")
        {
            Destroy(BreakWall);
            Destroy(sphere);
            Destroy(Blocker);
        }
    }
}