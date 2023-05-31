using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Judgement : MonoBehaviour
{
    public bool isOpened = false;
    public bool isEnter = false;
    //�v���C���[�̃^�OPhantom_Human���߂Â��Ǝ��s
    private void OnTriggerStay(Collider other)
    {
        //�h�A�̃^�ODoor���擾
        GameObject door1 = GameObject.FindGameObjectWithTag("Door");
        if (other.gameObject.tag == "Phantom_Human")
        {
            Debug.Log("openJugement");
            isEnter = true;
            //A�L�[�������ƃh�A���J��
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
