using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public AudioClip ClickSound;
    AudioSource audioSouce;
    public float countdown = 2.0f;
    private bool Play;
    public GameObject FadeOutScript;

    private void Start()
    {
        audioSouce = GetComponent<AudioSource>();
        Play = false;
        FadeOutScript.GetComponent<FadeController>().enabled = false;
    }
    public void OnStartButtonClicked()
    {
        audioSouce.PlayOneShot(ClickSound);
        Play = true;
        FadeOutScript.GetComponent<FadeController>().enabled = true;
    }

    private void Update()
    {
        if(Play == true)
        {
            countdown -= Time.deltaTime;
        }
       
        if (countdown <= 0)
        {
            SceneManager.LoadScene("Story");
        }
    }
}
