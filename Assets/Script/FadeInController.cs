using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeInController : MonoBehaviour
{
    float fadeSpeed = 0.3f;        
    float red, green, blue, alfa;   

    public bool isFadeIn;
    public GameObject ReadupScript;

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
            ReadupScript.GetComponent<Readup>().enabled = false;
        }
        else if (isFadeIn == false) 
        {
            ReadupScript.GetComponent<Readup>().enabled = true;
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
        }
    }

    void SetAlpha()
    {
        fadeImage.color = new Color(red, green, blue, alfa);
    }
}
