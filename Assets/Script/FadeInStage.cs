using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FadeInStage : MonoBehaviour
{
    float fadeSpeed = 0.3f;
    float red, green, blue, alfa;

    public bool isFadeIn;
    public GameObject PhantomScript;
    public GameObject GameManager;
    public GameObject ChuruScript1;
    public GameObject ChuruScript2;
    public GameObject FootSoundScript1;
    public GameObject FootSoundScript2;



    Image fadeImage;
    // Start is called before the first frame update
    void Start()
    {

        fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = fadeImage.color.a;
        isFadeIn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFadeIn == true)
        {
            StartFadeIn();
            PhantomScript.GetComponent<Phantom>().enabled = false;
            GameManager.GetComponent<GameManager>().enabled = false;
            ChuruScript1.GetComponent<churu>().enabled = false;
            ChuruScript2.GetComponent<churu>().enabled = false;
            FootSoundScript1.GetComponent<Foot_Sound>().enabled = false;
            FootSoundScript2.GetComponent<Foot_Sound>().enabled = false;
        }
        else if (isFadeIn == false)
        {
            PhantomScript.GetComponent<Phantom>().enabled = true;
            GameManager.GetComponent<GameManager>().enabled = true;
            ChuruScript1.GetComponent<churu>().enabled = true;
            ChuruScript2.GetComponent<churu>().enabled = true;
            FootSoundScript1.GetComponent<Foot_Sound>().enabled = true;
            FootSoundScript2.GetComponent<Foot_Sound>().enabled = true;
        }
    }

    void StartFadeIn()
    {
        fadeImage.enabled = true;
        alfa -= fadeSpeed * Time.deltaTime;
        SetAlpha();
        if (alfa <= 0)
        {
            isFadeIn = false;
            fadeImage.enabled = false;
        }
    }

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }
}
