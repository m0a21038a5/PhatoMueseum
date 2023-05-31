using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foot_Sound : MonoBehaviour
{
    public AudioClip FootSound;
    AudioSource audioSouce;
    private void Start()
    {
        audioSouce = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Ground"))
        {
            
            audioSouce.PlayOneShot(FootSound);
            //AudioSource.PlayClipAtPoint(FootSound, transform.position);
        }
    }
}
