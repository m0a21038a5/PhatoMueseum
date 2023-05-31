using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSound_appearance : MonoBehaviour
{
    public GameObject PhantomScript;
    public GameObject CatScript;
    public GameObject PhantomAndCat;
    public GameObject FootSoundScript1;
    public GameObject FootSoundScript2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            CatScript.GetComponent<Cat>().enabled = true;
            PhantomScript.GetComponent<Phantom>().enabled = true;
            PhantomAndCat.GetComponent<GameManager>().enabled = true;
            FootSoundScript1.GetComponent<Foot_Sound>().enabled = true;
            FootSoundScript2.GetComponent<Foot_Sound>().enabled = true;
        }
    }
    
}
