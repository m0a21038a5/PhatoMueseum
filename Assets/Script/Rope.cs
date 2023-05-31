using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    public GameObject PhantomScript;
    
    public GameObject PhantomAndCat;
    public GameObject FootSoundScript1;
    public GameObject FootSoundScript2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            //PhantomとCatを動かせるようにするため、それぞれのスクリプトのチェックをつける
            
            PhantomScript.GetComponent<Phantom>().enabled = true;
            PhantomAndCat.GetComponent<GameManager>().enabled = true;
            FootSoundScript1.GetComponent<Foot_Sound>().enabled = true;
            FootSoundScript2.GetComponent<Foot_Sound>().enabled = true;

        }
    }
}
