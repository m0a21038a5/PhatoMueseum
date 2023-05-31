using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer_onoff_1 : MonoBehaviour
{
    public GameObject LaserA;
    public GameObject LaserB;

    //LaserA��e�Ƃ����I�u�W�F�N�g������Ă鎞��[s]
    int A_ON = 10;
    //LaserA��e�Ƃ����I�u�W�F�N�g�������Ă��鎞��[s]
    int A_OFF = 8;


    //LaserB��e�Ƃ����I�u�W�F�N�g������Ă鎞��[s]
    int B_ON = 15;
    //LaserB��e�Ƃ����I�u�W�F�N�g�������Ă��鎞��[s]
    int B_OFF = 9;

    int countA = 0;
    int countB = 0;

    private float interval = 1f;
    private float tmpTime = 0;


    // Start is called before the first frame update
    void Start()
    {
        //LaserA��LaserA�Ƃ����I�u�W�F�N�g���Q��
        LaserA = GameObject.Find("LaserA");

        //LaserB��LaserB�Ƃ����I�u�W�F�N�g���Q��
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
                //LaserA���\��
                LaserA.SetActive(false);
            }
            if (countA == A_ON + A_OFF)
            {
                //LaserA��\��
                LaserA.SetActive(true);
                countA = 0;
            }


            if (countB == B_ON)
            {
                //LaserB���\��
                LaserB.SetActive(false);
            }
            if (countB == B_ON + B_OFF)
            {
                //LaserB��\��
                LaserB.SetActive(true);
                countB = 0;
            }
        }
       

    }
}