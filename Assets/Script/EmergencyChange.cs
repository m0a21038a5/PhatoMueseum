using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmergencyChange : MonoBehaviour
{
    public GameObject cat;
    public GameObject phantom;
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

            if (cat.activeSelf)
            //猫が表示されているのなら
            {
                phantom.SetActive(true);
                cat.SetActive(false);
                //猫を非表示に
                phantom.transform.position = new Vector3(cat.transform.position.x, cat.transform.position.y + 5, cat.transform.position.z);
            }
        }
    }
}
