using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Shootdown : MonoBehaviour
{
    public GameObject Phantom;
    public GameObject Rope;
    public GameObject LoadSupport;
    //�ʏ�̃J������mainCamera�e�̃J������bulletCamera�Ɏw��
    public GameObject mainCamera;
    public GameObject bulletCamera;
    public GameObject PhantomScript;
    public GameObject shootdownOperation;
    public GameObject PhantomAndCat;
    public GameObject FootSoundScript1;
    public GameObject FootSoundScript2;
    void Start()
    {
        //�e�̃J�������I�t
        bulletCamera.SetActive(false);
        shootdownOperation.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Rope.SetActive(false);
            LoadSupport.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.name == "Phantom")
        {
            //�e�̃J�����֐؂�ւ�
            bulletCamera.SetActive(true);
            shootdownOperation.SetActive(true);
            FootSoundScript1.GetComponent<Foot_Sound>().enabled = false;
            FootSoundScript2.GetComponent<Foot_Sound>().enabled = false;
            shootdownOperation.SetActive(true);
            // mainCamera.SetActive(false);
            //Phantom��Cat�̓������~�߂�ׁA���ꂼ��̃X�N���v�g�̃`�F�b�N���O��
            PhantomScript.GetComponent<Phantom>().enabled = false;
            PhantomAndCat.GetComponent<GameManager>().enabled = false;
        }
        
    }
    

}

