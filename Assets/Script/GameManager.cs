using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cat;
    public GameObject phantom;
    public GameObject catOperation;
    public GameObject phantomOperation;

    public float operation = 10.0f;
    public float operationcat = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        cat.SetActive(false);
        catOperation.SetActive(false);
        //Å‰‚Í”L‚ğ”ñ•\¦‚É‚·‚é
       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
           
            
            if (cat.activeSelf)
            //”L‚ª•\¦‚³‚ê‚Ä‚¢‚é‚Ì‚È‚ç
            {
                phantom.SetActive(true);
                phantomOperation.SetActive(true);
                //‰ö“‚ğ•\¦
                cat.SetActive(false);
                //”L‚ğ”ñ•\¦‚É
                phantom.transform.position = new Vector3(cat.transform.position.x, cat.transform.position.y + 5, cat.transform.position.z);
            }
            else
            {
                cat.SetActive(true);
                catOperation.SetActive(true);
                //”L‚ğ•\¦
                phantom.SetActive(false);
                //‰ö“‚ğ”ñ•\¦‚É
                cat.transform.position = new Vector3(phantom.transform.position.x, phantom.transform.position.y, phantom.transform.position.z);
            }
           
        }

        if (phantomOperation.activeSelf)
        {
            operation -= Time.deltaTime;
        }
        if (operation <= 0 || cat.activeSelf)
        {
            phantomOperation.SetActive(false);
        }

        if (catOperation.activeSelf)
        {
            operationcat -= Time.deltaTime;
        }
        if (operationcat <= 0 || phantom.activeSelf)
        {
            catOperation.SetActive(false);
        }
    }
}
