using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorEnemyMove : MonoBehaviour
{
    public GameObject FloorEnemy_01;
    public GameObject FloorEnemy_02;
    public GameObject FloorEnemy_03;

    public float count1 = 30.0f;
    public float count2 = 30.0f;
    public float count3 = 30.0f;
    public float count4 = 30.0f;
    public float count5 = 30.0f;
    public float count6 = 30.0f;
    public float count7 = 30.0f;
    public float count8 = 30.0f;
    public float count9 = 30.0f;
    public float count10 = 30.0f;
    public float count11 = 30.0f;
    public float count12 = 30.0f;

    int RotateCount1 = 0;
    int MoveCount1 = 0;
    int RotateCount2 = 0;
    int MoveCount2 = 0;
    int RotateCount3 = 0;
    int MoveCount3 = 0;



    // Start is called before the first frame update
    void Start()
    {
        //FloorEnemy1でFloorEnemy (1)というオブジェクトを参照
        FloorEnemy_01 = GameObject.Find("FloorEnemy_01");

        //FloorEnemy2でFloorEnemy (2)というオブジェクトを参照
        FloorEnemy_02 = GameObject.Find("FloorEnemy_02");

        //FloorEnemy3でFloorEnemy (3)というオブジェクトを参照
        FloorEnemy_03 = GameObject.Find("FloorEnemy_03");
    }

    // Update is called once per frame
    void Update()
    {



       
        

        if (MoveCount1 == 0)
        {
            
            count1 -= Time.deltaTime;
            if (count1 > 0)
            {
                FloorEnemy_01.transform.position += new Vector3(6.0f * Time.deltaTime, 0.0f, 0.0f);
            }


            else if (count1 < 0)
            {
                if (RotateCount1 == 0)
                {
                    FloorEnemy_01.transform.Rotate(0, 90, 0);
                }
                RotateCount1++;
                MoveCount1++;
                count2 = 6f;
            }
        }
        if (MoveCount1 == 1)
        {
            
            count2 -= Time.deltaTime;
            if (count2 > 0)
            {
                FloorEnemy_01.transform.position += new Vector3(0.0f, 0.0f, -6.0f * Time.deltaTime);
            }

            else if (count2 < 0)
            {
                if (RotateCount1 == 1)
                {
                    FloorEnemy_01.transform.Rotate(0, 90, 0);
                }
                RotateCount1++;
                MoveCount1++;
                count3 = 5.5f;
            }
        }
        if (MoveCount1 == 2)
        {
            count3 -= Time.deltaTime;
            if (count3 > 0)
            {
                FloorEnemy_01.transform.position += new Vector3(-6.0f * Time.deltaTime, 0.0f, 0.0f);
            }

            else if (count3 < 0)
            {
                if (RotateCount1 == 2)
                {
                    FloorEnemy_01.transform.Rotate(new Vector3(0, 90, 0));
                }
                RotateCount1++;
                MoveCount1++;
                count4 = 6f;
            }
        }

        if (MoveCount1 == 3)
        {
            count4 -= Time.deltaTime;
            if (count4 > 0)
            {
                FloorEnemy_01.transform.position += new Vector3(0.0f, 0.0f, 6.0f * Time.deltaTime);
            }
            else if (count4 < 0)
            {
                if (RotateCount1 == 3)
                {
                    FloorEnemy_01.transform.Rotate(new Vector3(0, 90, 0));
                }
                RotateCount1 = 0;
                MoveCount1 = 0;
                count1 = 5.5f;
            }
        }


        if (MoveCount2 == 0)
        {

            count5 -= Time.deltaTime;
            if (count5 > 0)
            {
                FloorEnemy_02.transform.position += new Vector3(0.0f, 0.0f, 6.0f * Time.deltaTime);
            }


            else if (count5 < 0)
            {
                if (RotateCount2 == 0)
                {
                    FloorEnemy_02.transform.Rotate(0, 90, 0);
                }
                RotateCount2++;
                MoveCount2++;
                count6 = 5.5f;
            }
        }
        if (MoveCount2 == 1)
        {

            count6 -= Time.deltaTime;
            if (count6 > 0)
            {
                FloorEnemy_02.transform.position += new Vector3(6.0f * Time.deltaTime, 0.0f, 0.0f);
            }

            else if (count6 < 0)
            {
                if (RotateCount2 == 1)
                {
                    FloorEnemy_02.transform.Rotate(0, 90, 0);
                }
                RotateCount2++;
                MoveCount2++;
                count7 = 6f;
            }
        }
        if (MoveCount2 == 2)
        {
            count7 -= Time.deltaTime;
            if (count7 > 0)
            {
                FloorEnemy_02.transform.position += new Vector3(0.0f, 0.0f, -6.0f * Time.deltaTime);
            }

            else if (count7 < 0)
            {
                if (RotateCount2 == 2)
                {
                    FloorEnemy_02.transform.Rotate(new Vector3(0, 90, 0));
                }
                RotateCount2++;
                MoveCount2++;
                count8 = 6f;
            }
        }

        if (MoveCount2 == 3)
        {
            count8 -= Time.deltaTime;
            if (count8 > 0)
            {
                FloorEnemy_02.transform.position += new Vector3(-6.0f * Time.deltaTime, 0.0f, 0.0f);
            }
            else if (count8 < 0)
            {
                if (RotateCount2 == 3)
                {
                    FloorEnemy_02.transform.Rotate(new Vector3(0, 90, 0));
                }
                RotateCount2 = 0;
                MoveCount2 = 0;
                count5 = 5.5f;
            }
        }

        if (MoveCount3 == 0)
        {

            count9 -= Time.deltaTime;
            if (count9 > 0)
            {
                FloorEnemy_03.transform.position += new Vector3(-6.0f * Time.deltaTime, 0.0f, 0.0f);
            }


            else if (count9 < 0)
            {
                if (RotateCount3 == 0)
                {
                    FloorEnemy_03.transform.Rotate(0, 90, 0);
                }
                RotateCount3++;
                MoveCount3++;
                count10 = 6f;
            }
        }
        if (MoveCount3 == 1)
        {

            count10 -= Time.deltaTime;
            if (count10 > 0)
            {
                FloorEnemy_03.transform.position += new Vector3(0.0f, 0.0f, 6.0f * Time.deltaTime);
            }

            else if (count10 < 0)
            {
                if (RotateCount3 == 1)
                {
                    FloorEnemy_03.transform.Rotate(0, 90, 0);
                }
                RotateCount3++;
                MoveCount3++;
                count11 = 6f;
            }
        }
        if (MoveCount3 == 2)
        {
            count11 -= Time.deltaTime;
            if (count11 > 0)
            {
                FloorEnemy_03.transform.position += new Vector3(6.0f * Time.deltaTime, 0.0f, 0.0f);
            }

            else if (count11 < 0)
            {
                if (RotateCount3 == 2)
                {
                    FloorEnemy_03.transform.Rotate(new Vector3(0, 90, 0));
                }
                RotateCount3++;
                MoveCount3++;
                count12 = 6.5f;
            }
        }

        if (MoveCount3 == 3)
        {
            count12 -= Time.deltaTime;
            if (count12 > 0)
            {
                FloorEnemy_03.transform.position += new Vector3(0.0f, 0.0f, -6.0f * Time.deltaTime);
            }
            else if (count12 < 0)
            {
                if (RotateCount3 == 3)
                {
                    FloorEnemy_03.transform.Rotate(new Vector3(0, 90, 0));
                }
                RotateCount3 = 0;
                MoveCount3 = 0;
                count9 = 6f;
            }
        }


    }
}
