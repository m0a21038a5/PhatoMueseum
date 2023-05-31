using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer_onoff_1 : MonoBehaviour
{
    public GameObject LaserA;
    public GameObject LaserB;

    //LaserAを親としたオブジェクトが現れてる時間[s]
    int A_ON = 10;
    //LaserAを親としたオブジェクトが消えている時間[s]
    int A_OFF = 8;


    //LaserBを親としたオブジェクトが現れてる時間[s]
    int B_ON = 15;
    //LaserBを親としたオブジェクトが消えている時間[s]
    int B_OFF = 9;

    int countA = 0;
    int countB = 0;

    private float interval = 1f;
    private float tmpTime = 0;


    // Start is called before the first frame update
    void Start()
    {
        //LaserAでLaserAというオブジェクトを参照
        LaserA = GameObject.Find("LaserA");

        //LaserBでLaserBというオブジェクトを参照
        LaserB = GameObject.Find("LaserB");
    }

    // Update is called once per frame
    void Update()
    {
        tmpTime += Time.deltaTime;
        if (tmpTime >= interval)
        {
            countA += 1;
            countB += 1;


            tmpTime = 0;


            if (countA == A_ON)
            {
                //LaserAを非表示
                LaserA.SetActive(false);
            }
            if (countA == A_ON + A_OFF)
            {
                //LaserAを表示
                LaserA.SetActive(true);
                countA = 0;
            }


            if (countB == B_ON)
            {
                //LaserBを非表示
                LaserB.SetActive(false);
            }
            if (countB == B_ON + B_OFF)
            {
                //LaserBを表示
                LaserB.SetActive(true);
                countB = 0;
            }
        }
       

    }
}