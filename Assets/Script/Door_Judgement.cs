using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Judgement : MonoBehaviour
{
    public bool isOpened = false;
    public bool isEnter = false;
    //プレイヤーのタグPhantom_Humanが近づくと実行
    private void OnTriggerStay(Collider other)
    {
        //ドアのタグDoorを取得
        GameObject door1 = GameObject.FindGameObjectWithTag("Door");
        if (other.gameObject.tag == "Phantom_Human")
        {
            Debug.Log("openJugement");
            isEnter = true;
            //Aキーを押すとドアが開閉
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (isEnter && !isOpened)
                {
                    Debug.Log("dooropen");
                    door1.transform.Rotate(0, 90, 0);
                    isOpened = true;
                }
                else if (isEnter && isOpened)
                {
                    door1.transform.Rotate(0, -90, 0);
                    isOpened = false;
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Phantom_Human")
        {
            Debug.Log("closeJugement");
            isEnter = false;
        }
    }
}
