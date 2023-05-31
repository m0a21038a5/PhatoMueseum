using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class churu : MonoBehaviour
{
    //AudoClip�̔z��Aclips��錾���܂��B
    public AudioClip[] clips;
    //AudioSource�^�̕ϐ�audios��錾���܂��B
    AudioSource audios;
    public float countdown = 30.0f;
    private bool Super;

    // Start is called before the first frame update
    void Start()
    {
        audios = GetComponent<AudioSource>();
        audios.clip = clips[0];
        audios.Play();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Super == true)
        {
            countdown -= Time.deltaTime;
            audios.clip = clips[1];
            audios.Play();
            if (countdown <= 0)
            {
                countdown = 30.0f;
                Super = false;
                audios.clip = clips[0];
                audios.Play();
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cat")
        {
            transform.position = new Vector3(100.0f, 0.0f, 0.0f);
            Super = true;
        }
    }
}
